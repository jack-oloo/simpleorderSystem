using System.Windows.Forms;

namespace Order_System
{
    class Order
    {
        public string CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string OrderType { get; set; }

        public string SelectType { get; set; }

        public string DateOrdered { get; set; }

        public string Price { get; set; }

    }

    class Online : Order
    {
        public string WebSite { get; set; }
        public string Delivery { get; set; }

        

    }
}
