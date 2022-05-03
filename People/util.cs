namespace Javacream.Util{
    public struct Address{
        public string City {get;}
        public string Street {get;}
        public int PostalCode {get;}
        public Address(int postalCode, string city, string street){
            this.PostalCode = postalCode;
            this.City = city;
            this.Street = street;
        }
    }
}