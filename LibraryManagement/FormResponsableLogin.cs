using LibraryManagment.Models;
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
    public partial class FormResponsableLogin : Form
    {
        private LibraryContext _libraryContext;
        public FormResponsableLogin()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
        }

        private void FormResponsableLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length < 0 || textBoxMDP.Text.Length < 0)
            {
                MessageBox.Show("Please check your login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxLogin.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Invalid format for login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_libraryContext.Clients.Count(c => c.Id == int.Parse(textBoxLogin.Text)) == 1)
            {
                MessageBox.Show("Connecté", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLogin.Clear();
                textBoxMDP.Clear();

            }
            else
            {
                MessageBox.Show("Login not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
