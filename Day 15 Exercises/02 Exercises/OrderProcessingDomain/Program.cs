namespace OrderProcessingDomain
{
    class Order
    {
        bool applyDiscount = false;
        public DateTime OrderDate { get; set; }
        private string orderstatus;

        public string OrderStatus
        {
            get { return orderstatus; }
            set { orderstatus = value; }
        }


        private int _orderId;  // private non-static instance field

        public int OrderId // readonly property
        {
            get { return _orderId; }
            
        }

        private int _totalAmount=0;

        public int TotalAmount // readonly property
        {
            get { 
                if (_totalAmount > 0)
                    return _totalAmount;
                else
                { return 0; } 
            } 
        }
         

        private string _customerName;       

        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { _customerName = "Entered name is invalid"; }
                else
                { _customerName = value; }
            }
        }


        public Order() //default constructor
        {
            OrderDate = DateTime.Now;
            OrderStatus="New";
            _customerName="Guest Customer";

        }

        public Order(int orderid,string  name) //parameterized constructor
        {
            _orderId=orderid;
            CustomerName=name;
            OrderStatus = "New";
            OrderDate = DateTime.Now;
        }

        public void AddItem(decimal price)
        {
            _totalAmount= _totalAmount + (int)price;
        }

        public void ApplyDiscount(decimal percentage)
        {
            
            if (percentage > 1 && percentage < 30 && applyDiscount==false)
            {
                _totalAmount = _totalAmount - (_totalAmount * (int)percentage / 100);
                applyDiscount = true;
            }
            
        }

        public string GetOrderSummary()
        {
            return $" Order Id: {_orderId}\n Customer: {_customerName}\n " +
                    $"Total Amount: {_totalAmount}\n Status: {OrderStatus}" +
                    $"\n Date: {OrderDate}";
        }

        

     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("ORDER 1 ......");
            Order o4 = new Order(102,"   ");

           o4.AddItem(500);
           o4.AddItem(300);
           o4.ApplyDiscount(10);


            Console.WriteLine(o4.GetOrderSummary());

            Console.WriteLine("\nORDER 2.....");
            Order o2 = new Order();
            o2.AddItem(1500);
            o2.AddItem(300);
            o2.ApplyDiscount(20);
            o2.ApplyDiscount(5);
            Console.WriteLine(o2.GetOrderSummary());





        }
    }
}
