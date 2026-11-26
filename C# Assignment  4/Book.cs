using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment__4
{
    public enum Genre { Fiction, NonFiction, Science }
    public class Book
    {
        // Q1
        private string password = "secret";

        // Q2
        internal int copiesInStock = 5;

        // Q3
        public string Title;

        // Q4
        public Genre Genre { get; set; }
    }
}
