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
        public FormResponsableLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length == 0 || textBoxMDP.Text.Length == 0)
            {
                MessageBox.Show("Please check your login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(textBoxLogin.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Invalid format for login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Responsable? responsable = libraryContext.Responsables.FirstOrDefault(r => r.Id == int.Parse(textBoxLogin.Text) && r.Password == textBoxMDP.Text);

            if (responsable is null)
            {
                MessageBox.Show("Verify your login and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxLogin.Clear();
            textBoxMDP.Clear();

            Hide();
            new FormMenu(responsable.Id, responsable.Admin, this).Show();
        }
    }
}
