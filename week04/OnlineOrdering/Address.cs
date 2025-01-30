namespace OnlineOrdering
{
    public class Address
    {
        private string _StreetAddress;
        private string _City;
        private string _StateProvince;
        private string _country;

        //Getting Values
        public string GetStreetAddress()
        {
            return _StreetAddress;
        }
        public string GetCity()
        {
            return _City;
        }
        public string GetStateProvince()
        {
            return _StateProvince;
        }
        public string GetCountry()
        {
            return _country;
        }

        //Setting values
        public void SetStreetAddress(string street)
        {
            _StreetAddress = street;
        }
        public void SetCity(string city)
        {
            _City = city;
        } 
        public void SetStateProvince(string state){
            _StateProvince = state;
        }
        public void SetCountry(string country)
        {
            _country = country;
        } 

        //Constructors
        public Address()
        {
            _StreetAddress = "";
            _City = "";
            _StateProvince = "";
            _country = "";
        }

        public Address(string street, string city, string state,string country)
        {
            _StreetAddress = street;
            _City = city;
            _StateProvince = state;
            _country = country;
        }

        //Methods

        //Wheter it's in the Usa Or Not
        public bool UsaOrNot(string country)
        {
            if(country == "USA")
            {
                return true;//Yes, is in USA
            }
            else{
                return false;//No, it's outside
            }
        }

        //Show All the information
        public string DisplayAllInfo()
        {
            return  $"{GetStreetAddress()}/{GetCity()}/{GetStateProvince()}/{GetCountry()}";
        }
    }
}