using System.ComponentModel.DataAnnotations;

namespace SignalIR.EntityLayer.Entities
{
    public class Category
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        //tablo birleştirme
        public List<Product> Products { get; set; }
    }
}
