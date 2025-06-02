using System.Text;

void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        //0x + 0 = 0
        Console.WriteLine("Vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }
}
void quadratic_equation_solution(double a, double b, double c) {
    if (a == 0)
    {
        //Phuong trinh bac 1: bx + c =0
        first_degree_solution(b, c);
    }
    else {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if (delta == 0)
        {
            Console.WriteLine("x1=x2={0}", -b / (2 * a));
        }
        else {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1={0}\nX2={0}");
        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 2");
Console.WriteLine("He so a: ");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("He so b: ");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("He so c: ");
var c = Double.Parse(Console.ReadLine());
Console.WriteLine("{0}X^2+{1}x+{2}=0",a,b,c);
quadratic_equation_solution(a,b,c);
Console.ReadLine();
