class Rectangle
{
    private int Length;
    private int Width;
    private int Area;


    public void acceptdata()
    {
        Console.WriteLine("Enter Length Of A Rectangle");
        Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Width Of A Rectangle");
        Width = Convert.ToInt32(Console.ReadLine());
    }
    public void displaydata()
    {
        Area = Length * Width;
        Console.WriteLine("Area Of Rectangle Is : " + Area);
    }
}

class Result
{
    static void Main(string[] args)
    {
        Rectangle R1 = new Rectangle();
        //o1.Id = 10;
        //Console.WriteLine(o1.Id);
        R1.acceptdata();
        R1.displaydata();

    }

}