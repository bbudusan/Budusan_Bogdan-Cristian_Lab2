﻿namespace Budusan_Bogdan_Cristian_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Booksss { get; set; } //navigation property
    }

}
