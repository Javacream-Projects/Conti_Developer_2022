using Javacream.Util;
namespace Javacream.BusinessObjects{
    public class University : IAddressable{

        public  Address GetAddressInfo()
        {
            return this.Address;
        }
        public string Name {get;}
        public Address Address {get;set;}

        public University(string name, Address address){
            this.Name = name;
            this.Address = address;
        } 
    }

    public class Company : IAddressable{

        public Address GetAddressInfo()
        {
            return this.MainAddress;
        }
        public string CompanyName {get; set;}
        private Dictionary<string, Address> addresses;
        public Company (string companyName, Address mainAddress){
            addresses = new Dictionary<string, Address>();
            addresses.Add("Main", mainAddress);
            this.CompanyName = companyName;
        }

        public Address MainAddress{
            get {
                return addresses["Main"];
            }

            set {
                addresses.Add("Main", value);
            }
        }

        public void AddDepartmentAddress(string department, Address address){
            addresses.Add(department, address);
        }
        public Address GetDepartmentAddress(string department){
            return addresses[department];
        }
        public void RemoveDepartmentAddress(string department){
            addresses.Remove(department);
        }
    }


}