/*class Program
{
    static void Main(string[] args)
    {
        /// <summary>  
        /// Example of var type  
        /// </summary>              
        // assign a number value  
        var varItem = 100;
        //does not require explicit type casting for any operation at runtime  
        varItem = varItem + 100;
        //varItem ="EDUDOTNET";//We cannot change the type of these variables at runtime.   

        /// <summary>  
        /// Example of object type  
        /// </summary>  
        // assign a number value  
        object objItem = 100;
        //require explicit type casting for any operation at runtime  
        objItem = (int)objItem + 100;
        //object type does not allows you to perform any operations   
        //objItem += 100;   
        //[Error: Operator '+=' cannot be applied to operands of type 'object' ana 'int']  
        objItem = "EDUDOTNET";

        /// <summary>  
        /// Example of dynamic type  
        /// </summary>  
        // assign a number value  
        dynamic dynItem = 100;
        //does not require explicit type casting for any operation at runtime  
        dynItem = dynItem + 100;
        // dynamic type allows you to perform any operations  
        dynItem += 100;
        dynItem = "EDUDOTNET";
        Console.WriteLine(dynItem);
        Console.WriteLine(varItem);
        Console.WriteLine(objItem);
    }
}  */

class CallByValueMethod
{
    public void ShowValue(int value)
    {
        value *= value;
        Console.WriteLine("Value calling method:" + value);
    }

    static void Main(string[] args)
    {
        int value = 10;
        var p = new CallByValueMethod();
        Console.WriteLine("Value before calling method:" + value);
        p.ShowValue(value);
        Console.WriteLine("Value after calling method:" + value);
        Console.ReadLine();
    }
}