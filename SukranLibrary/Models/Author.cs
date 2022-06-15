/* Coder by KFY */
using System;
using System.Collections.Generic;

namespace SukranLibrary.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public virtual List<Book> BookList { get; set; } = new List<Book>();
        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
