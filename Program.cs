// See https://aka.ms/new-console-template for more information
using System.Buffers.Text;

Console.WriteLine("Hello, World!");
{
    Console.WriteLine();
    Console.Write("base1: ");
    Double base1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("altura: ");
   Double  altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    double area = multiplicacion(base1, altura);
    Console.WriteLine(area);


}


//Area de un triangulo

static double multiplicacion(double base1, double altura)
{

    

    double area = (base1*altura)/2;
    return area;

    

}

















