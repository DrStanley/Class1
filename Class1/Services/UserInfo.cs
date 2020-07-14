using System;
using System.Collections.Generic;
using System.Text;

namespace Class1.Services
{
	class UserInfo
	{

		public static string GetName() {
			Console.WriteLine("Enter your name");
			//reads users input from console
			string getName = Console.ReadLine();
			return getName;
		}
		public static int GetAge() {
			int age = 0;

			Console.WriteLine("Enter your Date of Birth (DD/MM/YYYY)");
			//reads users input from console
			string getDate = Console.ReadLine();

			//gets the current date
			int currentYear = DateTime.Now.Year;
			int currentMonth = DateTime.Now.Month;
			int currentDay = DateTime.Now.Day;

			try
			{
				//converts user input to Date object
				DateTime dob = Convert.ToDateTime(getDate);
				//getting the dates
				int birthYear = dob.Year;
				int birthMonth = dob.Month;
				int birthDay = dob.Day;
				age = currentYear - birthYear;
				if (currentMonth < birthMonth)
				{
					--age;
				}
				else if (currentMonth == birthMonth)
				{
					if (currentDay > birthDay)
					{
						--age;
					}

				}
			}
			catch(Exception e)
			{
				Console.WriteLine("Incorrect date format");
			}
		


			return age;
		}
		

	}
}
