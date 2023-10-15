using System.ComponentModel.DataAnnotations;

namespace azuretest.Models;
public class Student
{
    [Key]
    public int ID { get; set; }
    [Required]
    public string? Name { get; set; }
    [StringLength(100), DataType(DataType.EmailAddress), RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Please enter a valid Email")]
    public string? Email { get; set; }
    [StringLength(10), Display(Name = "Phone Number"), DataType(DataType.PhoneNumber), RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter a valid 10 digit phone number"), DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
    public string? Phone { get; set; }
   
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }

}

