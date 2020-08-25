using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module7.Models
{
    public class SomeModel
    {
        public bool SomeBooleanProperty { get; set; }
        public DateTime? SomeDateTimeProperty { get; set; }

        [Range(5, 10, ErrorMessage = "Value must be between 5 and 10.")] 
        [Required(ErrorMessage = "Please enter a value")]
        public int SomeIntegerProperty { get; set; }

        public decimal SomeDecimalProperty { get; set; }
        public string SomeStringProperty { get; set; }
        public string SomeMultiLineStringProperty { get; set; }
        public SomeStateEnum SomeSelectProperty { get; set; } = SomeStateEnum.Active;
    }

    public enum SomeStateEnum
    {
        Pending,
        Active,
        Suspended
    }


}
