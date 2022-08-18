using ArticleForCarSalesProject.Cars;

class MainClass
{
    public static void Main(string[] args)
    {
        Audi audi = new Audi();
        Mercedes mercedes = new Mercedes();
        Ford ford = new Ford();

        audi.PrintToList();
        mercedes.PrintToList();
        ford.PrintToList();
    }
}