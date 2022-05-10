using Javacream.IsbnGenerator;
using Javacream.Store;
using Javacream.Books;

public static class ApplicationContext{
    public static IIsbnService _isbnService = new IsbnService();
    public static IIsbnService IIsbnService(){
        return _isbnService;
    }

    public static IStoreService _storeService = new StoreService();

    public static IStoreService IStoreService(){
        return _storeService;
    }  
    public static IBooksService _booksService = new BooksService();

    public static IBooksService IBooksService(){
        return _booksService;
    }  

}