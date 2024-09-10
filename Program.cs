using System.Diagnostics.Metrics;
using NhanVienCTy;
public class Program
{

    public class QuanLyEmployee
    {
        private List<Employee> employees = new List<Employee>();
        //Thêm nhân viên mới vô

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

   
        public void Xuat()
        {
            foreach (var employee in employees)
            {
                employee.Output();
            }
        }
        static void Main(string[] args)
        {
            QuanLyEmployee nv = new QuanLyEmployee();


            nv.AddEmployee(new Manager(nv.Nhap());
            nv.AddEmployee(new Sale(nv.Nhap());

            Console.WriteLine("Employee List:");
            nv.Xuat();
        }
    }
}