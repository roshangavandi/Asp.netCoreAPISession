using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
            Sale = new HashSet<Sale>();
        }
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int PubId { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string Notes { get; set; }
        
        public DateTime PublishedDate { get; set; }

        public Publisher Pub { get; set; }
        public ICollection<BookAuthor> BookAuthor { get; set; }
        public ICollection<Sale> Sale { get; set; }
    }
}
