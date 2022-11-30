using LibraryManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormResetPassword : Form
    {
        private int responsableId;
        
        public FormResetPassword(int responsableId)
        {
            InitializeComponent();
            this.responsableId = responsableId;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentPassword.Text.Length == 0 || textBoxNewPassword.Text.Length == 0 
                || textBoxConfirmPassword.Text.Length == 0)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Password confimation doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Responsable responsable = libraryContext.Responsables.Find(responsableId);

            if (responsable.Password != textBoxCurrentPassword.Text)
            {
                MessageBox.Show("Current password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            responsable.Password = textBoxConfirmPassword.Text;
            libraryContext.SaveChanges();

            MessageBox.Show("Password has been changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
