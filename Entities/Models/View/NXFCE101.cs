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
    [Table("NXFCE101")]
    public class NXFCE101
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

        [Column("BookingCode")]
        [StringLength(31)]
        public string BookingCode { get; set; }

        [Key]
        [Column("IdBookingLine")]
        [StringLength(31)]
        public string IdBookingLine { get; set; }

        [Column("CMPNYNUM")]
        [StringLength(15)]
        public string CMPNYNUM { get; set; }

        [Column("ProductGroup")]
        [StringLength(31)]
        public string ProductGroup { get; set; }

        [Column("PaxNumber")]
        [StringLength(11)]
        public string PaxNumber { get; set; }

        [Column("DOCAMNT", TypeName = "numeric(19, 5)")]
        public decimal DOCAMNT { get; set; }

        [Column("COMMAMNT", TypeName = "numeric(19, 5)")]

        public decimal COMMAMNT { get; set; }

        [Column("ExSLCode")]
        [StringLength(31)]
        public string ExSLCode { get; set; }

        [Column("AnalyticCode")]
        [StringLength(31)]
        public string AnalyticCode { get; set; }

        [Column("Client")]
        [StringLength(31)]
        public string Client { get; set; }

        [Column("CURNCYID")]
        [StringLength(15)]
        public string CURNCYID { get; set; }

        [Column("ExtPurchCode")]
        [StringLength(31)]
        public string ExtPurchCode { get; set; }

        [Column("ExSaCoMCod")]
        [StringLength(31)]
        public string ExSaCoMCod { get; set; }

        [Column("TOTALPAY", TypeName = "numeric(19, 5)")]

        public decimal TOTALPAY { get; set; }

        [Column("AMNTPAID", TypeName = "numeric(19, 5)")]

        public decimal AMNTPAID { get; set; }

        [Column("Amount_Received", TypeName = "numeric(19, 5)")]
        public decimal Amount_Received { get; set; }

        [Column("REFRENCE")]
        [StringLength(31)]
        public string REFRENCE { get; set; }

        [Column("TRDISAMT", TypeName = "numeric(19, 5)")]
        public decimal TRDISAMT { get; set; }

        [Column("DEX_ROW_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DEX_ROW_ID { get; set; }
    }
}
