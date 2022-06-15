/* Coder by KFY */
using System;
using System.Windows.Forms;
using SukranLibrary.Models;
using SukranLibrary.Database;
using System.Collections.Generic;

namespace SukranLibrary.Controls
{
    public partial class BookFilterControl : UserControl
    {
        public BookFilterControl()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookFilterControl.BookFilterControl -> ", _ex);
            }
        }
        private void BookFilterControl_Load(object sender, EventArgs e)
        {
            try
            {
                Book_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    Author_Cbx.DataSource = _dbManager.GetAuthorList();
                    Book_Dgv.DataSource = _dbManager.GetBookList();
                }
                Name_Txt.Texts = Publisher_Txt.Texts = "";
                Author_Cbx.SelectedIndex = -1;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookFilterControl.BookFilterControl_Load -> ", _ex);
            }
        }
        private void Name_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Name_Txt.Texts != "")
                    {
                        List<Book> _bookList = _dbManager.GetBookList().FindAll(_b => _b.Name.ToLower().Contains(Name_Txt.Texts.ToLower()));
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _dbManager.GetBookList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookFilterControl.Name_Btn_Click -> ", _ex);
            }
        }
        private void Author_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Author_Cbx.SelectedIndex != -1)
                    {
                        Author _author = (Author)Author_Cbx.SelectedItem;
                        List<Book> _bookList = _dbManager.GetBookList().FindAll(_b => _b.AuthorId == _author.Id);
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _dbManager.GetBookList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookFilterControl.Author_Btn_Click -> ", _ex);
            }
        }
        private void Publisher_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Publisher_Txt.Texts != "")
                    {
                        List<Book> _bookList = _dbManager.GetBookList().FindAll(_b => _b.Publisher.ToLower().Contains(Publisher_Txt.Texts.ToLower()));
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Book_Dgv.AutoGenerateColumns = false;
                        Book_Dgv.DataSource = _dbManager.GetBookList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookFilterControl.Publisher_Btn_Click -> ", _ex);
            }
        }
    }
}
