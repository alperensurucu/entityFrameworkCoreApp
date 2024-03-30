using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace entityFrameworkCoreApp.Data
{
    public class Ogrenci 

    {
        [Key]                                     // ID => primary key
        public int Id { get; set; } 
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
    }
}
