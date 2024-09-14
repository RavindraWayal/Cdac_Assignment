﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Utility.models
{
    public class Author
    {
        public int AuthorId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>Books { get; set; }
    }
}
