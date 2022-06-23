using Javacream.Store.API;
namespace Javacream.Store.Impl{
    public class StoreService : IStoreService{
        public class StoreEntry{
            public StoreEntry(string cat, Object item){
                if (cat == null){
                    throw new ArgumentException("null category");
                }
                if (item == null){
                    throw new ArgumentException("null item");
                }
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
            int stock = 0;
            bool hasStock = _stock.TryGetValue(new StoreEntry(category, item), out stock);
            if (hasStock)
            {
                return stock;
            }else
            {
                return 0;
            }
            }
        

        public void SetStock(string category, Object item, int stock){
            if (stock < 0){
                throw new ArgumentException("stock was null");
            }
            StoreEntry entry = new StoreEntry(category, item);
            _stock.Remove(entry);
            _stock.Add(entry, stock);
        }
    }
}