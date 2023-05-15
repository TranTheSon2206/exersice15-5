using System;

public class Employee //Tạo lớp Employee có các thuộc tính sau
{
    private string firstName;
    private string lastName;
    private string address;
    private long sin;
    private double salary;

    //tạo constructor
    public Employee(string firstName, string lastName, string address, long sin, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.sin = sin;
        this.salary = salary;
    }

    //tạo phương thức tính tiền thưởng của nhân viên với đối số là percentage
    public double tienThuong(double percentage)
    {
        return salary * percentage;
    }

    //tạo phương thức Tostring() ghì đè lên phương thức có sẵn trong Employee, phương thức này sễ hiển thị thông tin như sau
    public override string ToString()
    {
        return string.Format("Employee Name: {0} {1}\nAddress: {2}\nSIN: {3}\nSalary: {4:C}", firstName, lastName, address, sin, salary);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Son", "Tran", "21 Jumpstreet", 514146347, 50000.00);//tạo một đối tượng Employee mới có tên emp

        Console.WriteLine(emp.ToString());//in ra màn hình thông tin của emp

        double bonus = emp.tienThuong(0.1); //tính tiền thưởng thêm với 0.1 phần trăm
        Console.WriteLine("Bonus: {0:C}", bonus); //in ra màn hình tiền thưởng
    }
}