using System.Diagnostics.Metrics;
using NhanVienCTy;
public class Program
{

    public class QuanLyEmployee
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            List<Employee> employeeList = new List<Employee>();

            bool continues = true;
            while (continues)
            {
                Console.WriteLine("1.Nhập thông tin nhân viên mới");
                Console.WriteLine("2.Kiểm tra thông tin nhân viên");
                Console.WriteLine("3.Thoát");
                Console.Write("Vui lòng chọn: ");
                int selectNumber = int.Parse(Console.ReadLine());

                switch (selectNumber)
                {
                    case 1:
                        AddEmployee(employeeList);
                        break;
                    case 2: 
                        OutputAll(employeeList);
                        break;
                    default:
                        continues = false;
                        break;
                }

            }
            Console.WriteLine("---------------------------Xong-------------------------------");
            Console.ReadLine();
        }

        public static void AddEmployee(List<Employee> employeeList)
        {
            while (true)
            {
                Console.Write("Chọn để kiểm tra nhân viên (1: Manager, 2: Sale, 0: Thoát): ");
                int choice = int.Parse(Console.ReadLine());

                Employee em = null; //rỗng để thêm nhân viên mới vào

                if (choice == 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        em = new Manager();
                        em.Input();
                        employeeList.Add(em);
                        break;

                    case 2:
                        em = new Sale();
                        em.Input();
                        employeeList.Add(em);
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }

            public static void OutputAll(List<Employee> employeeList)
            { 
                Console.WriteLine("Danh sách nhân viên:");
                foreach (var em in employeeList)
                {
                    em.Output();  // Gọi phương thức Output để xuất thông tin chi tiết nhân viên
                }
            }

        
    }

}
