using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBooks.BuisnessObjects
{
    public class Subject
    {
        public String Description { get; set; } = string.Empty;
        public String Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
