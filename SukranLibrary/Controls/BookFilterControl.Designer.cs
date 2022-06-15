using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using SukranLibrary.Components;
namespace SukranLibrary.Controls
{
    partial class BookFilterControl
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
            this.Filter_Table = new TableLayoutPanel();
            this.Name_Lbl = new Label();
            this.Name_Txt = new Custom_TextBox();
            this.Name_Btn = new Button();
            this.Author_Lbl = new Label();
            this.Author_Cbx = new Custom_ComboBox();
            this.Author_Btn = new Button();
            this.Publisher_Lbl = new Label();
            this.Publisher_Txt = new Custom_TextBox();
            this.Publisher_Btn = new Button();
            this.Book_Dgv = new Custom_DataGridView();
            this.Id = new DataGridViewTextBoxColumn();
            this.Name = new DataGridViewTextBoxColumn();
            this.AuthorId = new DataGridViewTextBoxColumn();
            this.Author = new DataGridViewTextBoxColumn();
            this.Publisher = new DataGridViewTextBoxColumn();
            this.Comment = new DataGridViewTextBoxColumn();
            this.Summary = new DataGridViewTextBoxColumn();
            this.Main_Table.SuspendLayout();
            ((ISupportInitialize)(this.Book_Dgv)).BeginInit();
            this.Filter_Table.SuspendLayout();
            this.SuspendLayout();
            //
            //Main_Table
            //
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 1;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Filter_Table, 0, 0);
            this.Main_Table.Controls.Add(this.Book_Dgv, 0, 1);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.TabIndex = 0;
            //
            //Filter_Table
            //
            this.Filter_Table.BackColor = Color.Transparent;
            this.Filter_Table.ColumnCount = 11;
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            this.Filter_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Filter_Table.RowCount = 1;
            this.Filter_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Filter_Table.Controls.Add(this.Name_Lbl, 1, 0);
            this.Filter_Table.Controls.Add(this.Name_Txt, 2, 0);
            this.Filter_Table.Controls.Add(this.Name_Btn, 3, 0);
            this.Filter_Table.Controls.Add(this.Author_Lbl, 4, 0);
            this.Filter_Table.Controls.Add(this.Author_Cbx, 5, 0);
            this.Filter_Table.Controls.Add(this.Author_Btn, 6, 0);
            this.Filter_Table.Controls.Add(this.Publisher_Lbl, 7, 0);
            this.Filter_Table.Controls.Add(this.Publisher_Txt, 8, 0);
            this.Filter_Table.Controls.Add(this.Publisher_Btn, 9, 0);
            this.Filter_Table.Dock = DockStyle.Fill;
            this.Filter_Table.Name = "Filter_Table";
            this.Filter_Table.TabIndex = 0;
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.Dock = DockStyle.Fill;
            this.Name_Lbl.BackColor = Color.Transparent;
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Text = "Kitap:";
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
            //Name_Btn
            //
            this.Name_Btn.Dock = DockStyle.Fill;
            this.Name_Btn.Name = "Name_Btn";
            this.Name_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Name_Btn.FlatAppearance.BorderSize = 1;
            this.Name_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Name_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Name_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Name_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Name_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_Btn.UseVisualStyleBackColor = true;
            this.Name_Btn.Click += Name_Btn_Click;
            // 
            // Author_Lbl
            // 
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
            this.Author_Cbx.Dock = DockStyle.Fill;
            this.Author_Cbx.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.Author_Cbx.BackColor = Color.FromArgb(64, 69, 76);
            this.Author_Cbx.ForeColor = Color.FromArgb(192, 192, 192);
            //
            //Author_Btn
            //
            this.Author_Btn.Dock = DockStyle.Fill;
            this.Author_Btn.Name = "Author_Btn";
            this.Author_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Author_Btn.FlatAppearance.BorderSize = 1;
            this.Author_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Author_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Author_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Author_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Author_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author_Btn.UseVisualStyleBackColor = true;
            this.Author_Btn.Click += Author_Btn_Click;
            // 
            // Publisher_Lbl
            // 
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
            //Publisher_Btn
            //
            this.Publisher_Btn.Dock = DockStyle.Fill;
            this.Publisher_Btn.Name = "Publisher_Btn";
            this.Publisher_Btn.FlatAppearance.BorderColor = Color.FromArgb(202, 43, 77);
            this.Publisher_Btn.FlatAppearance.BorderSize = 1;
            this.Publisher_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            this.Publisher_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Publisher_Btn.BackgroundImage = Properties.Resources.Filter2_Image;
            this.Publisher_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            this.Publisher_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publisher_Btn.UseVisualStyleBackColor = true;
            this.Publisher_Btn.Click += Publisher_Btn_Click;
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
            //BookFilterControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(800, 600);
            this.Load += BookFilterControl_Load;
            this.Controls.Add(this.Main_Table);
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.Filter_Table.ResumeLayout(false);
            this.Filter_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Dgv)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private TableLayoutPanel Main_Table;
        private TableLayoutPanel Filter_Table;
        private Label Name_Lbl;
        private Custom_TextBox Name_Txt;
        private Button Name_Btn;
        private Label Author_Lbl;
        private Custom_ComboBox Author_Cbx;
        private Button Author_Btn;
        private Label Publisher_Lbl;
        private Custom_TextBox Publisher_Txt;
        private Button Publisher_Btn;
        private Custom_DataGridView Book_Dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn AuthorId;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Publisher;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn Summary;

    }
}