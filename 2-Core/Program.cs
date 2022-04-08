void StringExample(){
    string value = "initial";
    Console.WriteLine("Before: {0}", value);
    StringExampleFunction(value);
    Console.WriteLine("After: {0}", value);
}

void StringExampleFunction(string s){
    Console.WriteLine("In StringExampleFunction: {0}", s);

}

void StringArrayExample(){
    string[] values = {"element1", "element2"};
    foreach(string value in values)
    {
        Console.WriteLine("    Before: {0}", value);
    }
    StringArrayExampleFunction(values);
    foreach(string value in values)
    {
        Console.WriteLine("    After: {0}", value);
    }
}

void StringArrayExampleFunction(string[] array){
        foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction: {0}", s);
    }

}

//StringExample();
StringArrayExample();