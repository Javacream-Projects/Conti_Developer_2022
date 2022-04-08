void StringExample(){
    string value = "initial";
    Console.WriteLine("Before: {0}", value);
    StringExampleFunction(value);
    Console.WriteLine("After: {0}", value);
}

void StringExampleFunction(string s){
    Console.WriteLine("In StringExampleFunction: {0}", s);
    s = "changed";
    Console.WriteLine("In StringExampleFunction after change: {0}", s);
}

void StringArrayExample(){
    string[] values = {"initial1", "initial2"};
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
    array = new string[]{"changed1", "changed2"};
    foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction after change: {0}", s);
    }
}

void StringArrayExample2(){
    string[] values = {"initial1", "initial2"};
    foreach(string value in values)
    {
        Console.WriteLine("    Before: {0}", value);
    }
    StringArrayExampleFunction2(values);
    foreach(string value in values)
    {
        Console.WriteLine("    After: {0}", value);
    }
}

void StringArrayExampleFunction2(string[] array){
    foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction: {0}", s);
    }
    //array = new string[]{"changed1", "changed2"};
    array[0] = "changed1";
    foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction after change: {0}", s);
    }
}

void SimpleStringArrayExample()
{
    string[] array1 = {"initial1", "initial2"};
    string[] array2 = array1;
    array1[0] = "changed1";
    Console.WriteLine(array2[0]);

}

void StringRefExample(){
    string value = "initial";
    Console.WriteLine("Before: {0}", value);
    StringRefExampleFunction(ref value);
    Console.WriteLine("After: {0}", value);
}

void StringRefExampleFunction(ref string s){
    Console.WriteLine("In StringExampleFunction: {0}", s);
    s = "changed";
    Console.WriteLine("In StringExampleFunction after change: {0}", s);
}

void StringArrayRefExample(){
    string[] values = {"initial1", "initial2"};
    foreach(string value in values)
    {
        Console.WriteLine("    Before: {0}", value);
    }
    StringArrayRefExampleFunction(ref values);
    foreach(string value in values)
    {
        Console.WriteLine("    After: {0}", value);
    }
}

void StringArrayRefExampleFunction(ref string[] array){
    foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction: {0}", s);
    }
    array = new string[]{"changed1", "changed2"};
    foreach(string s in array)
    {
        Console.WriteLine("    In StringArrayExampleFunction after change: {0}", s);
    }
}

//StringExample();
//StringArrayExample();
//StringArrayExample2();
//SimpleStringArrayExample();
//StringRefExample();
StringArrayRefExample();