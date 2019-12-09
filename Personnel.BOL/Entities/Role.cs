using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Personnel.BOL
{
    [Serializable]
    public class Role : EntityBase
    {
        private string _id;
        private string _label;
        private decimal _minimumSalary;

        [Key]
        [Required]
        [RegularExpression(@"^[A-Za-z]{2}\z", ErrorMessage = "Id must have 2 alpha characters")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [Required]
        [MaxLength(75, ErrorMessage = "75 characters maximum")]
        public string Label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }

        [Required]
        public decimal MinimumSalary
        {
            get
            {
                return this._minimumSalary;
            }
            set
            {
                this._minimumSalary = value;
            }
        }

        public List<Employee> Employees { get; set; }
    }
}
