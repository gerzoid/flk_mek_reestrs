using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestrs.Database.Models
{
    public class SCHET
    {
        [Key]
        public int SCHETId { get; set; }

        // Обязательное поле, тип int, размер 8
        [Required]
        public int CODE { get; set; }

        // Обязательное поле, тип string, размер 6
        [Required]
        [StringLength(6)]
        public string CODE_MO { get; set; }

        // Условное поле, тип string, размер 250
        [StringLength(250)]
        public string? COMENTS { get; set; }

        // Обязательное поле, тип string, размер 3
        //[Required] TODO
        [StringLength(3)]
        public string? DISP { get; set; }

        // Обязательное поле, тип DateTime
        [Required]
        public DateTime DSCHET { get; set; }

        // Обязательное поле, тип int, размер 2
        [Required]
        public int MONTH { get; set; }

        // Обязательное поле, тип string, размер 15
        [Required]
        [StringLength(15)]
        public string NSCHET { get; set; }

        // Условное поле, тип string, размер 5
        [StringLength(5)]
        public string? PLAT { get; set; }

        // Условное поле, тип decimal, может быть null
        [Precision(17,2)]
        public decimal? SANK_EKMP { get; set; }

        // Условное поле, тип decimal, может быть null
        [Precision(17,2)]
        public decimal? SANK_MEE { get; set; }

        // Условное поле, тип decimal, может быть null
        [Precision(17, 2)]
        public decimal? SANK_MEK { get; set; }

        // Условное поле, тип decimal, может быть null
        [Precision(17, 2)]
        public decimal? SUMMAP { get; set; }

        // Обязательное поле, тип decimal, не может быть null
        [Required]
        [Precision(17, 2)]
        public decimal SUMMAV { get; set; }

        // Обязательное поле, тип int, размер 4
        [Required]
        public int YEAR { get; set; }
    }
}
