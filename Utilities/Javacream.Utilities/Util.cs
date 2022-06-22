namespace Javacream.Util
{

    public static class Configuration
    {
        private static readonly string FILE_NAME = "application.properties";
        private static Dictionary<string, string> _configuration;
        static Configuration()
        {
            _configuration = new Dictionary<string, string>();
            List<string> rows = new List<string>(File.ReadAllLines(FILE_NAME));
            List<string> properties = rows.FindAll(row => !row.StartsWith("#"));
            properties.ForEach(property => {
                string[] keyValue = property.Split("=");
                _configuration.Add(keyValue[0], keyValue[1]);
            });
        }
        public static string GetConfiguration(string key)
        {
            if (_configuration.ContainsKey(key))
            {
                return _configuration[key];
            }
            else
            {
                return key;
            }
        }
    }
    public struct Address
    {
        public string City { get; }
        public string Street { get; }
        public int PostalCode { get; }
        public Address(int postalCode, string city, string street)
        {
            this.PostalCode = postalCode;
            this.City = city;
            this.Street = street;
        }
    }

    public interface IAddressable
    {
        public Address GetAddressInfo();
    }
    public class AddressBook
    {
        private Dictionary<Address, List<IAddressable>> _book = new Dictionary<Address, List<IAddressable>>();
        /*
        //Potenziell sind hier Fehler möglich
        //Ich kann für eine falsche Adresse als ersten Parameter mitgeben
        //Das übergebene Objekt muss ja gar keine Address-Information enthalten
        public void AddAddressable(Address address, Object obj){
            this._book.Add(address, obj);
        } */

        public void AddAddressable(IAddressable addressable)
        {
            Address address = addressable.GetAddressInfo();
            List<IAddressable> addressableList;

            try
            {
                addressableList = this._book[address];
            }
            catch (Exception)
            {
                addressableList = new List<IAddressable>();
                this._book.Add(address, addressableList);
            }
            addressableList.Add(addressable);

        }
    }

    public static class TypeHelper
    { //Eine static class darf nur static Elemente enthalten. Für solche Helper natürlich durchaus sinnvoll. Ach ja: Console ist auch eine static class
        public static void PrintTypes(Object o)
        {
            string tab = "";
            Type? type = o.GetType();
            while (type != null)
            {
                Console.WriteLine(tab + type);
                tab += "...";
                type = type.BaseType;
            }
        }
    }
}