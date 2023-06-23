using Microsoft.AspNetCore.Mvc.Rendering;

namespace CafeManagement.Web.Models
{
    public class SettingsUpdateViewModel
    {
        public List<CompanyListModel> CompanyList { get; set; }
        public List<SelectListItem> SelectListItems { get; set; }

        public bool IsMernis { get; set; }
        public int CompanyId { get; set; }
    }
}
