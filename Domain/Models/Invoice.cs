using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models
{
    public class Invoice
{
    public Invoice() {
        InvoiceDetails = new List<InvoiceDetails>();
    }

    public int InvoiceID { get; set; }

    [DisplayName("Numero Factura")]
    public int InvoiceNumber { get; set; }

    public bool IsProposal {
        get {
            return (this.InvoiceNumber == 0);
        }
    }

    public int CustomerID { get; set; }
    public virtual Customer Customer { get; set; }

    public string Name { get; set; }

    [DisplayName("Observaciones")]
    [Required]
    public string Notes { get; set; }

    [DisplayName("Detalle Orden")]
    public string ProposalDetails { get; set; }

    [DisplayName("Created")]
    public DateTime TimeStamp { get; set; }

    [DisplayName("Due Date")]
    public DateTime DueDate { get; set; }

    [DisplayName("IVA")]
    [Range(0.00, 100.0, ErrorMessage = "Valor debe estar entre un % y 100")]
    public decimal AdvancePaymentTax { get; set; } 

    public bool Paid { get; set; }

    public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }

    #region Calculated fields
    public decimal VATAmount  {
        get {
            return this.TotalWithVAT - this.NetTotal;
        }
    }

    /// <summary>
    /// Total before TAX
    /// </summary>
    public decimal NetTotal
    {
        get {
            if (InvoiceDetails == null)
                return 0;

            return InvoiceDetails.Sum(i => i.Total);
        }
    }

    public decimal AdvancePaymentTaxAmount
    {
        get
        {
            if (InvoiceDetails == null)
                return 0;

            return NetTotal ;
        }
    }

    /// <summary>
    /// Total with tax
    /// </summary>
    public decimal TotalWithVAT
    {
        get
        {
            if (InvoiceDetails == null)
                return 0;

            return InvoiceDetails.Sum(i => i.TotalPlusVAT);
        }
    }

    /// <summary>
    /// Total with VAT minus advanced tax payment 
    /// </summary>
    public decimal TotalToPay {
        get {
            return TotalWithVAT - 0;
        }
    }
    #endregion
}
}