using LibraryManagment.Models;
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
    public partial class FormOuvrageManagement : Form
    {
        private LibraryContext _libraryContext;

        public FormOuvrageManagement()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
        }

        private void clearAllTextBoxs()
        {
            textBoxAuthor.Clear();
            textBoxTitle.Clear();
            textBoxQuantity.Clear();
            textBoxPeriodicity.Clear();
            textBoxEditor.Clear();
        }

        private bool checkThatAllFieldsAreFilled()
        {
            if (textBoxAuthor.Text.Length == 0 || textBoxTitle.Text.Length == 0
                || textBoxQuantity.Text.Length == 0 || comboBoxOuvrageType.SelectedIndex == -1
                || (comboBoxOuvrageType.SelectedIndex == 0 && textBoxPeriodicity.Text.Length == 0)
                || (comboBoxOuvrageType.SelectedIndex == 2 && textBoxEditor.Text.Length == 0))
            {
                MessageBox.Show("Please fill all fealds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!checkThatAllFieldsAreFilled())
            {
                return;
            }
            if(comboBoxOuvrageType.SelectedIndex == 0) // Periodic
            {
                _libraryContext.Periodiques.Add(new Periodique
                {
                    Auteur = textBoxAuthor.Text,
                    Titre = textBoxTitle.Text,
                    Quantite = int.Parse(textBoxQuantity.Text),
                    Disponible = int.Parse(textBoxQuantity.Text),
                    Periodicite = int.Parse(textBoxPeriodicity.Text)
                });
                _libraryContext.SaveChanges();
            }
            else if(comboBoxOuvrageType.SelectedIndex == 1) // CD
            {
                _libraryContext.CDs.Add(new CD
                {
                    Auteur = textBoxAuthor.Text,
                    Titre = textBoxTitle.Text,
                    Quantite = int.Parse(textBoxQuantity.Text),
                    Disponible = int.Parse(textBoxQuantity.Text)
                });
                _libraryContext.SaveChanges();
            }
            else if(comboBoxOuvrageType.SelectedIndex == 2) // Book
            {
                _libraryContext.Livres.Add(new Livre
                {
                    Auteur = textBoxAuthor.Text,
                    Titre = textBoxTitle.Text,
                    Quantite = int.Parse(textBoxQuantity.Text),
                    Disponible = int.Parse(textBoxQuantity.Text),
                    Editeur = textBoxEditor.Text
                });
                _libraryContext.SaveChanges();
            }
            clearAllTextBoxs();
            comboBoxOuvrageType_SelectedIndexChanged(sender, e);
        }

        private void comboBoxOuvrageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllTextBoxs();
            listViewOuvrages.Items.Clear();
            if (comboBoxOuvrageType.SelectedIndex == 0) // Periodic
            {
                textBoxPeriodicity.Enabled = true;
                textBoxEditor.Enabled = false;
                foreach (Periodique periodique in _libraryContext.Periodiques.ToList())
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
                textBoxPeriodicity.Enabled = false;
                textBoxEditor.Enabled = false;
                foreach (CD cd in _libraryContext.CDs.ToList())
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
                textBoxPeriodicity.Enabled = false;
                textBoxEditor.Enabled = true;
                foreach (Livre livre in _libraryContext.Livres.ToList())
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
        }

        private void listViewOuvrages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewOuvrages.SelectedIndices.Count > 0)
            {
                textBoxAuthor.Text = listViewOuvrages.SelectedItems[0].SubItems[1].Text;
                textBoxTitle.Text = listViewOuvrages.SelectedItems[0].SubItems[2].Text;
                textBoxQuantity.Text = listViewOuvrages.SelectedItems[0].SubItems[3].Text;
                if (comboBoxOuvrageType.SelectedIndex == 0) // Periodic
                {
                    textBoxPeriodicity.Text = listViewOuvrages.SelectedItems[0].SubItems[5].Text;
                }
                else if(comboBoxOuvrageType.SelectedIndex == 2) // Book
                {
                    textBoxEditor.Text = listViewOuvrages.SelectedItems[0].SubItems[6].Text;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!checkThatAllFieldsAreFilled())
            {
                return;
            }
            if (listViewOuvrages.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int oldQuantity = int.Parse(listViewOuvrages.SelectedItems[0].SubItems[3].Text);
            int newQuantity = int.Parse(textBoxQuantity.Text);
            if (newQuantity < oldQuantity)
            {
                MessageBox.Show("New quantity can't be lower than the old quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantity.Focus();
                return;
            }

            int ouvrageId = int.Parse(listViewOuvrages.SelectedItems[0].SubItems[0].Text);
            if (comboBoxOuvrageType.SelectedIndex == 0) // Periodic
            {
                Periodique periodique = _libraryContext.Periodiques.Find(ouvrageId);
                periodique.Auteur = textBoxAuthor.Text;
                periodique.Titre = textBoxTitle.Text;
                if (newQuantity > oldQuantity)
                {
                    periodique.Quantite = newQuantity;
                    periodique.Disponible += newQuantity - oldQuantity;
                }
                periodique.Periodicite = int.Parse(textBoxPeriodicity.Text);
                _libraryContext.SaveChanges();
            }
            else if (comboBoxOuvrageType.SelectedIndex == 1) // CD
            {
                CD cd = _libraryContext.CDs.Find(ouvrageId);
                cd.Auteur = textBoxAuthor.Text;
                cd.Titre = textBoxTitle.Text;
                if (newQuantity > oldQuantity)
                {
                    cd.Quantite = newQuantity;
                    cd.Disponible += newQuantity - oldQuantity;
                }
                _libraryContext.SaveChanges();
            }
            else if (comboBoxOuvrageType.SelectedIndex == 2) // Book
            {
                Livre livre = _libraryContext.Livres.Find(ouvrageId);
                livre.Auteur = textBoxAuthor.Text;
                livre.Titre = textBoxTitle.Text;
                if (newQuantity > oldQuantity)
                {
                    livre.Quantite = newQuantity;
                    livre.Disponible += newQuantity - oldQuantity;
                }
                livre.Editeur = textBoxEditor.Text;
                _libraryContext.SaveChanges();
            }
            comboBoxOuvrageType_SelectedIndexChanged(sender, e);
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPeriodicity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
