namespace LibraryManagement
{
    partial class FormOuvrageManagement
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
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOuvrageType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeriodicity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewOuvrages = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAvailable = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPeriodicity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEditor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(71, 12);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 23);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(71, 41);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(71, 70);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // comboBoxOuvrageType
            // 
            this.comboBoxOuvrageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOuvrageType.FormattingEnabled = true;
            this.comboBoxOuvrageType.Items.AddRange(new object[] {
            "Periodic",
            "CD",
            "Book"});
            this.comboBoxOuvrageType.Location = new System.Drawing.Point(258, 12);
            this.comboBoxOuvrageType.Name = "comboBoxOuvrageType";
            this.comboBoxOuvrageType.Size = new System.Drawing.Size(100, 23);
            this.comboBoxOuvrageType.TabIndex = 6;
            this.comboBoxOuvrageType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOuvrageType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // textBoxPeriodicity
            // 
            this.textBoxPeriodicity.Enabled = false;
            this.textBoxPeriodicity.Location = new System.Drawing.Point(258, 41);
            this.textBoxPeriodicity.Name = "textBoxPeriodicity";
            this.textBoxPeriodicity.Size = new System.Drawing.Size(100, 23);
            this.textBoxPeriodicity.TabIndex = 8;
            this.textBoxPeriodicity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeriodicity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Periodicity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Editor";
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Enabled = false;
            this.textBoxEditor.Location = new System.Drawing.Point(258, 70);
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(100, 23);
            this.textBoxEditor.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(431, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(431, 65);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listViewOuvrages
            // 
            this.listViewOuvrages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderAuthor,
            this.columnHeaderTitle,
            this.columnHeaderQuantity,
            this.columnHeaderAvailable,
            this.columnHeaderPeriodicity,
            this.columnHeaderEditor});
            this.listViewOuvrages.FullRowSelect = true;
            this.listViewOuvrages.Location = new System.Drawing.Point(12, 112);
            this.listViewOuvrages.MultiSelect = false;
            this.listViewOuvrages.Name = "listViewOuvrages";
            this.listViewOuvrages.Size = new System.Drawing.Size(494, 237);
            this.listViewOuvrages.TabIndex = 14;
            this.listViewOuvrages.UseCompatibleStateImageBehavior = false;
            this.listViewOuvrages.View = System.Windows.Forms.View.Details;
            this.listViewOuvrages.SelectedIndexChanged += new System.EventHandler(this.listViewOuvrages_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
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
            // FormOuvrageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.listViewOuvrages);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPeriodicity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOuvrageType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label1);
            this.Name = "FormOuvrageManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOuvrageManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private Label label2;
        private TextBox textBoxQuantity;
        private Label label3;
        private ComboBox comboBoxOuvrageType;
        private Label label4;
        private TextBox textBoxPeriodicity;
        private Label label5;
        private Label label6;
        private TextBox textBoxEditor;
        private Button buttonAdd;
        private Button buttonEdit;
        private ListView listViewOuvrages;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderAuthor;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderQuantity;
        private ColumnHeader columnHeaderPeriodicity;
        private ColumnHeader columnHeaderEditor;
        private ColumnHeader columnHeaderAvailable;
    }
}