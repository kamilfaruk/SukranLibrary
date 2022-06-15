/* Coder by KFY */
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SukranLibrary.Models;
using SukranLibrary.Components;
using SukranLibrary.Database;

namespace SukranLibrary.Controls
{
    public partial class AuthorCrudControl : UserControl
    {
        Author Main_Author = new Author();
        public delegate void AddAuthorEvent();
        public event AddAuthorEvent AddAuthor;
        public delegate void UpdateAuthorEvent();
        public event UpdateAuthorEvent UpdateAuthor;
        public delegate void DeleteAuthorEvent();
        public event DeleteAuthorEvent DeleteAuthor;
        public delegate void AuthorSelectedEvent();
        public event AuthorSelectedEvent AuthorSelected;
        public AuthorCrudControl()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.AuthorCrudControl -> ", _ex);
            }
        }
        private void AuthorCrudControl_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.AuthorCrudControl_Load -> ", _ex);
            }
        }
        private void Author_Dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Author_Dgv.CurrentRow.Index != -1)
                    {
                        Main_Author.Id = Convert.ToInt32(Author_Dgv.CurrentRow.Cells["Id"].Value);
                        Main_Author = _dbManager.GetAuthorList().Where(x => x.Id == Main_Author.Id).FirstOrDefault();
                        Name_Txt.Texts = Main_Author.Name;
                        Surname_Txt.Texts = Main_Author.Surname;
                        DateOfBirth_Dtp.Value = Convert.ToDateTime(Main_Author.DateOfBirth);
                        Nationality_Txt.Texts = Main_Author.Nationality;
                        Save_Btn.Text = "DÜZENLE";
                        Save_Btn.Image = Properties.Resources.Edit_Image;
                        Delete_Btn.Enabled = true;
                        if (AuthorSelected != null)
                        {
                            AuthorSelected();
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.Author_Dgv_DoubleClick -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Main_Author.Name = Name_Txt.Texts;
                Main_Author.Surname = Surname_Txt.Texts;
                Main_Author.DateOfBirth = DateOfBirth_Dtp.Value.ToString("dd.MM.yyyy");
                Main_Author.Nationality = Nationality_Txt.Texts;
                using (DBManager _dbManager = new DBManager())
                {
                    if (Main_Author.Id == 0)
                    {
                        if (_dbManager.AddAuthor(Main_Author))
                        {
                            if (AddAuthor != null)
                            {
                                AddAuthor();
                            }
                        }
                    }
                    else
                    {
                        if (_dbManager.UpdateAuthor(Main_Author))
                        {
                            if (UpdateAuthor != null)
                            {
                                UpdateAuthor();
                            }
                        }
                    }
                }
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.Save_Btn_Click -> ", _ex);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Yazarı silmek istediğinizden emin misiniz?";
                    string _header = "YAZAR SİLME ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            if (_dbManager.DeleteAuthor(Main_Author))
                            {
                                if (DeleteAuthor != null)
                                {
                                    DeleteAuthor();
                                }
                            }
                        }
                        PopulateDataGridView();
                        Clear();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.Delete_Btn_Click -> ", _ex);
            }
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.Cancel_Btn_Click -> ", _ex);
            }
        }
        private void Clear()
        {
            try
            {
                DateOfBirth_Dtp.Value = DateTime.Now;
                Name_Txt.Texts = Surname_Txt.Texts = Nationality_Txt.Texts = "";
                Save_Btn.Text = "KAYDET";
                Save_Btn.Image = Properties.Resources.Save_Image;
                Delete_Btn.Enabled = false;
                Main_Author.Id = 0;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.Clear -> ", _ex);
            }
        }
        private void PopulateDataGridView()
        {
            try
            {
                Author_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    Author_Dgv.DataSource = _dbManager.GetAuthorList();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorCrudControl.PopulateDataGridView -> ", _ex);
            }
        }
    }
}