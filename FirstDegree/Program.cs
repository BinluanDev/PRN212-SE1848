using System.Text;

void first_degree_solution(double a, double b) {
    if (a == 0 && b == 0)
    {
        //0x + 0 = 0
        Console.WriteLine("Vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else {
        Console.WriteLine("X={0}", -b / a);
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 1: ax+b=0");
Console.WriteLine("Nhap he so a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap he so b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("{0}x + {1} = 0", a, b);
first_degree_solution(a,b);
Console.ReadLine();

