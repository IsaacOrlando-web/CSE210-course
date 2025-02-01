namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer = new Customer();
        private int _ShippingCost = 0;

        //Getter
        public List<Product> GetProducts()
        {
            return _products;
        }

        public Customer GetCustomer()
        {
            return _customer;
        }
        private int GetShippingCost()
        {
            return _ShippingCost;
        }

        //Set Customer
        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }

        // Constructor por defecto
        public Order()
        {
            _products = new List<Product>();  // Inicializa la lista de productos
            _customer = new Customer();        // Inicializa el cliente
            _ShippingCost = 0;                // Inicializa el costo de envío
        }

        // Constructor con parámetros
        public Order(Customer customer, List<Product> products, int shippingCost)
        {
            this._customer = customer;         // Asigna el cliente proporcionado
            _products = products ?? new List<Product>(); // Asigna la lista de productos o crea una nueva si es nula
            _ShippingCost = shippingCost;     // Asigna el costo de envío
        }
        // Constructor con parámetros solo para el cliente y productos (costo de envío predeterminado)
        public Order(Customer customer, List<Product> products)
        {
            this._customer = customer; // Asigna el cliente proporcionado
            _products = products ?? new List<Product>(); // Asigna la lista de productos o crea una nueva si es nula
            _ShippingCost = 0; // Establece el costo de envío como 0 por defecto
        }

        //Methods
        public void AddProdutc(string Name, string id, double price, int quantity)
        {
            Product NewProduct = new Product(Name,id, price, quantity);
            _products.Add(NewProduct);
        }

        public int ShippingCost()
        {
            if(_customer.USAorOutside() == true)
            {
                _ShippingCost  = 5;
            }else{
                _ShippingCost = 35;
            }
            return _ShippingCost;
        }

        public string PackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
            }
            return label;
        }
        

        public double TotalPrice()
        {
            double sum = 0;
            foreach (Product product in _products)
            {
                sum += product.TotalCost();
            }

            return sum + ShippingCost();
        }

        public string ShippingLabel()
        {
            return $"Customer Name: {_customer.GetName()}\nAddress: {_customer.GetAllAddress()}";
        }

    }
}