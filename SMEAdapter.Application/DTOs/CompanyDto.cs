using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMEAdapter.Application.DTOs
{
    public class CompanyDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Manufacturer Name is required")]
        public string? CompanyManufacturerName { get; set; }
        public CompanyAddressInfo? CompanyAddressInfo { get; set; } = new CompanyAddressInfo();
        public string? CompanyImageUrl { get; set; }


    }
    public class CompanyAddressInfo
    {

        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

    }
}
