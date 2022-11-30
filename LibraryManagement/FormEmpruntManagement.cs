using LibraryManagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormEmpruntManagement : Form
    {
        public FormEmpruntManagement()
        {
            InitializeComponent();
        }

        private void comboBoxOuvrageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using LibraryContext libraryContext = new LibraryContext();

            listViewOuvrages.Items.Clear();

            if (comboBoxOuvrageType.SelectedIndex == 0) // Periodic
            {
                foreach (Periodique periodique in libraryContext.Periodiques.AsNoTracking().ToList())
                {
                    ListViewItem listViewItem = new ListViewItem(periodique.Id.ToString());
                    listViewItem.SubItems.Add(periodique.Auteur);
                    listViewItem.SubItems.Add(periodique.Titre);
                    listViewItem.SubItems.Add(periodique.Quantite.ToString());
                    listViewItem.SubItems.Add(periodique.Disponible.ToString());
                    listViewItem.SubItems.Add(periodique.Periodicite.ToString());
                    listViewOuvrages.Items.Add(listViewItem);
                }
            }
            else if (comboBoxOuvrageType.SelectedIndex == 1) // CD
            {
                foreach (CD cd in libraryContext.CDs.AsNoTracking().ToList())
                {
                    ListViewItem listViewItem = new ListViewItem(cd.Id.ToString());
                    listViewItem.SubItems.Add(cd.Auteur);
                    listViewItem.SubItems.Add(cd.Titre);
                    listViewItem.SubItems.Add(cd.Quantite.ToString());
                    listViewItem.SubItems.Add(cd.Disponible.ToString());
                    listViewOuvrages.Items.Add(listViewItem);
                }
            }
            else if (comboBoxOuvrageType.SelectedIndex == 2) // Book
            {
                foreach (Livre livre in libraryContext.Livres.AsNoTracking().ToList())
                {
                    ListViewItem listViewItem = new ListViewItem(livre.Id.ToString());
                    listViewItem.SubItems.Add(livre.Auteur);
                    listViewItem.SubItems.Add(livre.Titre);
                    listViewItem.SubItems.Add(livre.Quantite.ToString());
                    listViewItem.SubItems.Add(livre.Disponible.ToString());
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(livre.Editeur.ToString());
                    listViewOuvrages.Items.Add(listViewItem);
                }
            }
            if (labelFullName.Text.Length > 0)
            {
                filllistViewClientEmprunts();
            }
        }

        private string getComboBoxOuvrageType()
        {
            if (comboBoxOuvrageType.SelectedIndex == 0) // Periodic => Periodique from models
            {
                return new Periodique().GetType().Name;
            }
            else if (comboBoxOuvrageType.SelectedIndex == 1) // CD => CD from models
            {
                return new CD().GetType().Name;
            }
            else if (comboBoxOuvrageType.SelectedIndex == 2) // Book => Livre from models
            {
                return new Livre().GetType().Name;
            }
            return "";
        }

        private void filllistViewClientEmprunts()
        {
            if (comboBoxOuvrageType.SelectedIndex == -1)
            {
                MessageBox.Show("Select an ouvrage type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelOuvrageDetails.Text = "";
            listViewClientEmprunts.Items.Clear();

            using LibraryContext libraryContext = new LibraryContext();

            Client? client = libraryContext.Clients
                .Include(c => c.Emprunts.Where(e => e.Ouvrage.Type == getComboBoxOuvrageType()))
                .ThenInclude(e => e.Ouvrage)
                .AsNoTracking()
                .FirstOrDefault(c => c.CIN == textBoxNIC.Text);

            if (client is null)
            {
                MessageBox.Show("Client not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNIC.Focus();
                return;
            }

            labelFullName.Text = $"{client.Nom} {client.Prenom}";

            foreach (Emprunt emprunt in client.Emprunts)
            {
                ListViewItem listViewItem = new ListViewItem(emprunt.Id.ToString());
                listViewItem.SubItems.Add(emprunt.Ouvrage.Titre);
                listViewItem.SubItems.Add(emprunt.DateDebut.ToShortDateString());
                listViewItem.SubItems.Add(emprunt.DateFin.ToShortDateString());
                listViewItem.SubItems.Add((emprunt.Retourne) ? "yes" : "no");
                listViewClientEmprunts.Items.Add(listViewItem);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxNIC.Text.Length == 0)
            {
                MessageBox.Show("Please fill NIC field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNIC.Focus();
                return;
            }
            filllistViewClientEmprunts();
        }

        private void textBoxNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8) // Backspace
            {
                labelFullName.Text = "";
                labelOuvrageDetails.Text = "";
                listViewClientEmprunts.Items.Clear();
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (labelFullName.Text.Length == 0)
            {
                MessageBox.Show("Search for a client first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNIC.Focus();
                return;
            }
            if (listViewOuvrages.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an ouvrage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerFrom.Value >= dateTimePickerTo.Value)
            {
                MessageBox.Show("From date should be lower than to date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Client client = libraryContext.Clients.AsNoTracking().First(c => c.CIN == textBoxNIC.Text);

            // if the client did not retrun the borrowed ouvrages he cannot borrow
            if (libraryContext.Emprunts.Count(e => e.Client == client && !e.Retourne) > 0)
            {
                MessageBox.Show("Client cannot borrow because he didn't return his borrows!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ouvrage ouvrage = libraryContext.Ouvrages.Find(int.Parse(listViewOuvrages.SelectedItems[0].SubItems[0].Text));

            // If the ouvrage is not available he cannot borrow
            if (ouvrage.Disponible < 1)
            {
                MessageBox.Show($"There is no {comboBoxOuvrageType.Text} available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ouvrage.Disponible--;
            libraryContext.SaveChanges();

            libraryContext.Emprunts.Add(new Emprunt
            {
                DateDebut = dateTimePickerFrom.Value,
                DateFin = dateTimePickerTo.Value,
                Client = client,
                Ouvrage = ouvrage
            });
            libraryContext.SaveChanges();

            comboBoxOuvrageType_SelectedIndexChanged(sender, new EventArgs());
            filllistViewClientEmprunts();
        }

        private void FormEmpruntManagement_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.MinDate = DateTime.Now;
            dateTimePickerTo.MinDate = DateTime.Now.AddDays(1);
            labelFullName.Text = "";
            labelOuvrageDetails.Text = "";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (listViewClientEmprunts.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a client borrow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Emprunt? emprunt = libraryContext.Emprunts
                .Include(e => e.Ouvrage)
                .FirstOrDefault(e => e.Id == int.Parse(listViewClientEmprunts.SelectedItems[0].SubItems[0].Text) && !e.Retourne);

            if (emprunt is null)
            {
                MessageBox.Show("Selected borrow already returned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            emprunt.Retourne = true;
            emprunt.Ouvrage.Disponible++;

            libraryContext.SaveChanges();

            comboBoxOuvrageType_SelectedIndexChanged(sender, new EventArgs());
            filllistViewClientEmprunts();
        }

        private void listViewClientEmprunts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClientEmprunts.SelectedIndices.Count > 0)
            {
                using LibraryContext libraryContext = new LibraryContext();

                Ouvrage ouvrage = libraryContext.Emprunts
                    .Include(e => e.Ouvrage)
                    .AsNoTracking()
                    .First(e => e.Id == int.Parse(listViewClientEmprunts.SelectedItems[0].SubItems[0].Text)).Ouvrage;

                labelOuvrageDetails.Text = $"{ouvrage.Id} / {ouvrage.Auteur} / {ouvrage.Titre}";
            }
        }
    }
}
