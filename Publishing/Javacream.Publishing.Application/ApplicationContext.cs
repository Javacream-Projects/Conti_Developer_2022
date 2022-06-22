using Javacream.IsbnGenerator.API;
using Javacream.IsbnGenerator.Impl;
using Javacream.Store.API;
using Javacream.Store.Impl;
using Javacream.Books.API;
using Javacream.Books.Impl;

public static class ApplicationContext{
    static ApplicationContext(){
        _isbnService = new RandomIsbnService();
        _storeService = new StoreService();
        _booksService = new BooksService(_isbnService, _storeService);
    }
    private static IIsbnService _isbnService;
    public static IIsbnService IIsbnService(){
        return _isbnService;
    }

    private static IStoreService _storeService;

    public static IStoreService IStoreService(){
        return _storeService;
    }  
    private static IBooksService _booksService;

    public static IBooksService IBooksService(){
        return _booksService;
    }  

}