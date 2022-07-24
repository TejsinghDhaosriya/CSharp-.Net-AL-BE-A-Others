namespace BindingApp
{
    public class DynamicEx
    { 
        
        public void varTypeCodeWillNotCompile()
        {
            // We are not able to assign string to var variable s , hence compiler is checking type at compile time
            // We will not able to compile the code 
            var s = 10;
            s = "ex";
            Console.WriteLine(s);
        }

        public void dynmaicType()
        {
            // dynamic create variable at run time because of that we will able to compile the code at compile time
            dynamic s = 10;
            s = "ex";
            Console.WriteLine(s);
        }
    }
}
