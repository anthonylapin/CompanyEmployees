using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulationDto
    {
        [Required(ErrorMessage = "Name field is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name field is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address field is a required field.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Country field is a required field")]
        [MaxLength(45, ErrorMessage = "Maximum length for the Country field is 45 characters.")]
        public string Country { get; set; }

        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
