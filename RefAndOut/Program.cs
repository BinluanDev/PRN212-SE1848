using System.Text;

Console.OutputEncoding=Encoding.UTF8;
void ham1(int n) {
    n = 8;
    Console.WriteLine($"n trong ham= {n}");
}
int n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao ham = {n}");

void ham2(ref int n) {
    n = 8;
    Console.WriteLine($"n trong ham ={n}");
}
Console.WriteLine("--------------------");
n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham2(ref n);
Console.WriteLine($"n sau khi vao ham = {n}");
//int m;
//ham2(ref m); báo lỗi vì dòng 23 m chưa có giá trị
void ham3(out int n) {
    n = 9;
}
n = 113;
ham3(out n);