/* 
 * Đề bài:
 * nhập vào 1 số >=0, nếu nhập sai bắt nhập lại
 * Nếu nhập đúng ==> tính giai thừa của nó
 */
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
int n = -1;
while (n < 0) {
    Console.WriteLine("Nhap n >=0");
    string s = Console.ReadLine();
    if (int.TryParse(s, out n) == false) {
        Console.WriteLine("Ban phai nhap so");
    }
    else {
        if (n < 0) { 
            Console.WriteLine("Ban phai nhap so");
        }
    }
}
int gt = 1;
for (int i = 1; i <= n; i++) 
    gt *= i;
Console.WriteLine($"{n}!= {gt}");
