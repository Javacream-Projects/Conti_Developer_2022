using Javacream.Store.API;
namespace Javacream.Store.Impl{
    public class StoreService : IStoreService{
        public class StoreEntry{
            public StoreEntry(string cat, Object item){
                this._category = cat;
                this._item = item;
            }
            private string _category;
            private Object _item;

            public override int GetHashCode()
            {
                return _category.GetHashCode() + _item.GetHashCode();
            }

            public override bool Equals(object? obj)
            {
                if (obj != null){
                StoreEntry se = (StoreEntry) obj;
                return se._item.Equals(this._item) && se._category.Equals(this._category);
                }
                else{
                    return false;
                }
            }
        }
        public Dictionary<StoreEntry, int> _stock;
        
        public StoreService(){
         _stock = new Dictionary<StoreEntry, int>();
        }

        public int GetStock(string category, Object item){
            try{
                int stock = _stock[new StoreEntry(category, item)];
                return stock;
            }
            catch(Exception){
                return 0;
            }
        }

        public void SetStock(string category, Object item, int stock){
            StoreEntry entry = new StoreEntry(category, item);
            _stock.Remove(entry);
            _stock.Add(entry, stock);
        }
    }
}