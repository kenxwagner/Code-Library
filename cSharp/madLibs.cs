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
			string madLibs =@"We need a story. 
			It may be best to find a story from elsewhere until one can be made.
			";
			
			StringBuilder sb = new StringBuilder();
			Regex pattern = new Regex(@"\<(.*?)\>");
			string storyLine;
			string replacement;
			
			Console.WriteLine(madLibs + Enviroment.NewLine + Enviroment.NewLine);
			Console.WriteLine("Enter a story");
			
			// Continue to get input while empty line hasn't been entered.
			do
			{
				storyLine = Console.ReadLine();
				sb.Append(storyLine + Enviroment.NewLine);
			} while (!string.IsNullOrEmpty(storyLine) && !string.IsNullOrWhiteSpace(storyLine));
			
			// Retrieve only the unique regex matches from the user entered story.
			Match nameMatch = pattern.Matches(sb.ToString()).OfType<Match>().Where(x => x.Value.Equals("<name>")).Select(x => x.Value).Distinct() as Match;
			if(nameMAtch!= null)
			{
				do
				{
					Console.WriteLine("Enter value for: " + nameMatch.Value);
					replacement = Console.ReadLine();
				} while (string.IsNullOrEmpty(replacement) || string.IsNullOrWhiteSpace(replacement));
				sb.Replace(nameMatch.Value, replacement);
				
			}
			
			
		}
		
	}
}