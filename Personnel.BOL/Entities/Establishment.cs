using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Personnel.Services;

namespace Personnel.BOL
{
    [Serializable]
    public class Establishment : EntityBase
    {
        [Key]
        [Required(ErrorMessage = "Siret is required")]
        [SiretValidator(ErrorMessage = "Siret number not correct")]
        [MaxLength(14, ErrorMessage = "Siret must have 14 digits")]
        public string Siret { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{5}\z", ErrorMessage = "Postcode incorrect")]
        public int PostCode { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
