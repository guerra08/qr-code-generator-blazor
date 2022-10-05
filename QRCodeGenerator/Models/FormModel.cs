using System.ComponentModel.DataAnnotations;

namespace QRCodeGenerator.Models
{
    public class FormModel
    {
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }

    }
}
