﻿using LibraryManagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormResponsableManagment : Form
    {
        public FormResponsableManagment()
        {
            InitializeComponent();
        }

        private void FormResponsableManagment_Load(object sender, EventArgs e)
        {
            listViewResponsables.Items.Clear();

            using LibraryContext libraryContext = new LibraryContext();

            foreach (Responsable responsable in libraryContext.Responsables.AsNoTracking().ToList())
            {
                ListViewItem listViewItem = new ListViewItem(responsable.Id.ToString());
                listViewItem.SubItems.Add(responsable.Nom);
                listViewItem.SubItems.Add(responsable.Prenom);
                listViewResponsables.Items.Add(listViewItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$") == false) {

                MessageBox.Show("Invalid format in Nom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Focus();
                return;
            }
            if (Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Invalid format in Prenom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Focus();
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            libraryContext.Responsables.Add(new Responsable
            {
                Nom = textBoxLastName.Text,
                Prenom = textBoxFirstName.Text, 
                Password = "123456"
            });

            libraryContext.SaveChanges();

            //list view
            listViewResponsables.Items.Clear();
            foreach (Responsable responsable in libraryContext.Responsables.AsNoTracking().ToList())
            {
                ListViewItem listViewItem = new ListViewItem(responsable.Id.ToString());
                listViewItem.SubItems.Add(responsable.Nom);
                listViewItem.SubItems.Add(responsable.Prenom);
                listViewResponsables.Items.Add(listViewItem);
            }

            textBoxLastName.Clear();
            textBoxFirstName.Clear();
        }

        private void listViewResponsables_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewResponsables.Items.Clear();

            using LibraryContext libraryContext = new LibraryContext();

            foreach (Responsable responsable in libraryContext.Responsables.AsNoTracking().ToList())
            {
                ListViewItem listViewItem = new ListViewItem(responsable.Id.ToString());
                listViewItem.SubItems.Add(responsable.Nom);
                listViewItem.SubItems.Add(responsable.Prenom);
                listViewResponsables.Items.Add(listViewItem);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

            if (listViewResponsables.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Invalid format in Nom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Focus();
                return;
            }

            if (Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Invalid format in Prenom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Focus();
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Responsable responsable = libraryContext.Responsables.Find(int.Parse(listViewResponsables.SelectedItems[0].SubItems[0].Text));

            responsable.Nom = textBoxLastName.Text;
            responsable.Prenom = textBoxFirstName.Text;
            libraryContext.SaveChanges();

            listViewResponsables.Items.Clear();
            foreach (Responsable responsablee in libraryContext.Responsables.AsNoTracking().ToList())
            {
                ListViewItem listViewItem = new ListViewItem(responsablee.Id.ToString());
                listViewItem.SubItems.Add(responsablee.Nom);
                listViewItem.SubItems.Add(responsablee.Prenom);
                listViewResponsables.Items.Add(listViewItem);
            }

            textBoxLastName.Clear();
            textBoxFirstName.Clear();
        }

        private void listViewResponsables_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewResponsables.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = listViewResponsables.SelectedItems[0];
            textBoxLastName.Text = item.SubItems[1].Text;
            textBoxFirstName.Text = item.SubItems[2].Text;
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            if (listViewResponsables.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using LibraryContext libraryContext = new LibraryContext();

            Responsable responsable = libraryContext.Responsables.Find(int.Parse(listViewResponsables.SelectedItems[0].SubItems[0].Text));
            responsable.Password = "123456";
            libraryContext.SaveChanges();

            MessageBox.Show("Password has been reseted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



