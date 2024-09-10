using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin Nhan Vien");
            this.Id = Console.ReadLine();
            this.Name = Console.ReadLine();
            this.Age = int.Parse(Console.ReadLine());
            this.Gioitinh = bool.Parse(Console.ReadLine());
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
        public override void Nhap()
        {
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
        public override void Nhap()
        {
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
