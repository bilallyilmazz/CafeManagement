namespace CafeManagement.Web.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CompanyListModel
    {
        public List<Datum> data { get; set; }
        public object errors { get; set; }
    }


}
