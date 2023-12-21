using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
namespace DataGrid.Pages
{
    //public class OrderDetails
    //{
    //    public static List<OrderDetails> order = new List<OrderDetails>();

    //    public OrderDetails(int OrderID, string CustomerId, int EmployeeId, double Freight,
    //        DateTime OrderDate, string ShipCity)
    //    {
    //        this.OrderID = OrderID;
    //        this.CustomerID = CustomerId;
    //        this.EmployeeID = EmployeeId;
    //        this.Freight = Freight;
    //        this.ShipCity = ShipCity;
    //        this.OrderDate = OrderDate;
    //    }

    //    public static List<OrderDetails> GetAllRecords()
    //    {
    //        if (order.Count() == 0)
    //        {
    //            int code = 100;
    //            for (int i = 1; i < 10; i++)
    //            {
    //                order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
    //                order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
    //                order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
    //                order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
    //                order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
    //                order.Add(new OrderDetails(code + 6, "Vinoth", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Berlin"));
    //                code += 5;
    //            }
    //        }
    //        return order;
    //    }

    //    public int OrderID { get; set; }
    //    public string CustomerID { get; set; }
    //    public int? EmployeeID { get; set; }
    //    public double? Freight { get; set; }
    //    public string ShipCity { get; set; }
    //    public DateTime OrderDate { get; set; }

    //}
    public class DynamicDictionary : DynamicObject
    {
        public Dictionary<string, object> OrderDictionary { get; set; } = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            string name = binder.Name;
            return OrderDictionary.TryGetValue(name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            OrderDictionary[binder.Name] = value; 
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return OrderDictionary.Keys;
        }
    }
    public class IndexModel : PageModel
    { 
        public static List<DynamicDictionary>DynamicOrders { get; set; } = new List<DynamicDictionary>();
        public void OnGet()
        {
            DynamicOrders = Enumerable.Range(1, 10).Select((x) =>
            {
                dynamic dynamicObj = new DynamicDictionary();
                dynamicObj.OrderID = 1000 + x;
                dynamicObj.CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID", "Thomp" })[new Random().Next(5)];
                dynamicObj.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
                dynamicObj.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
                dynamicObj.ShipCity = (new string[] { "Berlin", "Madrid", "Cholchester", "Marseille", "Tsawassen", "Berlin" })[new Random().Next(5)];
                return dynamicObj;
            }).Cast<DynamicDictionary>().ToList<DynamicDictionary>();
        }
    }
}