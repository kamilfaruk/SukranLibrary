/* Coder by KFY */
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SukranLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Publisher { get; set; }
        public string Comment { get; set; }
        public string Summary { get; set; }
        public virtual List<Quotation> QuotationList { get; set; } = new List<Quotation>();
        public override string ToString()
        {
            return this.Name;
        }
    }
}
