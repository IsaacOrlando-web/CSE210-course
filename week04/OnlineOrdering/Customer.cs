namespace OnlineOrdering
{
    public class Customer
    {
        private string _Name;
        private Address _address = new Address();

        public string GetName()
        {
            return _Name;
        } 

        public string GetAllAddress()
        {
            return _address.DisplayAllInfo();
        }

        //Set Name
        public void SetName(string name)
        {
            _Name = name;
        }

        //Set the Address
        public void SetAddress(string street, string city, string state, string country)
        {
            _address.SetStreetAddress(street);
            _address.SetCity(city);
            _address.SetStateProvince(state);
            _address.SetCountry(country);
        }

        //Constructor
        public Customer()
        {
            _Name = "Sin nombre";
            _address = new Address();
        }

        //Return Wheter they live in the USA or Not
        public bool USAorOutside()
        {
            return _address.UsaOrNot(_address.GetCountry()); //Call the address Class
        }
    }
}