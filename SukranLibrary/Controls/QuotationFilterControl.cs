/* Coder by KFY */
using System;
using System.Windows.Forms;
using SukranLibrary.Models;
using SukranLibrary.Database;
using System.Collections.Generic;

namespace SukranLibrary.Controls
{
    public partial class QuotationFilterControl : UserControl
    {
        public QuotationFilterControl()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationFilterControl.QuotationFilterControl -> ", _ex);
            }
        }
        private void QuotationFilterControl_Load(object sender, EventArgs e)
        {
            try
            {
                Quotation_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    Book_Cbx.DataSource = _dbManager.GetBookList();
                    Quotation_Dgv.DataSource = _dbManager.GetQuotationList();
                }
                Page_Num.Value = 0;
                Summary_Txt.Texts = "";
                Book_Cbx.SelectedIndex = -1;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationFilterControl.QuotationFilterControl_Load -> ", _ex);
            }
        }
        private void Page_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Page_Num.Value != 0)
                    {
                        List<Quotation> _bookList = _dbManager.GetQuotationList().FindAll(_b => _b.Page == Page_Num.Value);
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _dbManager.GetQuotationList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationFilterControl.Page_Btn_Click -> ", _ex);
            }
        }

        private void Book_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Book_Cbx.SelectedIndex != -1)
                    {
                        Book _book = (Book)Book_Cbx.SelectedItem;
                        List<Quotation> _bookList = _dbManager.GetQuotationList().FindAll(_b => _b.BookId == _book.Id);
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _dbManager.GetQuotationList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationFilterControl.Book_Btn_Click -> ", _ex);
            }
        }

        private void Summary_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Summary_Txt.Texts != "")
                    {
                        List<Quotation> _bookList = _dbManager.GetQuotationList().FindAll(_b => _b.Summary.ToLower().Contains(Summary_Txt.Texts.ToLower()));
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _bookList;
                    }
                    else
                    {
                        Quotation_Dgv.AutoGenerateColumns = false;
                        Quotation_Dgv.DataSource = _dbManager.GetQuotationList();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationFilterControl.Summary_Btn_Click -> ", _ex);
            }
        }


    }
}
