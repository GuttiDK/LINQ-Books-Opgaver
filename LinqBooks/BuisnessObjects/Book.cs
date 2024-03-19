using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBooks.BuisnessObjects
{
    public class Book
    {
        public IEnumerable<Author> Authors { get; set; }
        public String Isbn { get; set; } = string.Empty;
        public String Notes { get; set; } = string.Empty;
        public Int32 PageCount { get; set; }
        public Decimal Price { get; set; }
        public DateTime PublicationDate { get; set; } = new DateTime();
        public Publisher Publisher { get; set; } = default!;
        public IEnumerable<Review> Reviews { get; set; } = default!;
        public Subject Subject { get; set; } = default!;
        public String Summary { get; set; } = default!;
        public String Title { get; set; } = default!;

        public override String ToString()
        {
            return Title;
        }
    }
}
