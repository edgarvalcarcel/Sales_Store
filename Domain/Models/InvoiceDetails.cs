using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Domain.Models
{
    public class InvoiceDetails
    {
        public int InvoiceDetailsID { get; set; }

        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }

        [Required]
        [DisplayName("Producto")]
        public string Article { get; set; }

        [Range(-100000, 100000, ErrorMessage = "Cantidad debe estar entre 1 y 100000")]
        [DisplayName("Cantidad")]
        public int Qty { get; set; }

        [Range(0.01, 999999999, ErrorMessage = "Precio debe estar entre 0.01 y 999999999")]
        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [Range(0.00, 100, ErrorMessage = "IVA debe estar entre 1% y 16")]
        [DisplayName("IVA")]
        public decimal VAT { get; set; }

        [DisplayName("Created")]
        public DateTime TimeStamp { get; set; }

        #region Calculated fields
        public decimal Total
        {
            get
            {
                return Qty * Price;
            }
        }

        public decimal VATAmount
        {
            get
            {
                return TotalPlusVAT - Total;
            }
        }

        public decimal TotalPlusVAT
        {
            get
            {
                return Total * (1 + VAT / 100);
            }
        }
        #endregion
    }
}