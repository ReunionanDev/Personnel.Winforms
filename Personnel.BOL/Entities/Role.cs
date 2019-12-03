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
        private string _code;
        private string _label;
        private decimal _minimumSalary; //code decimal precision in DBContext

        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

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
    }
    
}
