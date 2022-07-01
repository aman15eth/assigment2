// See https://aka.ms/new-console-template for more information
using circlearea;


circ c= new circ();
Console.WriteLine("please enter raduis");
c.raduis = Convert.ToDouble(Console.ReadLine());


    
Console.WriteLine("your circle  area is" +c.Area());
Console.WriteLine("please enter length");
c.len = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("your square  area is" + c.area1());







class circ : shape
{
    public double raduis { get; set; }
    public readonly double pi = 3.14;

    public override double Area()
    {
        return pi * raduis * raduis;
    }
    public double len { get; set; }
    public override double area1()
    {
        return len * len;
    }
}





    
