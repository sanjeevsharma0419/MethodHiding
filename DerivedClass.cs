namespace MethodHiding;

public class DerivedClass : BaseClass
{
    public new void Message()
    {
        Console.WriteLine("This messaege is from DERIVED class");
    }
}