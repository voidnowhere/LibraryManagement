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
    public partial class FormClientManagement : Form
    {
        private LibraryContext _libraryContext;
        public FormClientManagement()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void fillListViewClients()
        {
            listViewClients.Items.Clear();
            foreach (Client client in _libraryContext.Clients.ToList())
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

            _libraryContext.Clients.Add(new Client
            {
                Nom = textBoxFirstName.Text,
                Prenom = textBoxLastName.Text,
                CIN = textBoxCIN.Text,
            });
            _libraryContext.SaveChanges();

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxCIN.Clear();
            fillListViewClients();

        }



        private void buttonModifier_Click(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_libraryContext.Clients.Find();
            _libraryContext.Clients.Count(c => c.CIN == textBoxCIN.Text && c.Id != int.Parse(listViewClients.SelectedItems[0].SubItems[0].ToString()));
        }


        private void FormClientManagement_Load(object sender, EventArgs e)
        {
            fillListViewClients();
        }

        
    }
}
