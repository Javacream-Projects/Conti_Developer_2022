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
}