using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using SukranLibrary.Components;
namespace SukranLibrary.Controls
{
    partial class BookCrudControl
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
            this.Book_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Name = new DataGridViewTextBoxColumn();
            this.AuthorId = new DataGridViewTextBoxColumn();
            this.Author = new DataGridViewTextBoxColumn();
            this.Publisher = new DataGridViewTextBoxColumn();
            this.Comment = new DataGridViewTextBoxColumn();
            this.Summary = new DataGridViewTextBoxColumn();
            this.Manager_Table = new TableLayoutPanel();
            this.Name_Lbl = new Label();
            this.Name_Txt = new Custom_TextBox();
            this.Author_Lbl = new Label();
            this.Author_Cbx = new Custom_ComboBox();
            this.Publisher_Lbl = new Label();
            this.Publisher_Txt = new Custom_TextBox();
            this.Comment_Lbl = new Label();
            this.Comment_Txt = new Custom_TextBox();
            this.Summary_Lbl = new Label();
            this.Summary_Txt = new Custom_TextBox();
            this.Save_Btn = new Button();
            this.Delete_Btn = new Button();
            this.Cancel_Btn = new Button();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.Book_Dgv)).BeginInit();
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
            this.Main_Table.Controls.Add(this.Book_Dgv, 0, 0);
            this.Main_Table.Controls.Add(this.Manager_Table, 1, 0);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            // 
            // Book_Dgv
            // 
            this.Book_Dgv.Dock = DockStyle.Fill;
            this.Book_Dgv.Name = "Book_Dgv";
            this.Book_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.AuthorId,
            this.Author,
            this.Publisher,
            this.Comment,
            this.Summary});
            this.Book_Dgv.DoubleClick += new System.EventHandler(this.Book_Dgv_DoubleClick);
            // 
            //Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            //Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "KİTAP";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            //AuthorId
            // 
            this.AuthorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorId.DataPropertyName = "AuthorId";
            this.AuthorId.HeaderText = "YAZAR NO";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            this.AuthorId.Visible = false;
            // 
            //Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "YAZAR";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            //Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "YAYINCI";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            //Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "YORUM";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            //Summary
            // 
            this.Summary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Summary.DataPropertyName = "Summary";
            this.Summary.HeaderText = "ÖZET";
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            //
            //Manager_Table
            //
            this.Manager_Table.BackColor = Color.Transparent;
            this.Manager_Table.ColumnCount = 4;
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            this.Manager_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Manager_Table.RowCount = 7;
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            this.Manager_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Manager_Table.Controls.Add(this.Name_Lbl, 0, 0);
            this.Manager_Table.Controls.Add(this.Name_Txt, 2, 0);
            this.Manager_Table.SetColumnSpan(this.Name_Txt, 2);
            this.Manager_Table.Controls.Add(this.Author_Lbl, 0, 1);
            this.Manager_Table.Controls.Add(this.Author_Cbx, 2, 1);
            this.Manager_Table.SetColumnSpan(this.Author_Cbx, 2);
            this.Manager_Table.Controls.Add(this.Publisher_Lbl, 0, 2);
            this.Manager_Table.Controls.Add(this.Publisher_Txt, 2, 2);
            this.Manager_Table.SetColumnSpan(this.Publisher_Txt, 2);
            this.Manager_Table.Controls.Add(this.Comment_Lbl, 0, 3);
            this.Manager_Table.Controls.Add(this.Comment_Txt, 2, 3);
            this.Manager_Table.SetColumnSpan(this.Comment_Txt, 2);
            this.Manager_Table.Controls.Add(this.Summary_Lbl, 0, 4);
            this.Manager_Table.Controls.Add(this.Summary_Txt, 2, 4);
            this.Manager_Table.SetColumnSpan(this.Summary_Txt, 2);
            this.Manager_Table.Controls.Add(this.Save_Btn, 0, 5);
            this.Manager_Table.Controls.Add(this.Delete_Btn, 1, 5);
            this.Manager_Table.SetColumnSpan(this.Delete_Btn, 2);
            this.Manager_Table.Controls.Add(this.Cancel_Btn, 3, 5);
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
            //Name_Txt
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
            //Author_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Author_Lbl, 2);
            this.Author_Lbl.Dock = DockStyle.Fill;
            this.Author_Lbl.BackColor = Color.Transparent;
            this.Author_Lbl.Name = "Author_Lbl";
            this.Author_Lbl.Text = "Yazar:";
            this.Author_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Author_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Author_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Author_Cbx
            //
            this.Author_Cbx.Name = "Author_Cbx";
            this.Author_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.Author_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            this.Author_Cbx.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Author_Cbx.Dock = DockStyle.Fill;
            // 
            //Publisher_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Publisher_Lbl, 2);
            this.Publisher_Lbl.Dock = DockStyle.Fill;
            this.Publisher_Lbl.BackColor = Color.Transparent;
            this.Publisher_Lbl.Name = "Publisher_Lbl";
            this.Publisher_Lbl.Text = "Yayıncı:";
            this.Publisher_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Publisher_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Publisher_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Publisher_Txt
            // 
            this.Publisher_Txt.Name = "Publisher_Txt";
            this.Publisher_Txt.Dock = DockStyle.Fill;
            this.Publisher_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Publisher_Txt.AutoSize = true;
            this.Publisher_Txt.TextAlign = HorizontalAlignment.Left;
            this.Publisher_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Publisher_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Publisher_Txt.UnderlinedStyle = true;
            this.Publisher_Txt.TabIndex = 0;
            this.Publisher_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Publisher_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Comment_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Comment_Lbl, 2);
            this.Comment_Lbl.Dock = DockStyle.Fill;
            this.Comment_Lbl.BackColor = Color.Transparent;
            this.Comment_Lbl.Name = "Comment_Lbl";
            this.Comment_Lbl.Text = "Yorum:";
            this.Comment_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Comment_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Comment_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Comment_Txt
            // 
            this.Comment_Txt.Name = "Comment_Txt";
            this.Comment_Txt.Dock = DockStyle.Fill;
            this.Comment_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Comment_Txt.AutoSize = true;
            this.Comment_Txt.TextAlign = HorizontalAlignment.Left;
            this.Comment_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Comment_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Comment_Txt.UnderlinedStyle = true;
            this.Comment_Txt.TabIndex = 0;
            this.Comment_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Comment_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Summary_Lbl
            // 
            this.Manager_Table.SetColumnSpan(this.Summary_Lbl, 2);
            this.Summary_Lbl.Dock = DockStyle.Fill;
            this.Summary_Lbl.BackColor = Color.Transparent;
            this.Summary_Lbl.Name = "Summary_Lbl";
            this.Summary_Lbl.Text = "Özet:";
            this.Summary_Lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Summary_Lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Summary_Lbl.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Summary_Txt
            // 
            this.Summary_Txt.Name = "Summary_Txt";
            this.Summary_Txt.Dock = DockStyle.Fill;
            this.Summary_Txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Summary_Txt.AutoSize = true;
            this.Summary_Txt.TextAlign = HorizontalAlignment.Left;
            this.Summary_Txt.BorderColor = Color.FromArgb(202, 43, 77);
            this.Summary_Txt.BorderFocusColor = Color.FromArgb(135, 29, 52);
            this.Summary_Txt.UnderlinedStyle = true;
            this.Summary_Txt.TabIndex = 0;
            this.Summary_Txt.BackColor = Color.FromArgb(64, 69, 76);
            this.Summary_Txt.ForeColor = Color.FromArgb(192, 192, 192);
            // 
            //Save_Btn
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
            //Delete_Btn
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
            //Cancel_Btn
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
            //BookCrudControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += BookCrudControl_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Manager_Table.ResumeLayout(false);
            this.Manager_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private Custom_DataGridView Book_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn AuthorId;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Publisher;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn Summary;
        private TableLayoutPanel Manager_Table;
        private Label Name_Lbl;
        private Custom_TextBox Name_Txt;
        private Label Author_Lbl;
        private Custom_ComboBox Author_Cbx;
        private Label Publisher_Lbl;
        private Custom_TextBox Publisher_Txt;
        private Label Comment_Lbl;
        private Custom_TextBox Comment_Txt;
        private Label Summary_Lbl;
        private Custom_TextBox Summary_Txt;
        private Button Save_Btn;
        private Button Delete_Btn;
        private Button Cancel_Btn;
    }
}