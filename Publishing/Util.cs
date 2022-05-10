using Javacream.Books.API;
namespace Javacream.Util
{
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

    public interface IAddressable{
        public Address GetAddressInfo();
    }
    public class AddressBook{
        private Dictionary<Address, List<IAddressable>> _book = new Dictionary<Address, List<IAddressable>>();
        /*
        //Potenziell sind hier Fehler möglich
        //Ich kann für eine falsche Adresse als ersten Parameter mitgeben
        //Das übergebene Objekt muss ja gar keine Address-Information enthalten
        public void AddAddressable(Address address, Object obj){
            this._book.Add(address, obj);
        } */

        public void AddAddressable(IAddressable addressable){
            Address address = addressable.GetAddressInfo();
            List<IAddressable> addressableList;
            
            try{
             addressableList = this._book[address];
            }
            catch(Exception){
                addressableList = new List<IAddressable>();
                this._book.Add(address, addressableList);
            }
            addressableList.Add(addressable);
           
        }
    }

    public static class TypeHelper{ //Eine static class darf nur static Elemente enthalten. Für solche Helper natürlich durchaus sinnvoll. Ach ja: Console ist auch eine static class
        public static void PrintTypes(Object o){
            string tab = "";
            Type? type = o.GetType();
            while(type != null){
                Console.WriteLine(tab + type);
                tab += "...";
                type = type.BaseType;
            }
        }
    }
class BookUtils{
        public static bool CheckABook(Book b){
            return false;
        }
    }
}