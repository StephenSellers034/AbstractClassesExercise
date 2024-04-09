using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle //inherit properties from Vehicle(Base)
    {
        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is small and fast.");
        }
        

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's Virtual Drive Method");
        }
        

        

        
        
    }
}

