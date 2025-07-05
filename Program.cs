namespace MethodHiding;

public class Program
{
    public static void Main(string[] args)
    {
        DerivedClass dcObj = new();
        dcObj.Message();

        // Way 1 to call method of base class
        BaseClass bcObj = dcObj;
        bcObj.Message();

        // Way 2 to call method of base class
        ((BaseClass)dcObj).Message();
    }
}