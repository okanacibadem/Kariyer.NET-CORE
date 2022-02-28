using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kariyer.Models
{
    public class BasvuruSahibi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string AdSoyad { get; set; } = "";

        [Required]
        [StringLength(10)]
        public string Cinsiyet { get; set; } = "";

       [Required]
       [Range(25,55,ErrorMessage ="bu pozisyona yaş uygun değil")]
       [DisplayName("Yas")]
        public int Yas { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "gecersiz")]
        [DisplayName("Toplam Çalışma Yılı")]

        public int ToplamTecrube { get; set; }

      


    }
}
