using Javacream.People;
using Javacream.Books;
namespace Javacream.CollectionsDemo{
    public static class CollectionsDemo{
        public static void SetDemo(){
            //Zu lesen als "List of string
            HashSet<string> names = new HashSet<string>();

            names.Add("Hugo");
            names.Add("Fritz");
            names.Add("Emil");
            names.Add("Fritz");

            foreach(string name in names){
                Console.WriteLine(name);
            }

            //Console.WriteLine(names[1]); //Compiler-Fehler, ein Set hat keinen Index
            //Add, Remove, Contains, Clear, Count
            //names.


            
        }
        public static void ListDemo(){
            //Zu lesen als "List of string
            List<string> names = new List<string>();
            List<Person> people = new List<Person>();
            List<Object> generic = new List<Object>();

            names.Add("Hugo");
            names.Add("Fritz");
            names.Add("Emil");
            names.Add("Fritz");

            foreach(string name in names){
                Console.WriteLine(name);
            }

            //Console.WriteLine(names[1]);
            //Add, Remove, Contains, Clear, Count
            //names.


        }

        public static void DictionaryDemo(){
            Dictionary<int, string> postalCodeToCity = new Dictionary<int, string>();
            postalCodeToCity.Add(81371, "München");
            postalCodeToCity.Add(30333, "Berlin");
            postalCodeToCity.Add(40444, "Hamburg");

            foreach(int postalCode in postalCodeToCity.Keys){
                Console.WriteLine(postalCode + " " + postalCodeToCity[postalCode]);
            }

            Console.WriteLine(postalCodeToCity[81371]);

        }


        public static void TestHashCodeAndEquals(){
            Isbn isbn1 = new Isbn(1,2,3,4);
            Isbn isbn2 = new Isbn(1,2,3,5);
            Isbn isbn3 = new Isbn(1,2,3,4);

            Console.WriteLine(isbn1 == isbn2);
            Console.WriteLine(isbn1 == isbn3);
            Console.WriteLine(isbn1.GetHashCode());
            Console.WriteLine(isbn3.GetHashCode());

            HashSet<Isbn> isbns = new HashSet<Isbn>();
            isbns.Add(isbn1);
            isbns.Add(isbn2);
            isbns.Add(isbn3);
            Console.WriteLine(isbns.Count);

        }
    }

}