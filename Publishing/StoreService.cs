namespace Javacream.Store{
    public class StoreService{
        private int _stock = 42;

        public int GetStock(string category, Object item){
            return _stock;
        }
    }
}