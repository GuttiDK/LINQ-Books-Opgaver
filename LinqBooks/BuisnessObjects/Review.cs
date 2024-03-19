using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBooks.BuisnessObjects
{
    public class Review
    {
        public Book Book { get; set; } = default!;
        //public Guid User {get; set;}
        public User User { get; set; } = default!;
        public int Rating { get; set; }
        public String Comments { get; set; } = string.Empty;
    }
}
