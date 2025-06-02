using System.Text;

string do_math(double a,double b,string op) {
    string result = "";
    switch (op) {
        case "+":
            result = $" {a} + {b} = {a+b} ";
            break ; 
        case "-":
            result = a + "-" + b + "=" + (a-b); 
            break ;
        case "*":
            result = $"{a} * {b} = {a + b}";
            break ;
        case "/":
            if (b == 0)
                result = "Mau so phai lon hon 0";
            else
                result = $"{a} / {b} = {a / b}";
            break ;
        default:
            result = "nhap phep toan sai";
            break ;
    }
    return result ;
}
Console.OutputEncoding = Encoding.UTF8;
double a, b;
Console.WriteLine("Nhap a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Phep toan +,-,*,/: ");
string op = Console.ReadLine();
string result = do_math(a,b,op);
Console.WriteLine(result);
