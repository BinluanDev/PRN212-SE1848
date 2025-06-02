using System.Text;
using OOP2;
using OOP4_reuseOOP2;

Console.OutputEncoding = Encoding.UTF8;
fullTimeEmployee fe = new fullTimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.idCard = "12345";
fe.Birthday = new DateTime(1952, 12, 25);
Console.WriteLine(fe);
Console.WriteLine("=>Age = " + fe.Tuoi());