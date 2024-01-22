### Example of the Factory Method Design Pattern

This example of the factory method design pattern was develop using C# language.

This technique gives us a way to initialize the object in a more descriptive way. Sometimes, we would need to overload a constructor with other parameters in order to make it more descriptive, but when we are using the same parameter types, it’s just not allowed. Furthermore, the name of our constructor will always follow the name of the containing type, so not descriptive enough.

The technique consists of turning your constructor into a private method, so outsiders can’t call it, and then creating public static methods with descriptive names and parameters, returning your object built though your private constructor.

If you're interested in the udemy course by [Dmitri Nesteruk](https://www.udemy.com/user/dmitrinesteruk/) [link](https://www.udemy.com/course/design-patterns-csharp-dotnet).
