/*
 * Sử dụng Generic List để quản lý nhân sự với đầy đủ 
 * Tính năng CRUD
 * C-->CREATE--> Tạo mới dữ liệu 
 * R-->Read/Retrieve -> Xem, lọc, tìm kiếm sắp xếp, thống kê...
 * U-->Update--> sửa dữ liệu
 * D-->DELETE--> xóa dữ liệu
 */
//Câu 1: Tạo 5 nhân viên, 3 nhân viên chính thức, 2 thời vụ
//luw vào Generic List:

using System.Text;
using OOP2;

List<Employee> employee = new List<Employee>();
fullTimeEmployee fe1 = new fullTimeEmployee()
{
    Id = 1,
    Name = "Nguyen Van A",
    idCard = "123",
    Birthday = new DateTime(1981, 1, 1),
};
employee.Add(fe1);

fullTimeEmployee fe2 = new fullTimeEmployee()
{
    Id = 2,
    Name = "Nguyen Van B",
    idCard = "1234",
    Birthday = new DateTime(1982, 2, 1),
};
employee.Add(fe2);

fullTimeEmployee fe3 = new fullTimeEmployee()
{
    Id = 3,
    Name = "Nguyen Van C",
    idCard = "12345",
    Birthday = new DateTime(1983, 3, 1),
};
employee.Add(fe3);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    Name = "Nguyen Van D",
    idCard = "1236",
    Birthday = new DateTime(1984, 4, 1),
    WorkingHour = 1
};
employee.Add(pe1);

ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Nguyen Van E",
    idCard = "1237",
    Birthday = new DateTime(1985, 5, 1),
    WorkingHour = 2
};
employee.Add(pe2);

//Câu 2: R -> Xuất toàn bộ nhân sự:
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Câu 2: R -> Xuất toàn bộ nhân sự: ");
//Cách 1:
employee.ForEach(e => Console.WriteLine(e));

//Câu 3: R -> Lọc ra các nhân sự chính thức:
//Cách 1:
List<fullTimeEmployee> fe_List = employee.OfType<fullTimeEmployee>().ToList();
Console.WriteLine("Câu 3: R -> Lọc ra các nhân sự chính thức: ");
foreach (fullTimeEmployee fe in fe_List)
    Console.WriteLine(fe);

//Câu 4: Tổng lương nhân viên chính thức:
double fe_sum_salary = fe_List.Sum(e => e.calSalary());
Console.Write("Câu 4: Tổng lương nhân viên chính thức: ");
Console.WriteLine(fe_sum_salary);

//Câu 5: Tổng lương nhân viên thời vụ:
double pe_sum_salary = employee.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
Console.Write("Câu 5: Tổng lương nhân viên thời vụ: ");
Console.WriteLine(pe_sum_salary);

//Bài tập:Bổ sung thêm các tính năng xóa hoặc sửa nhân viên

//Sửa nhân viên:
Console.Write("Nhập ID nhân viên cần sửa: ");
int idToUp = int.Parse(Console.ReadLine());

bool a = false;
foreach (Employee emp in employee)
{
    if (emp.Id == idToUp)
    {
        Console.Write("Nhập tên mới: ");
        emp.Name = Console.ReadLine();

        Console.Write("Nhập số idCard mới: ");
        emp.idCard = Console.ReadLine();

        Console.Write("Nhập ngày sinh mới (yyyy-mm-dd): ");
        emp.Birthday = DateTime.Parse(Console.ReadLine());

        a = true;
        break;
    }
}

if (!a)
{
    Console.WriteLine("Không tìm thấy nhân viên.");
}
Console.WriteLine("Danh sách nhân viên hiện tại: ");
employee.ForEach(e => Console.WriteLine(e));

//Xóa nhân viên:
Console.Write("Nhập ID nhân viên cần xóa: ");
int idDel = int.Parse(Console.ReadLine());

Employee empToDel = null;
foreach (Employee emp in employee)
{
    if (emp.Id == idDel)
    {
        empToDel = emp;
        break;
    }
}

if (empToDel != null)
{
    employee.Remove(empToDel);
    Console.WriteLine("Đã xóa nhân viên.");
}
else
{
    Console.WriteLine("Không tìm thấy nhân viên.");
}

Console.WriteLine("Danh sách nhân viên hiện tại:");
employee.ForEach(e => Console.WriteLine(e));


