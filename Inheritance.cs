
namespace BindingApp
{
    public class Parent
    {

        public virtual  void message()
        {
            Console.WriteLine("I am Parent Class");
        }
    }
    public class Child:Parent
    {

        public override  void message()
        {
          base.message();
            Console.WriteLine("I am Child Class");
        }
    }
}
