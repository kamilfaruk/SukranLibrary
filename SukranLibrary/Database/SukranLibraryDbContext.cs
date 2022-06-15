/* Coder by KFY */
using System;
using System.Data.Entity;
using SukranLibrary.Models;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SukranLibrary.Database
{
    public class SukranLibraryDbContext : DbContext
    {
        public SukranLibraryDbContext() : base()
        {
            try
            {
                string _sqliteConnectingString = "Data Source=" + Application.StartupPath.ToString() + @"\" + Constants.DB_ConnectionString;
                this.Database.Connection.ConnectionString = _sqliteConnectingString;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SukranLibraryDbContext.SukranLibraryDbContext -> ", _ex);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
    }
}
