/* Coder by KFY */
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SukranLibrary.Models;
using SukranLibrary.Components;
using SukranLibrary.Database;
using System.Collections.Generic;

namespace SukranLibrary.Controls
{
    public partial class BookCrudControl : UserControl
    {
        Book Main_Book = new Book();
        public delegate void AddBookEvent();
        public event AddBookEvent AddBook;
        public delegate void UpdateBookEvent();
        public event UpdateBookEvent UpdateBook;
        public delegate void DeleteBookEvent();
        public event DeleteBookEvent DeleteBook;
        public delegate void BookSelectedEvent(int _bookId);
        public event BookSelectedEvent BookSelected;
        public BookCrudControl()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.BookCrudControl -> ", _ex);
            }
        }
        private void BookCrudControl_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.BookCrudControl_Load -> ", _ex);
            }
        }
        private void Book_Dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Book_Dgv.CurrentRow.Index != -1)
                    {
                        Main_Book.Id = Convert.ToInt32(Book_Dgv.CurrentRow.Cells["Id"].Value);
                        Main_Book = _dbManager.GetBookList().Where(x => x.Id == Main_Book.Id).FirstOrDefault();
                        Name_Txt.Texts = Main_Book.Name;
                        Author_Cbx.SelectedItem = ((List<Author>)Author_Cbx.DataSource).Find(_author => _author.Id == Main_Book.AuthorId);
                        Publisher_Txt.Texts = Main_Book.Publisher;
                        Comment_Txt.Texts = Main_Book.Comment;
                        Summary_Txt.Texts = Main_Book.Summary;
                        Save_Btn.Text = "DÜZENLE";
                        Save_Btn.Image = Properties.Resources.Edit_Image;
                        Delete_Btn.Enabled = true;
                        if (BookSelected != null)
                        {
                            BookSelected(Main_Book.Id);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.Book_Dgv_DoubleClick -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    Main_Book.Name = Name_Txt.Texts;
                    Author _author = _dbManager.GetAuthor(((Author)Author_Cbx.SelectedItem).Id);
                    Main_Book.Author = _author;
                    Main_Book.AuthorId = _author.Id;
                    Main_Book.Publisher = Publisher_Txt.Texts;
                    Main_Book.Comment = Comment_Txt.Texts;
                    Main_Book.Summary = Summary_Txt.Texts;
                    if (Main_Book.Id == 0)
                    {
                        if (_dbManager.AddBook(Main_Book))
                        {
                            if (AddBook != null)
                            {
                                AddBook();
                            }
                        }
                    }
                    else
                    {
                        if (_dbManager.UpdateBook(Main_Book))
                        {
                            if (UpdateBook != null)
                            {
                                UpdateBook();
                            }
                        }
                    }
                }
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.Save_Btn_Click -> ", _ex);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Kitabı silmek istediğinizden emin misiniz?";
                    string _header = "KİTAP SİLME ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            if (_dbManager.DeleteBook(Main_Book))
                            {
                                if (DeleteBook != null)
                                {
                                    DeleteBook();
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
                Logger.WriteLog("BookCrudControl.Delete_Btn_Click -> ", _ex);
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
                Logger.WriteLog("BookCrudControl.Cancel_Btn_Click -> ", _ex);
            }
        }
        private void Clear()
        {
            try
            {
                Author_Cbx.SelectedIndex = -1;
                Name_Txt.Texts = Publisher_Txt.Texts = Comment_Txt.Texts = Summary_Txt.Texts = "";
                Save_Btn.Text = "KAYDET";
                Save_Btn.Image = Properties.Resources.Save_Image;
                Delete_Btn.Enabled = false;
                Main_Book.Id = 0;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.Clear -> ", _ex);
            }
        }
        private void PopulateDataGridView()
        {
            try
            {

                Book_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    Author_Cbx.DataSource = _dbManager.GetAuthorList();
                    Book_Dgv.DataSource = _dbManager.GetBookList();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.PopulateDataGridView -> ", _ex);
            }
        }
    }
}