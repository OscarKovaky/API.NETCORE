using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.View
{
    [Table("NXFCE102")]
    public class NXFCE102
    {
        [Column("INTERID")]
        [StringLength(5)]
        public string INTERID { get; set; }

        [Column("RMDTYPAL")]
        public short RMDTYPAL { get; set; }

        [Column("DOCNUMBR")]
        [StringLength(21)]
        public string DOCNUMBR { get; set; }

        [Column("INVCNMBR")]
        [StringLength(21)]
        public string INVCNMBR { get; set; }

        [Column("TAXDTLID")]
        [StringLength(15)]
        public string TAXDTLID { get; set; }

        [Column("TAXAMNT", TypeName = "numeric(19, 5)")]

        public decimal TAXAMNT { get; set; }

        [Column("STAXAMNT", TypeName = "numeric(19, 5)")]

        public decimal STAXAMNT { get; set; }

        [Column("TAXDTSLS", TypeName = "numeric(19, 5)")]

        public decimal TAXDTSLS { get; set; }

        [Column("ProductGroup")]
        [StringLength(31)]
        public string ProductGroup { get; set; }

        [Key]
        [Column("IdBookingLine")]
        [StringLength(31)]
        public string IdBookingLine { get; set; }

        [Column("ACTNUMST")]
        [StringLength(129)]
        public string ACTNUMST { get; set; }

        [Column("DEX_ROW_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DEX_ROW_ID { get; set; }
    }
}
