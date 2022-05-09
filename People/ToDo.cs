namespace JavacreamToDo{

    public class ToDoItem{
        public string Description {get;}
        public ToDoStatus Status {get; set;}

        public ToDoItem(string description, ToDoStatus status){
            this.Description = description;
            this.Status = status;
        }
        public ToDoItem(string description){
            this.Description = description;
            this.Status = ToDoStatus.Open;
        }
    }

    public enum ToDoStatus{
        Open, Closed, In_Progress

    }

    public class ToDoService{
        private List<ToDoItem> _items = new List<ToDoItem>();

        public int AddToDoItem(ToDoItem item){
            _items.Add(item);
            return _items.Count - 1;
        }
        public void ChangeStatus(int itemPosition, ToDoStatus status){
            if (itemPosition < 0 && itemPosition >= _items.Count){
                throw new Exception("illegal itemPosition");
            }
            ToDoItem item = _items[itemPosition];
            item.Status = status;
        }
        public List<ToDoItem> GetToDoItems(){
            return this._items;
        }

    }
}