using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
    
namespace azuretest.Models;
public class ApplicationUser : IdentityUser
{
  
    
    [Required]
    public string? Name { get; set; }
  
    
    [StringLength(10), Display(Name = "Phone Number"), DataType(DataType.PhoneNumber), RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter a valid 10 digit phone number"), DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
    public string? Phone { get; set; }
    
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
}

