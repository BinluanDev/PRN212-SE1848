using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;
//Tạo đối tượng Category
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
//Xuất thông tin bằng cách gọi hàm
c1.PrintInfor();

//Giả sử đổi thông tin giá trị trong ô nhớ đó
c1.Name = "Thuốc hạ sốt";
Console.WriteLine("Giá trị sau khi thay đổi: ");
c1.PrintInfor();

//Sử dụng lớp Employee
Console.WriteLine("===========Employee===========");
Employee e1 = new Employee();
e1.id = 1; //Gọi setter property của Id
e1.IdCard = "001";
e1.Name = "Tèo";
e1.Email = "teo@gmail.com";
e1.Phone = "1234567890";
//Xuất thông tin
e1.PrintInfor();

Employee e2 = new Employee()
{
    id = 2,
    IdCard = "001",
    Name = "Tý",
    Email = "ty@gmail.com",
    Phone = "123213450",
};
Console.WriteLine("============Employee2============");
e2.PrintInfor();
