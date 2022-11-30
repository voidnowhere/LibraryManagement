using LibraryManagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormClientManagement : Form
    {
        public FormClientManagement()
        {
            InitializeComponent();
        }

        private void fillListViewClients()
        {
            using LibraryContext libraryContext = new LibraryContext();

            listViewClients.Items.Clear();
            foreach (Client client in libraryContext.Clients.AsNoTracking().ToList())
            {
                ListViewItem listViewItem = new ListViewItem(client.Id.ToString());
                listViewItem.SubItems.Add(client.Nom);
                listViewItem.SubItems.Add(client.Prenom);
                listViewItem.SubItems.Add(client.CIN);
                listViewClients.Items.Add(listViewItem);
            };
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Length == 0 || textBoxLastName.Text.Length == 0 || textBoxCIN.Text.Length == 0)
            {
                MessageBox.Show("Tous les champs sont obligatoire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("invalid format in First name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("invalid format in Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxCIN.Text, @"^[a-zA-Z]{2}\d{6}$") == false)
            {
                MessageBox.Show("please put a valid CIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            if (libraryContext.Clients.AsNoTracking().Count( c => c.CIN == textBoxCIN.Text ) > 0)
            {
                MessageBox.Show("this CIN already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            libraryContext.Clients.Add(new Client
            {
                Nom = textBoxLastName.Text,
                Prenom = textBoxFirstName.Text,
                CIN = textBoxCIN.Text,
            });
            libraryContext.SaveChanges();
            
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxCIN.Clear();
            fillListViewClients();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("invalid format in First name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("invalid format in Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxCIN.Text, @"^[a-zA-Z]{2}\d{6}$") == false)
            {
                MessageBox.Show("please put a valid CIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            if (libraryContext.Clients.AsNoTracking().Count(c => c.CIN == textBoxCIN.Text && c.Id != int.Parse(listViewClients.SelectedItems[0].SubItems[0].Text)) == 1)
            {
                MessageBox.Show("this CIN already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = libraryContext.Clients.Find(int.Parse(listViewClients.SelectedItems[0].SubItems[0].Text));
            client.Prenom = textBoxFirstName.Text;
            client.Nom= textBoxLastName.Text;
            client.CIN = textBoxCIN.Text;

            libraryContext.SaveChanges(); 
            
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxCIN.Clear();
            fillListViewClients();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewClients.SelectedItems[0];
                textBoxLastName.Text = listView.SubItems[1].Text;
                textBoxFirstName.Text = listView.SubItems[2].Text;
                textBoxCIN.Text = listView.SubItems[3].Text;
            }
        }

        private void FormClientManagement_Load(object sender, EventArgs e)
        {
            fillListViewClients();
        }
    }
}
