using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using SukranLibrary.Components;
namespace SukranLibrary.Controls
{
    partial class AuthorCrudControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Table = new TableLayoutPanel();
            this.Author_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Name = new DataGridViewTextBoxColumn();
            this.Surname = new DataGridViewTextBoxColumn();
            this.DateOfBirth = new DataGridViewTextBoxColumn();
            this.Nationality = new DataGridViewTextBoxColumn();
            this.Manager_Table = new TableLayoutPanel();
            this.Name_Lbl = new Label();
            this.Name_Txt = new Custom_TextBox();
            this.Surname_Lbl = new Label();
            this.Surname_Txt = new Custom_TextBox();
            this.DateOfBirth_Lbl = new Label();
            this.DateOfBirth_Dtp = new Custom_DateTimePicker();
            this.Nationality_Lbl = new Label();
            this.Nationality_Txt = new Custom_TextBox();
            this.Save_Btn = new Button();
            this.Delete_Btn = new Button();
            this.Cancel_Btn = new Button();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.Author_Dgv)).BeginInit();
            this.Manager_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Author_Dgv, 0, 0);
            this.Main_Table.Controls.Add(this.Manager_Table, 1, 0);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Author_Dgv
            // 
            this.Author_Dgv.Dock = DockStyle.Fill;
            this.Author_Dgv.Name = "Author_Dgv";
            this.Author_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Surname,
            this.DateOfBirth,
            this.Nationality});
            this.Author_Dgv.DoubleClick += new System.EventHandler(this.Author_Dgv_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "İSİM";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "SOYADI";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DOGUM TARİHİ";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "MİLLİYET";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            //
            //Manager_Table
            //
            this.Manager_Table.BackColor = Color.Transparent;
            this.Manager_Table.ColumnCount = 4;
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.RowCount = 6;
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Manager_Table.Controls.Add(this.Name_Lbl, 0, 0);
            this.Manager_Table.Controls.Add(this.Name_Txt, 2, 0);
            this.Manager_Table.SetColumnSpan(this.Name_Txt, 2);
            this.Manager_Table.Controls.Add(this.Surname_Lbl, 0, 1);
            this.Manager_Table.Controls.Add(this.Surname_Txt, 2, 1);
            this.Manager_Table.SetColumnSpan(this.Surname_Txt, 2);
            this.Manager_Table.Controls.Add(this.DateOfBirth_Lbl, 0, 2);
            this.Manager_Table.Controls.Add(this.DateOfBirth_Dtp, 2, 2);
            this.Manager_Table.SetColumnSpan(this.DateOfBirth_Dtp, 2);
            this.Manager_Table.Controls.Add(this.Nationality_Lbl, 0, 3);
            this.Manager_Table.Controls.Add(this.Nationality_Txt, 2, 3);
            this.Manager_Table.SetColumnSpan(this.Nationality_Txt, 2);
            this.Manager_Table.Controls.Add(this.Save_Btn, 0, 4);
            this.Manager_Table.Controls.Add(this.Delete_Btn, 1, 4);
            this.Manager_Table.SetColumnSpan(this.Delete_Btn, 2);
            this.Manager_Table.Controls.Add(this.Cancel_Btn, 3, 4);
            this.Manager_Table.Dock = DockStyle.Fill;
            this.Manager_Table.Name = "Manager_Table";
            this.Manager_Table.TabIndex = 0;
            // 
            // Name_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Name_Lbl, 2);
            this.Name_Lbl.Dock = DockStyle.Fill;
            this.Name_Lbl.BackColor = Color.Transparent;
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Text = "İsim:";
            this.Name_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Name_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Name_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Name_Txt
            // 
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Dock = DockStyle.Fill;
            this.Name_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Name_Txt.AutoSize = true;
            this.Name_Txt.TextAlign = HorizontalAlignment.Left;
            this.Name_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Name_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Name_Txt.UnderlinedStyle = true;
            this.Name_Txt.TabIndex = 0;
            this.Name_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Name_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Surname_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Surname_Lbl, 2);
            this.Surname_Lbl.Dock = DockStyle.Fill;
            this.Surname_Lbl.BackColor = Color.Transparent;
            this.Surname_Lbl.Name = "Surname_Lbl";
            this.Surname_Lbl.Text = "Soyad:";
            this.Surname_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Surname_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Surname_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Surname_Txt
            // 
            this.Surname_Txt.Name = "Surname_Txt";
            this.Surname_Txt.Dock = DockStyle.Fill;
            this.Surname_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Surname_Txt.AutoSize = true;
            this.Surname_Txt.TextAlign = HorizontalAlignment.Left;
            this.Surname_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Surname_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Surname_Txt.UnderlinedStyle = true;
            this.Surname_Txt.TabIndex = 0;
            this.Surname_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Surname_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // DateOfBirth_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.DateOfBirth_Lbl, 2);
            this.DateOfBirth_Lbl.Dock = DockStyle.Fill;
            this.DateOfBirth_Lbl.BackColor = Color.Transparent;
            this.DateOfBirth_Lbl.Name = "DateOfBirth_Lbl";
            this.DateOfBirth_Lbl.Text = "Doğum Tarihi:";
            this.DateOfBirth_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.DateOfBirth_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.DateOfBirth_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // DateOfBirth_Dtp
            // 
            this.DateOfBirth_Dtp.Name = "DateOfBirth_Dtp";
            this.DateOfBirth_Dtp.Dock = DockStyle.Fill;
            this.DateOfBirth_Dtp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.DateOfBirth_Dtp.AutoSize = true;
            this.DateOfBirth_Dtp.BorderColor = Color.FromArgb(202, 43, 77);
            this.DateOfBirth_Dtp.BorderSize = 1;
            this.DateOfBirth_Dtp.TabIndex = 0;
            this.DateOfBirth_Dtp.BackColor = Color.FromArgb(64, 69, 76);
            this.DateOfBirth_Dtp.TextColor = Color.FromArgb(192, 192, 192);
            this.DateOfBirth_Dtp.SkinColor = Color.FromArgb(64, 69, 76);
            this.DateOfBirth_Dtp.CustomFormat = "dd.MM.yyyy";
            this.DateOfBirth_Dtp.Format = DateTimePickerFormat.Custom;
            // 
            // Nationality_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Nationality_Lbl, 2);
            this.Nationality_Lbl.Dock = DockStyle.Fill;
            this.Nationality_Lbl.BackColor = Color.Transparent;
            this.Nationality_Lbl.Name = "Nationality_Lbl";
            this.Nationality_Lbl.Text = "Milliyet:";
            this.Nationality_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Nationality_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Nationality_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Nationality_Txt
            // 
            this.Nationality_Txt.Name = "Nationality_Txt";
            this.Nationality_Txt.Dock = DockStyle.Fill;
            this.Nationality_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Nationality_Txt.AutoSize = true;
            this.Nationality_Txt.TextAlign = HorizontalAlignment.Left;
            this.Nationality_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Nationality_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Nationality_Txt.UnderlinedStyle = true;
            this.Nationality_Txt.TabIndex = 0;
            this.Nationality_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Nationality_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Save_Btn.FlatAppearance.BorderSize = 1;
            this.Save_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Save_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Save_Btn.Image = Properties.Resources.Save_Image;
            this.Save_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new Point(0, 512);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Save_Btn.Size = new Size(229, 45);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "KAYDET";
            this.Save_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Save_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Delete_Btn.FlatAppearance.BorderSize = 1;
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Delete_Btn.Image = Properties.Resources.Delete_Image;
            this.Delete_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Delete_Btn.Location = new Point(0, 512);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Delete_Btn.Size = new Size(229, 45);
            this.Delete_Btn.TabIndex = 5;
            this.Delete_Btn.Text = "SİL";
            this.Delete_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Delete_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Cancel_Btn.FlatAppearance.BorderSize = 1;
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Cancel_Btn.Image = Properties.Resources.Cancel_Image;
            this.Cancel_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            this.Cancel_Btn.Location = new Point(0, 512);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Cancel_Btn.Size = new Size(229, 45);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "İPTAL";
            this.Cancel_Btn.TextAlign = ContentAlignment.MiddleLeft;
            this.Cancel_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            //AuthorCrudControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += AuthorCrudControl_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Manager_Table.ResumeLayout(false);
            this.Manager_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Custom_DataGridView Author_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Nationality;
        private TableLayoutPanel Manager_Table;
        private Label Name_Lbl;
        private Custom_TextBox Name_Txt;
        private Label Surname_Lbl;
        private Custom_TextBox Surname_Txt;
        private Label DateOfBirth_Lbl;
        private Custom_DateTimePicker DateOfBirth_Dtp;
        private Label Nationality_Lbl;
        private Custom_TextBox Nationality_Txt;
        private Button Save_Btn;
        private Button Delete_Btn;
        private Button Cancel_Btn;
    }
}