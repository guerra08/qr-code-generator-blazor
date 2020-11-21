using System.ComponentModel.DataAnnotations;

namespace QRCodeGenerator.Models
{
    public class FormModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Twitter { get; set; }
        [Required]
        public string Github { get; set; }
        
    }
}
