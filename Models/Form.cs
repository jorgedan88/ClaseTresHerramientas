using System.ComponentModel.DataAnnotations;

public class Form
{
    [Required ]
    [Display (Name = "Correos")]
    public string Mail { get; set; }
    public string Password { get; set; }
}