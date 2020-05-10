using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIValidateException.Models
{
    public class Urun
    {  
        public int UrunID { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "Ürün adı 50 karakterden fazla olamaz.")]
        public string Adi { get; set; }

        [Range(0, 2000, ErrorMessage = "Yöneticiyle görüşünüz.")]
        public decimal Fiyati { get; set; }

        public short StokMiktari { get; set; }

        public string Agirlik { get; set; }
    }
}