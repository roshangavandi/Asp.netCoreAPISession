﻿using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public byte? AuthorOrder { get; set; }
        public int? RoyalityPercentage { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
