using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Reestrs.Database.Models
{
    // Модель для SANK
    public class SANK
    {
        [Key]
        public int SankId { get; set; }

        // Условное множественное поле
        //[XmlArray(ElementName = "CODE_EXP", IsNullable = true)]
        [XmlElement("CODE_EXP")]
        public string[] CODE_EXP { get; set; }

        public DateTime? DATE_ACT { get; set; }

        // Обязательное поле, тип string, размер 30
        [StringLength(30)]
        public string? NUM_ACT { get; set; }

        // Обязательное поле, тип string, размер 36
        [Required]
        [StringLength(36)]
        public string S_CODE { get; set; }

        // Условное поле, тип string, размер 250
        [StringLength(250)]
        public string? S_COM { get; set; }

        // Обязательное поле, тип int, не может быть null
        [Required]
        public int? S_IST { get; set; }

        // Условное поле, тип int, может быть null
        public int? S_OSN { get; set; }

        // Обязательное поле, тип decimal, не может быть null
        [Required]
        [Precision(17,2)]
        public decimal S_SUM { get; set; }

        // Обязательное поле, тип string, размер 2
        [Required]
        [StringLength(2)]
        public string S_TIP { get; set; }

        // Множественное поле SL_ID
        [XmlElement("SL_ID")]
        public List<string> SL_ID { get; set; }

        [ForeignKey("PersListId")]
        public int PersListId { get; set; }
        [Required]
        public PersList PersList { get; set; }

    }

}
