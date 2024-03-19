using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBooks.BuisnessObjects
{
    public class Publisher
    {
        public String Name { get; set; } = string.Empty;
        //public Bitmap Logo {get; set;}
        public String WebSite { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
