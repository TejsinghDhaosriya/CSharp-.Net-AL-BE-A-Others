// See https://aka.ms/new-console-template for more information

using BindingApp;


// Calling  via Parent Ref

Console.WriteLine("Calling via Parent Ref");
Parent parent = new Child();
parent .message();


// Calling  via child Ref

Console.WriteLine("Calling via Child Ref");
Child child = new Child();
child.message();



// Dynamic Datatype Ex

DynamicEx d = new DynamicEx();
d.dynmaicType();  