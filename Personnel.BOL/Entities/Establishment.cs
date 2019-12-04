﻿using System;
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
    }
}
