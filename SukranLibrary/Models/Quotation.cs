/* Coder by KFY */
using System.ComponentModel.DataAnnotations.Schema;

namespace SukranLibrary.Models
{
    public class Quotation
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public string Summary { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public override string ToString()
        {
            return this.Page + "-" + this.Summary;
        }
    }
}
