using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	public abstract class Vehicle
	{
		

		public int Year { get; set; } = 2023; //Properties with set defaults

		public string Make { get; set; } = "Default";

        public string Model { get; set; } = "Default";

        

        public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("Default Virtual Drive Method");
		}
		
	}
}

