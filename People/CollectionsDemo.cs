using Javacream.People;
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

    }
}