namespace CafeManagement.Web.Models
{


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DatumCustomerList
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string identityNumber { get; set; }
        public DateTime birthDate { get; set; }
        public string companyId { get; set; }
    }

    public class CustomerListModel
    {
        public List<DatumCustomerList> data { get; set; }
        public object errors { get; set; }
    }



}
