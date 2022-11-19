using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Domain.Models
{
    public class Customer {
 
    public int? Id {get;set;}

    [Required(ErrorMessage = "Nombres y Apellidos obligatorios")]
    [DisplayName("Nombres y Apellidos")]
    public string Name { get; set; }

    [DisplayName("Documento")]
    [Required(ErrorMessage = "Documento obligatorio")]
    public string CompanyNumber { get; set; }

    [Required(ErrorMessage = "Direccion obligatoria")]
    [DisplayName("Direccion")]
    public string Address { get; set; }

      [Required(ErrorMessage = "Ciudad obligatoria")]
      [DisplayName("Ciudad")]
    public string City { get; set; }

     [Required(ErrorMessage = "Telefono obligatorio")]
    [DisplayName("Telefono")]
    public string Phone1 { get; set; }

    [DisplayName("Celular")]
    public string Phone2 { get; set; }

    [Required(ErrorMessage = "Email required")]
    [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Wrong email format")]
    [DisplayName("Correo Electrónico")]
    public string Email { get; set; }

     [DisplayName("Observaciones")]
    public string Notes { get;set; }
    
    public virtual ICollection<Invoice> Invoices { get; set; }
}
}