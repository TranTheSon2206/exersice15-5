using System;

public class Atom //Tạo lớp Atom có các thuộc tính sau
{
    private int atomicNumber;//số hiệu nguyên tử
    private string symbol;//ký hiệu
    private string fullName;//tên đầy đủ
    private double atomicWeight;//khối lượng nguyên tử(nguyên tử khối)

    public bool Accept()
    {
        Console.Write("Enter atomic number: ");//hiện ra màn hình: nhập số hiệu nguyên tử
        string input = Console.ReadLine();//đọc chuỗi vào và lưu vào biến input(dạng ký tự)

        //kiểm tra đàu vào xem biến input có phải số nguyên hay không
        if (!int.TryParse(input, out atomicNumber))
        {
            return false;
        }

        Console.Write("Enter symbol: ");//nhập ký hiệu nguyên tử
        symbol = Console.ReadLine().Trim();//đọc chuỗi vào và lưu vào biên symbol,trong đó hàm .Trim() dùng để loại bỏ khoảng trắng ở đầu và cuối chuỗi
        //kiểm tra biến symbol xem có rỗng không
        if (symbol.Length == 0)
        {
            return false;
        }

        Console.Write("Enter full name: ");//nhập tên đầy đủ của nguyên tử
        fullName = Console.ReadLine().Trim();//đọc chuỗi vào và lưu vào biên fullName,trong đó phương thức .Trim() dùng để loại bỏ khoảng trắng ở đầu và cuối chuỗi

        //kiểm tra biến fullName xem có rỗng không
        if (fullName.Length == 0)
        {
            return false;
        }

        Console.Write("Enter atomic weight: ");//hiện ra màn hình: nhập nguyên tử khối
        input = Console.ReadLine();//đọc chuỗi vào và lưu vào biến input

        //kiểm tra đàu vào xem biến input có phải số thực hay không, nếu có thì lưu biến vào atomicWeight
        if (!double.TryParse(input, out atomicWeight))
        {
            return false;
        }

        return true;
    }

    /*Phương thức Display() sẽ hiển thị thông tin về nguyên tử trên đầu ra tiêu chuẩn,
    bao gồm các thông tin về số hiệu nguyên tử, ký hiệu nguyên tử, tên đầy đủ của nguyên tử và khối lượng nguyên tử.*/
    public void Display()
    {
        Console.WriteLine("{0,-4} {1,-3} {2,-15} {3,-10:F3}", atomicNumber, symbol, fullName, atomicWeight);//chỉnh hiển thị độ rộng của các ký tự
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Atom[] atoms = new Atom[10];//khai báo mảng có 10 phần tử
        int numAtoms = 0;//giá trị ban đàu

        Console.WriteLine("Atomic Information");
        Console.WriteLine("==================");


        /*vòng lặp cho 10 phần tử , Trong mỗi vòng lặp, một đối tượng Atom mới được tạo và thông tin của nó được chấp nhận thông qua hàm Accept().
        Nếu accept() trả về giá trị false, vòng lặp sẽ được dừng lại*/
        while (numAtoms < 10)
        {
            atoms[numAtoms] = new Atom();
            if (!atoms[numAtoms].Accept())
            {
                break;
            }
            numAtoms++;
        }

        Console.WriteLine("No  Sym Name            Weight");
        Console.WriteLine("------------------------------------");

        //hiện ra màn hình mảng atoms
        for (int i = 0; i < numAtoms; i++)
        {
            atoms[i].Display();
        }
    }
}
