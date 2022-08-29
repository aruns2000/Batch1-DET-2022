// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
using Batch1_DET_2022;


class MyClass
{
    enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    public static string GetGrade(int mark) //IN parameter
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "PASS";
        else
            return "FAIL";
    }
    public static void Main()
    {
        //  try
        //  {
        //     Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
        // Console.WriteLine(m.Print());

        //     Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
        // Console.WriteLine(m1.Print());  //base class ref can point to derived object

        //     Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
        //Console.WriteLine(e1.Print());

        //    Console.WriteLine("enter empid b.w 1001 - 25000");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //     if (id < 1001 || id > 25000)
        //        throw new InvalidEmpIdException("Entered empid is not in the range...");

        //    Console.WriteLine("enter emp name");
        //      string name = Console.ReadLine();

        //    Console.WriteLine("enter doj");
        //     DateTime doj = DateTime.Parse(Console.ReadLine());

        //Emp e2 = new(id, name, doj);


        // List<Emp> list = new List<Emp>();
        //  list.Add(m);
        //   list.Add(m1);
        //   list.Add(e1);
        //    foreach (Emp x in list)
        // //        Console.WriteLine(x.Print());
        // }
        //  catch (InvalidEmpIdException e)
        //  {
        //      Console.WriteLine(e.Message);
        //   }
        //  catch (Exception e)
        //  { }

        //CompanyManager m1 = new CompanyManager { Name = "Arun", Surname = "S", Phone = "7338370521" };

        //Company company = new Company { Name = "SSL", Address = "GV", Manager = m1, Phone = "755862438", Website = "Sonata-software" };

        //Console.WriteLine(company.Print());

        int Age;
        //try
        //{
        //    Console.WriteLine("Enter the Age b/w 1-100");
        //    Age = int.Parse(Console.ReadLine());
        //    if (Age > 100)
        //        throw new Exception("Enter the valid age");

        //}
        //catch(InvalidEmpIdException a)
        //{
        //    Console.WriteLine(a.msg);
        //}
        //catch(Exception a)
        //{ }
        //List<Animal> animal = new List<Animal>();
        //animal.Add(new Dog());
        //animal.Add(new Cat());

        //foreach (Animal a in animal)
        //    Console.WriteLine(a.ToString());


        ScienceStudent Student = new ScienceStudent { regno = 12, Name = "vinay" };
        ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
        CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

        Console.WriteLine($"The avg Score of Science Student is:{sciencesubject.GetAvgMarks()}");
        Console.WriteLine($"The avg Score of Commerce Student is:{Commercessubject.GetAvgMarks()}");
    }

}

   

    

  
