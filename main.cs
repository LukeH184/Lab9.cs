using System;

class Program {
  public static void Main (string[] args) {
    int x = 0, y = 0;
    while (true){
      Console.WriteLine("Choose from the following:");
      Console.WriteLine("0. Quit");
      Console.WriteLine("1. Multiply 2 numbers");
      Console.WriteLine("2. Div 2 numbers");
      Console.WriteLine("3. Mod 2 numbers");
      int choice = Convert.ToInt16(Console.ReadLine());
      if(choice != 0){
        Console.WriteLine("Enter first number");
        x = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter second number");
        y = Convert.ToInt16(Console.ReadLine());
          }
      if(choice == 1){
        Console.WriteLine("Answer: " + recursive_multiply(x, y));
      }
      if(choice == 2){
        Console.WriteLine("Answer: " + recurisve_division(x, y));
    }
      if(choice == 3){
        Console.WriteLine("Answer: " + recursive_mod(x, y));
        }
      if(choice == 0){
         System.Environment.Exit(0);
      }
      Console.WriteLine();
      }


    //methods
    int recursive_multiply(int x, int y) {
    //base end of function
    if (y == 0){return 0;}
    y--;
    return x + recursive_multiply(x,y);
    }
    int recurisve_division(int x, int y){
      //base end
      if (y > x){return 0;}
      if (x == y){return 1;}
      if (y == 0){return -1;}
      return 1 + recurisve_division(x - y,y);
    }
    int recursive_mod(int x, int y){
      if (y == 0){return -1;}
      if (x < y){return x;}
      return recursive_mod(x - y,y);
    
    }
  }
}