/* Coder by KFY */
using System;
using System.Linq;
using System.Collections.Generic;
using SukranLibrary.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SukranLibrary.Database
{
    public class DBManager : IDisposable
    {
        SukranLibraryDbContext DB = null;
        public DBManager()
        {
            try
            {
                DB = new SukranLibraryDbContext();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DBManager -> ", _ex);
            }
        }
        public void Dispose()
        {
            try
            {
                DB.Dispose();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.Dispose -> ", _ex);
            }
        }
        public void RunQuery(string _queryString)
        {
            string _sqliteConnectingString = "Data Source=" + Application.StartupPath.ToString() + @"\" + Constants.DB_ConnectionString;
            using (SqlConnection connection = new SqlConnection(_sqliteConnectingString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(_queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception _ex)
                {
                    Logger.WriteLog("DBManager.RunQuery -> ", _ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #region Users
        public List<User> GetUserList()
        {
            try
            {
                return DB.Users.ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetUserList -> ", _ex);
                return null;
            }
        }
        public User GetUser(int _id)
        {
            try
            {
                return GetUserList().Find(_user => _user.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetUser -> ", _ex);
                return null;
            }
        }
        public bool AddUser(User _user)
        {
            try
            {
                DB.Users.Add(_user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateUser(User _user)
        {
            try
            {
                DB.Entry(_user).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteUser(User _user)
        {
            try
            {
                var entry = DB.Entry(_user);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Users.Attach(_user);
                }
                DB.Users.Remove(_user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteUser -> ", _ex);
                string _message = "Ne Yazıkki yeni kullanıcı silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region Books
        public List<Book> GetBookList()
        {
            try
            {
                return DB.Books.Include("Author").ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetBookList -> ", _ex);
                return null;
            }
        }
        public Book GetBook(int _id)
        {
            try
            {
                return GetBookList().Find(_book => _book.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetBook -> ", _ex);
                return null;
            }
        }
        public bool AddBook(Book _book)
        {
            try
            {
                DB.Books.Add(_book);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddBook -> ", _ex);
                string _message = "Ne Yazıkki yeni kitap eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateBook(Book _book)
        {
            try
            {
                DB.Entry(_book).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateBook -> ", _ex);
                string _message = "Ne Yazıkki yeni kitap güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteBook(Book _book)
        {
            try
            {
                var entry = DB.Entry(_book);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Books.Attach(_book);
                }
                DB.Books.Remove(_book);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteBook -> ", _ex);
                string _message = "Ne Yazıkki yeni kitap silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region Authors
        public List<Author> GetAuthorList()
        {
            try
            {
                return DB.Authors.ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetAuthorList -> ", _ex);
                return null;
            }
        }
        public Author GetAuthor(int _id)
        {
            try
            {
                return GetAuthorList().Find(_author => _author.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetAuthor -> ", _ex);
                return null;
            }
        }
        public bool AddAuthor(Author _author)
        {
            try
            {
                DB.Authors.Add(_author);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddAuthor -> ", _ex);
                string _message = "Ne Yazıkki yeni yazar eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateAuthor(Author _author)
        {
            try
            {
                DB.Entry(_author).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateAuthor -> ", _ex);
                string _message = "Ne Yazıkki yeni yazar güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteAuthor(Author _author)
        {
            try
            {
                var entry = DB.Entry(_author);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Authors.Attach(_author);
                }
                DB.Authors.Remove(_author);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteAuthor -> ", _ex);
                string _message = "Ne Yazıkki yeni yazar silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion

        #region Quotations
        public List<Quotation> GetQuotationList()
        {
            try
            {
                return DB.Quotations.Include("Book").ToList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetQuotationList -> ", _ex);
                return null;
            }
        }
        public Quotation GetQuotation(int _id)
        {
            try
            {
                return GetQuotationList().Find(_quotation => _quotation.Id == _id);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.GetQuotation -> ", _ex);
                return null;
            }
        }
        public bool AddQuotation(Quotation _quotation)
        {
            try
            {
                DB.Quotations.Add(_quotation);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.AddQuotation -> ", _ex);
                string _message = "Ne Yazıkki yeni alıntı eklenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool UpdateQuotation(Quotation _quotation)
        {
            try
            {
                DB.Entry(_quotation).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.UpdateQuotation -> ", _ex);
                string _message = "Ne Yazıkki yeni alıntı güncellenemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        public bool DeleteQuotation(Quotation _quotation)
        {
            try
            {
                var entry = DB.Entry(_quotation);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    DB.Quotations.Attach(_quotation);
                }
                DB.Quotations.Remove(_quotation);
                DB.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("DBManager.DeleteQuotation -> ", _ex);
                string _message = "Ne Yazıkki yeni alıntı silinemedi.";
                string _title = "VERİTABANI HATASI";
                Logger.WriteErrorMsg(_message, _title);
                return false;
            }
        }
        #endregion
    }
}
