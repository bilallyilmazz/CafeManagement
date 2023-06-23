using Microsoft.AspNetCore.Mvc.Rendering;

namespace CafeManagement.Web.Models
{
    public class CustomerCreateViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompanyId { get; set; }

        public List<SelectListItem> SelectListItems { get; set; }

    }
}
