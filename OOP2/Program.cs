using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

fullTimeEmployee obama = new fullTimeEmployee();
obama.Id = 1;
obama.idCard = "123";
obama.Name = "Barac Obama";
obama.Birthday = new DateTime(1960, 12, 25);

Console.WriteLine("Thông tin của Obama: ");
Console.WriteLine("ID: " + obama.Id);
Console.WriteLine("ID Card: " + obama.idCard);
Console.WriteLine("Name: " + obama.Name);
Console.WriteLine("Birtday: " + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Obama=>" + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    idCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1954, 2, 7),
    WorkingHour = 2
};

Console.WriteLine("Thông tin của Trum: ");
Console.WriteLine("ID: " + trump.Id);
Console.WriteLine("ID Card: " + trump.idCard);
Console.WriteLine("Name: " + trump.Name);
Console.WriteLine("Birtday: " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Obama=>" + trump.calSalary());



Console.WriteLine("----Thông tin cách 2 của nhân sự----");
Console.WriteLine(obama);
Console.WriteLine(trump);
