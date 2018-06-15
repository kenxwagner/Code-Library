using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MadLibs_time
{
	class Program
	{
		static void Main(string[] args)
		{
			string madLibs =@"We need a story.";
			
			StringBuilder sb = new StringBuilder();
			Regex pattern = new Regex(@"\<(.*?)\>");
			string storyLine;
			string replacement;
			
			Console.WriteLine(madLibs + Enviroment.NewLine + Enviroment.NewLine);
			Console.WriteLine("Enter a story");
		}
		
	}
}