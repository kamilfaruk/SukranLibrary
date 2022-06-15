using SukranLibrary.Controls;
using System.Drawing;
using System.Windows.Forms;
namespace SukranLibrary.Forms.SubForms
{
    partial class AuthorForm
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
            this.Main_Table = new TableLayoutPanel();
            this.Close_Btn = new Button();
            this.Main_AuthorCrudControl = new AuthorCrudControl();
            this.Main_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Table
            // 
            this.Main_Table.BackColor = Color.Transparent;
            this.Main_Table.ColumnCount = 2;
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33));
            this.Main_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Main_Table.RowCount = 2;
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            this.Main_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Main_Table.Controls.Add(this.Close_Btn, 0, 0);
            this.Main_Table.Controls.Add(this.Main_AuthorCrudControl, 0, 1);
            this.Main_Table.SetColumnSpan(this.Main_AuthorCrudControl, 2);
            this.Main_Table.Dock = DockStyle.Fill;
            this.Main_Table.Location = new System.Drawing.Point(0, 0);
            this.Main_Table.Name = "Main_Table";
            this.Main_Table.Size = new System.Drawing.Size(800, 450);
            this.Main_Table.TabIndex = 0;
            // 
            // Close_Btn
            // 
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            this.Close_Btn.FlatStyle = FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.Close_Btn.ForeColor = Color.FromArgb(192, 192, 192);
            this.Close_Btn.Location = new System.Drawing.Point(0, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(25, 25);
            this.Close_Btn.Image = ((System.Drawing.Image)(Properties.Resources.Close_Image));
            this.Close_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            //
            //Main_AuthorCrudControl
            //
            this.Main_AuthorCrudControl.Dock = DockStyle.Fill;
            // 
            //AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(47, 52, 58);
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(Main_Table);
            this.Text = "AuthorForm";
            this.Name = "AuthorForm";
            this.Main_Table.ResumeLayout(false);
            this.Main_Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TableLayoutPanel Main_Table;
        private Button Close_Btn;
        private AuthorCrudControl Main_AuthorCrudControl;
    }
}