using System;

namespace ProductManagement.Models
{
    public class Product
    {
        public int Id { get; set; }          // Primary Key
        public string Name { get; set; }     // Ürün adı
        public decimal Price { get; set; }   // Fiyat
        public string Description { get; set; } // Açıklama
        public DateTime CreatedDate { get; set; } // Eklenme tarihi
    }
}
