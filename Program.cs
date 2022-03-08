using POO.src.Entities;

namespace POO
{
    class Program
  {
    static void Main(string[] args)
    {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizard.Attack(1));
    }
  }
}