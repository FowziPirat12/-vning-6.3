using System;
namespace Övning_6._3
{
    class program
    {
        static void Main(string[] args)
        {
            SkrivTalKvadratMelllan(1, 10);
        }
        static void SkrivTalKvadratMelllan(int NedreGräns, int ÖvreGräns)
        {
            for(int i= NedreGräns; i <= ÖvreGräns; i++)
            {
                SkrivTalKvadrat(i);
            }
        }
        static void SkrivTalKvadrat(int tal)
        {
            Console.WriteLine($"talet {tal} i kvadrat är: {tal * tal}");
        }
    }
}