namespace OnlineOrdering
{
    public class Product
    {
        private string _Name;
        private string _ProductId;
        private double _Price;
        private int _Quanity;

        //Getters
        public string GetName()
        {
            return _Name;
        }

        public string GetProductId()
        {
            return _ProductId;
        }

        public double GetPrice()
        {
            return _Price;
        }

        public int GetQuantity()
        {
            return _Quanity;
        }

        //Setters
        public void SetName(string name)
        {
            _Name = name;
        }

        public void SetProductID(string id)
        {
            _ProductId = id;
        }

        public void SetPrice(double price)
        {
            _Price = price;
        }

        public void SetQuantity(int quality)
        {
            _Quanity = quality;
        }

        //Constructors
        public Product(string name, string id, double price, int quality)
        {
            _Name = name;
            _ProductId = id;
            _Price = price;
            _Quanity = quality;
        }

        //Method of total Cost
        public double TotalCost()
        {
            return GetPrice() * GetQuantity();
        }
    }
}