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
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientManagementToolStripMenuItem.Enabled = false;
            ouvrageManagementToolStripMenuItem.Enabled = true;
            borrowManagementToolStripMenuItem.Enabled = true;
            responsibleManagementToolStripMenuItem.Enabled = true;
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
            responsibleManagementToolStripMenuItem.Enabled = true;
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
            responsibleManagementToolStripMenuItem.Enabled = true;
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
            responsibleManagementToolStripMenuItem.Enabled = true;
            resetPasswordToolStripMenuItem.Enabled = false;
        }
    }
}
