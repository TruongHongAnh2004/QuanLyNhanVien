using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

//Bài quản lý nhân viên bán hàng (gồm Manage, Sale)

namespace NhanVienCTy
{
    //Đây là trừu tượng abtract class 
    public abstract class Employee
    {
        //tính chất đóng gói trong CS là sd get set ( thuộc C# nâng cấp)
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public bool Gioitinh {  get; set; }
        public string City { get; set; }

        public Employee() { }
        public Employee(string _id, string _name, int _age, bool _gt, string _ctiy)
        {
            this.Id = _id;
            this.Name = _name;
            this.Age = _age;
            this.Gioitinh = _gt;
            this.City = _ctiy;
        }
        //đa hình nhập 
        public virtual void Input()
        {
            Console.WriteLine("Nhập thông tin Nhân Viên");
            Console.Write("Nhập STT: ");
            this.Id = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            this.Name = Console.ReadLine();
            Console.Write("Tuổi: ");
            this.Age = int.Parse(Console.ReadLine());

            Console.Write("Nam hay nữ: ");
            string input = Console.ReadLine();
            this.Gioitinh = (input == "Male") ? true : false;

            Console.Write("Quê quán: ");
            this.City= Console.ReadLine();

        }
        //Đa hình để xuất nhân viên (có bao gồm trừu tượng)
        public abstract void Output();
    }
    class Manager : Employee
    {
        public double Salary{get; set; }
        public Manager() { }
        public Manager(double salary)
        {
            Salary = salary;
        }
        public override void Input()
        {
            base.Input(); //Gọi hàm Nhap ở lớp cơ sở (lớp cha)
            Console.Write("Luong nhan vien la: ");
            this.Salary = double.Parse(Console.ReadLine());
            
        }
        public override void Output()
        {
            Console.Write($"Thong tin nhan vien: {Id} ");
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Gioi tinh: {Gioitinh}, City: {City}, Salary: {Salary}");
        }
    }

    class Sale : Employee
    {
        public double Salary { get; set; }
        public Sale() { }
        public Sale(double salary)
        {
            Salary = salary;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Luong nhan vien la: ");
            this.Salary = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            Console.Write($"Thong tin nhan vien: {Id} ");
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Gioi tinh: {Gioitinh}, City: {City}, Salary: {Salary}");
        }
    }
}
