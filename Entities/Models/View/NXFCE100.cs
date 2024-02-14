using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.View
{

        [Table("NXFCE100")]
        public class NXFCE100
        {
            [Key]
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

            [Column("BACHNUMB")]
            [StringLength(15)]
            public string BACHNUMB { get; set; }

            [Column("CustVenID")]
            [StringLength(15)]
            public string CustVenID { get; set; }

            [Column("CUSTNMBR")]
            [StringLength(15)]
            public string CUSTNMBR { get; set; }

            [Column("CUSTNAME")]
            [StringLength(65)]
            public string CUSTNAME { get; set; }

            [Column("SHIPMTHD")]
            [StringLength(15)]
            public string SHIPMTHD { get; set; }

            [Column("TAXSCHID")]
            [StringLength(15)]
            public string TAXSCHID { get; set; }

            [Column("SHRTNAME")]
            [StringLength(15)]
            public string SHRTNAME { get; set; }

            [Column("AccountSales")]
            [StringLength(129)]
            public string AccountSales { get; set; }

            [Column("AccountRecive")]
            [StringLength(129)]
            public string AccountRecive { get; set; }

            [Column("AccountCost")]
            [StringLength(129)]
            public string AccountCost { get; set; }

            [Column("AccountProv")]
            [StringLength(129)]
            public string AccountProv { get; set; }

            [Column("AccountTrade")]
            [StringLength(129)]
            public string AccountTrade { get; set; }

            [Column("NGOAccountCred")]
            [StringLength(129)]
            public string NGOAccountCred { get; set; }

            [Column("NGOAccountDeb")]
            [StringLength(129)]
            public string NGOAccountDeb { get; set; }

            [Column("AccountIngFisticio")]
            [StringLength(129)]
            public string AccountIngFisticio { get; set; }

            [Column("AccountCosFisticio")]
            [StringLength(129)]
            public string AccountCosFisticio { get; set; }

            [Column("AccountElimicion")]
            [StringLength(129)]
            public string AccountElimicion { get; set; }

            [Column("DOCDESCR")]
            [StringLength(31)]
            public string DOCDESCR { get; set; }

            [Column("AADIMCHANEL")]
            [StringLength(31)]
            public string AADIMCHANEL { get; set; }

            [Column("AAPROJECT")]
            [StringLength(31)]
            public string AAPROJECT { get; set; }

            [Column("VALUEPROJECT")]
            [StringLength(31)]
            public string VALUEPROJECT { get; set; }

            [Column("DOCDATE")]
            public DateTime DOCDATE { get; set; }

            [Column("Total_Sales", TypeName = "numeric(19, 5)")]
            public decimal Total_Sales { get; set; }

            [Column("CURNCYID")]
            [StringLength(15)]
            public string CURNCYID { get; set; }

            [Column("RATETPID")]
            [StringLength(15)]
            public string RATETPID { get; set; }

            [Column("APPLDAMT", TypeName = "numeric(19, 5)")]
            public decimal APPLDAMT { get; set; }

            [Column("APFRDCDT")]
            public DateTime APFRDCDT { get; set; }

            [Column("APFRDCNM")]
            [StringLength(21)]
            public string APFRDCNM { get; set; }

            [Column("DATERECD")]
            public DateTime DATERECD { get; set; }

            [Column("DATEDONE")]
            public DateTime DATEDONE { get; set; }

            [Column("ERROR")]
            public short ERROR { get; set; }

            [Column("NUMOCPIS")]
            public short NUMOCPIS { get; set; }

            [Column("DEX_ROW_ID")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int DEX_ROW_ID { get; set; }
        }
    }

