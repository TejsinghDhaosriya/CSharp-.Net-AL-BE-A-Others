#####  CASE 1 :Method Hiding use new keyword and not use virtual/override keyword
```
    Calling via Parent Ref , parent message is called
    Parent parent = new Child();
    I am Parent Class
   
   
    Calling via Child Ref, child message is called
    Child child = new Child();
    I am Child Class

    Method Hiding :-
     hide the methods of the base class from derived class, this concept is known as Method Hiding. It is also known as Method Shadowing.
     In method hiding, you can hide the implementation of the methods of a base class from the derived class using the new keyword. Or in other words, in method hiding, you can redefine the method of the base class in the derived class by using the new keyword.

     We can also remove `new` keyword in method hiding , compiler will throw a warning
```


#####  CASE 2 : use virtual/override keyword
```
    Calling via Parent Ref , parent message is called
    Parent parent = new Child();
    I am Child Class
   
   
    Calling via Child Ref, child message is called
    Child child = new Child();
    I am Child Class

```


##### Case 3: If we used child class ref for parent class it will throw an compiler error
```
Child child = new Parent();
   child.message();

prog.cs(17,24): error CS1519: Unexpected symbol `void' in class, struct, or interface member declaration
Compilation failed: 1 error(s), 0 warnings
```

#### Calling parent class method
```
How to call a hidden method?
In method hiding, you can also call the hidden method of the base class in the derived class using three different ways and the ways are:

1. By using the base keyword you can call the hidden method of the base class in your derived class shown in the below example:
Example:
 public new void message() 
    {
          
        // Calling the hidden method of the
        // base class in a derived class
        // Using base keyword
        base.message();
     }
2.By casting the derived class type to base class type you can invoke the hidden method. As shown in the below example. We know that in inheritance the derived class has all the capabilities of the base class so we can easily cast the object of a derived class into base class type.
Example:

// Creating the object of the derived class
        // Invoking the hidden method
        // By type casting
        ((Parent)child).message();


3. Instead of using derived class reference variable we use the parent class reference variable for calling the hidden method. It is similar to the above way of calling a hidden method. Here we also type case the object of the derived class in a different syntax.

```# CSharp-.Net-AL-BE-A-Others
