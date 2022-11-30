namespace LibraryManagement
{
    partial class FormEmpruntManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxOuvrageType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewClientEmprunts = new System.Windows.Forms.ListView();
            this.columnHeaderEmpruntId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOuvrageTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFromDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderToDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderReturned = new System.Windows.Forms.ColumnHeader();
            this.listViewOuvrages = new System.Windows.Forms.ListView();
            this.columnHeaderOuvrageId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAvailable = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPeriodicity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEditor = new System.Windows.Forms.ColumnHeader();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelOuvrageDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIC";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(53, 12);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(100, 23);
            this.textBoxNIC.TabIndex = 1;
            this.textBoxNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNIC_KeyPress);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(163, 15);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(61, 15);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(665, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxOuvrageType
            // 
            this.comboBoxOuvrageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOuvrageType.FormattingEnabled = true;
            this.comboBoxOuvrageType.Items.AddRange(new object[] {
            "Periodic",
            "CD",
            "Book"});
            this.comboBoxOuvrageType.Location = new System.Drawing.Point(409, 12);
            this.comboBoxOuvrageType.Name = "comboBoxOuvrageType";
            this.comboBoxOuvrageType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOuvrageType.TabIndex = 4;
            this.comboBoxOuvrageType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOuvrageType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ouvrage Type";
            // 
            // listViewClientEmprunts
            // 
            this.listViewClientEmprunts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmpruntId,
            this.columnHeaderOuvrageTitle,
            this.columnHeaderFromDate,
            this.columnHeaderToDate,
            this.columnHeaderReturned});
            this.listViewClientEmprunts.FullRowSelect = true;
            this.listViewClientEmprunts.Location = new System.Drawing.Point(12, 87);
            this.listViewClientEmprunts.MultiSelect = false;
            this.listViewClientEmprunts.Name = "listViewClientEmprunts";
            this.listViewClientEmprunts.Size = new System.Drawing.Size(306, 304);
            this.listViewClientEmprunts.TabIndex = 7;
            this.listViewClientEmprunts.UseCompatibleStateImageBehavior = false;
            this.listViewClientEmprunts.View = System.Windows.Forms.View.Details;
            this.listViewClientEmprunts.SelectedIndexChanged += new System.EventHandler(this.listViewClientEmprunts_SelectedIndexChanged);
            // 
            // columnHeaderEmpruntId
            // 
            this.columnHeaderEmpruntId.Text = "Id";
            this.columnHeaderEmpruntId.Width = 40;
            // 
            // columnHeaderOuvrageTitle
            // 
            this.columnHeaderOuvrageTitle.Text = "Title";
            // 
            // columnHeaderFromDate
            // 
            this.columnHeaderFromDate.Text = "From";
            this.columnHeaderFromDate.Width = 70;
            // 
            // columnHeaderToDate
            // 
            this.columnHeaderToDate.Text = "To";
            this.columnHeaderToDate.Width = 70;
            // 
            // columnHeaderReturned
            // 
            this.columnHeaderReturned.Text = "Returned";
            // 
            // listViewOuvrages
            // 
            this.listViewOuvrages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOuvrageId,
            this.columnHeaderAuthor,
            this.columnHeaderTitle,
            this.columnHeaderQuantity,
            this.columnHeaderAvailable,
            this.columnHeaderPeriodicity,
            this.columnHeaderEditor});
            this.listViewOuvrages.FullRowSelect = true;
            this.listViewOuvrages.Location = new System.Drawing.Point(324, 87);
            this.listViewOuvrages.MultiSelect = false;
            this.listViewOuvrages.Name = "listViewOuvrages";
            this.listViewOuvrages.Size = new System.Drawing.Size(416, 304);
            this.listViewOuvrages.TabIndex = 15;
            this.listViewOuvrages.UseCompatibleStateImageBehavior = false;
            this.listViewOuvrages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOuvrageId
            // 
            this.columnHeaderOuvrageId.Text = "Id";
            this.columnHeaderOuvrageId.Width = 40;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            // 
            // columnHeaderAvailable
            // 
            this.columnHeaderAvailable.Text = "Available";
            // 
            // columnHeaderPeriodicity
            // 
            this.columnHeaderPeriodicity.Text = "Periodicity";
            this.columnHeaderPeriodicity.Width = 70;
            // 
            // columnHeaderEditor
            // 
            this.columnHeaderEditor.Text = "Editor";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(365, 44);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(79, 23);
            this.dateTimePickerFrom.TabIndex = 17;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(500, 45);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(79, 23);
            this.dateTimePickerTo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "To";
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(665, 44);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrow.TabIndex = 21;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(243, 44);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 22;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelOuvrageDetails
            // 
            this.labelOuvrageDetails.AutoSize = true;
            this.labelOuvrageDetails.Location = new System.Drawing.Point(12, 48);
            this.labelOuvrageDetails.Name = "labelOuvrageDetails";
            this.labelOuvrageDetails.Size = new System.Drawing.Size(90, 15);
            this.labelOuvrageDetails.TabIndex = 23;
            this.labelOuvrageDetails.Text = "Ouvrage Details";
            // 
            // FormEmpruntManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 401);
            this.Controls.Add(this.labelOuvrageDetails);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.listViewOuvrages);
            this.Controls.Add(this.listViewClientEmprunts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOuvrageType);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpruntManagement";
            this.Text = "FormEmpruntManagement";
            this.Load += new System.EventHandler(this.FormEmpruntManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNIC;
        private Label labelFullName;
        private Button buttonSearch;
        private ComboBox comboBoxOuvrageType;
        private Label label3;
        private ListView listViewClientEmprunts;
        private ListView listViewOuvrages;
        private ColumnHeader columnHeaderOuvrageId;
        private ColumnHeader columnHeaderAuthor;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderQuantity;
        private ColumnHeader columnHeaderAvailable;
        private ColumnHeader columnHeaderPeriodicity;
        private ColumnHeader columnHeaderEditor;
        private ColumnHeader columnHeaderEmpruntId;
        private ColumnHeader columnHeaderFromDate;
        private ColumnHeader columnHeaderToDate;
        private ColumnHeader columnHeaderReturned;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label4;
        private Label label5;
        private Button buttonBorrow;
        private ColumnHeader columnHeaderOuvrageTitle;
        private Button buttonReturn;
        private Label labelOuvrageDetails;
    }
}