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
    public partial class FormMenu : Form
    {
        private int responsableId;
        private bool admin;
        private FormResponsableLogin formResponsableLogin;

        public FormMenu(int reponsableId, bool admin, FormResponsableLogin formResponsableLogin)
        {
            InitializeComponent();
            this.responsableId = reponsableId;
            this.admin = admin;
            this.formResponsableLogin = formResponsableLogin;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            responsibleManagementToolStripMenuItem.Enabled = admin;
        }

        private void clientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = false;
            ouvrageManagementToolStripMenuItem.Enabled = true;
            borrowManagementToolStripMenuItem.Enabled = true;
            responsibleManagementToolStripMenuItem.Enabled = admin;
            resetPasswordToolStripMenuItem.Enabled = true;
            FormClientManagement clientManagement = new FormClientManagement();
            clientManagement.MdiParent = this;
            clientManagement.Dock = DockStyle.Fill;
            clientManagement.Show();
        }

        private void ouvrageManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = true;
            ouvrageManagementToolStripMenuItem.Enabled = false;
            borrowManagementToolStripMenuItem.Enabled = true;
            responsibleManagementToolStripMenuItem.Enabled = admin;
            resetPasswordToolStripMenuItem.Enabled = true;
            FormOuvrageManagement ouvrageManagement = new FormOuvrageManagement();
            ouvrageManagement.MdiParent = this;
            ouvrageManagement.Dock = DockStyle.Fill;
            ouvrageManagement.Show();
        }

        private void borrowManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = true;
            ouvrageManagementToolStripMenuItem.Enabled = true;
            borrowManagementToolStripMenuItem.Enabled = false;
            responsibleManagementToolStripMenuItem.Enabled = admin;
            resetPasswordToolStripMenuItem.Enabled = true;
            FormEmpruntManagement empruntManagement = new FormEmpruntManagement();
            empruntManagement.MdiParent = this;
            empruntManagement.Dock = DockStyle.Fill;
            empruntManagement.Show();
        }

        private void responsibleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = true;
            ouvrageManagementToolStripMenuItem.Enabled = true;
            borrowManagementToolStripMenuItem.Enabled = true;
            responsibleManagementToolStripMenuItem.Enabled = false;
            resetPasswordToolStripMenuItem.Enabled = true;
            FormResponsableManagment responsableManagment = new FormResponsableManagment();
            responsableManagment.MdiParent = this;
            responsableManagment.Dock = DockStyle.Fill;
            responsableManagment.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = true;
            ouvrageManagementToolStripMenuItem.Enabled = true;
            borrowManagementToolStripMenuItem.Enabled = true;
            responsibleManagementToolStripMenuItem.Enabled = admin;
            new FormResetPassword(responsableId).ShowDialog();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            formResponsableLogin.Show();
        }
    }
}
