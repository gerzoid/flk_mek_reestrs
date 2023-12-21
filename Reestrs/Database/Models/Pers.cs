using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestrs.Database.Models
{
    public class Pers
    {
        [Key]
        public int PersId { get; set; }
        [StringLength(250)]
        public string? COMENTP { get; set; }
        public DateTime? DOCDATE { get; set; }
        [StringLength(20)]
        public string? DOCNUM { get; set; }
        [StringLength(1000)]
        public string? DOCORG { get; set; }
        [StringLength(10)]
        public string? DOCSER { get; set; }
        [StringLength(2)]
        public string? DOCTYPE { get; set; }
        public int? DOST { get; set; }
        public int? DOST_P { get; set; }
        [Required]
        public DateTime DR { get; set; }
        public DateTime? DR_P { get; set; }
        [StringLength(40)]
        public string? FAM { get; set; }
        [StringLength(40)]
        public string? FAM_P { get; set; }
        [StringLength(36)]
        public string? ID_PAC { get; set; }
        [StringLength(40)]
        public string? IM { get; set; }
        [StringLength(40)]
        public string? IM_P { get; set; }
        [StringLength(100)]
        public string? MR { get; set; }
        [StringLength(11)]
        public string? OKATOG { get; set; }
        [StringLength(11)]
        public string? OKATOP { get; set; }
        [StringLength(40)]
        public string? OT { get; set; }
        [StringLength(40)]
        public string? OT_P { get; set; }
        [StringLength(14)]
        public string? SNILS { get; set; }
        [StringLength(100)]
        public string? TEL { get; set; }
        [Required]
        public int W { get; set; }
        public int? W_P { get; set; }

        [ForeignKey("PersListId")]
        public int PersListId { get; set; }
        [Required]
        public PersList PersList { get; set; }
    }

}
