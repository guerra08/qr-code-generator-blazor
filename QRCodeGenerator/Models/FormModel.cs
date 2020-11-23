using System.ComponentModel.DataAnnotations;

namespace QRCodeGenerator.Models
{
    public class FormModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }

        public override string ToString()
        {
            return Name + ": " + Content + "\n";
        }

    }
}
