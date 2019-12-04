using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Personnel.BOL
{
    [Serializable]
    public class Employee : EntityBase
    {
        private string _lastName;
        private string _firstName;
        private DateTime _birthDate;
        private decimal _grossSalary;

        [Key]
        [Required(ErrorMessage ="ID is required")]
        [RegularExpression(@"^[0-9]{2}[A-Za-z]{3}[0-9]{2}\z", ErrorMessage = "ID must respect the format : 11ABC11")]
        public string AdherentID { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters in lenght")]
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [Required(ErrorMessage = "First name required")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "ID must respect the format : 11ABC11")]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [Required(ErrorMessage = "birthdate is required")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2001",
                ErrorMessage = "Value for {0} must be between {1:d} and {2:d}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal GrossSalary
        {
            get
            {
                return this._grossSalary;
            }
            set
            {
                if (_grossSalary != value)
                {
                    _grossSalary = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Establishment Establishment { get; set; }

        public Role Role { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal WorkQuantity { get; set; }

    }

    
}
