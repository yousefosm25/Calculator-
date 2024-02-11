namespace ConsoleApp1
{
  static class Program
  {
    static void Main()
    {
     Console.WriteLine("Welcome to calculate");
     Console.WriteLine("int your number1");
     double num1;
     double.TryParse(Console.ReadLine(), out num1);
     Console.WriteLine("int your number2");
     double num2;
     double.TryParse(Console.ReadLine(), out num2);
     Console.WriteLine("what do you want to do");
     Console.WriteLine("+ int 1");
     Console.WriteLine("- int 2");
     Console.WriteLine("* int 3");
     Console.WriteLine("/ int 4");
     Console.WriteLine("% int 5");
     int trynum;
     int.TryParse(Console.ReadLine(), out trynum);
     if(trynum == 1)
     {
      Console.WriteLine(num1+num2);     
     }
     else if(trynum == 2)
     {
      Console.WriteLine(num1-num2);
     }
     else if(trynum == 3)
     {
      Console.WriteLine(num1*num2);
     }
     else if(trynum == 4)
     {
      Console.WriteLine(num1/num2);
     }
     else if(trynum == 5)
     {
      Console.WriteLine(num1%num2);
     }
     else
     {
        Console.WriteLine("invalid input");
     }   
     
      
    }      
  }
}