namespace Javacream.Util{
    public class Address{
        public string City {get; set;}
        public string Street {get; set;}
        public int PostalCode {get; set;}
        public Address(int postalCode, string city, string street){
            this.PostalCode = postalCode;
            this.City = city;
            this.Street = street;
        }
    }
}