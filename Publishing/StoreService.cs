using Javacream.IsbnGenerator;
namespace Javacream.Store{
    public class StoreService{
        private Dictionary<string, Dictionary<Object, int>> _stock;
        
        public StoreService(){
         _stock = new Dictionary<string, Dictionary<Object, int>>();
         var itemDict = new Dictionary<Object, int>();
         _stock.Add("books", itemDict);
         itemDict.Add(new Isbn(1,2,3,1), 42);
         itemDict.Add(new Isbn(1,2,3,3), 10);
        }

        public int GetStock(string category, Object item){
            try{
                Dictionary<Object, int> itemDictionary = _stock[category];
                int stock = itemDictionary[item];
                return stock;
            }
            catch(Exception){
                return 0;
            }
        }
    }
}