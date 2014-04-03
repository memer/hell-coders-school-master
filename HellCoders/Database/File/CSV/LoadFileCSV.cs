using System;
using System.Collections.Generic;
using System.IO;

namespace HellCoders.Database.File.CSV
{
	// <summary>
	// One Row
	// </summary>
	public class CsvRow : List<string> { public string row { get; set; } }

	class LoadFileCSV
	{
		protected string fileName { get; set; }
		protected List<int> orders;

		public LoadFileCSV(string fileName)
		{
			if (string.IsNullOrEmpty(fileName)) { throw new Exception("Filename is not valid. (Null or Empty)"); }
			this.fileName = fileName;
			this.initializeFile();
		}

		protected bool initializeFile()
		{
			try
			{
				// Create an instance of StreamReader to read from a file. 
				using (StreamReader sr = new StreamReader("TestFile.txt"))
				{
					string line;
					// Read and display lines from the file until the end of the file is reached. 
					while ((line = sr.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
					return true;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
				return false;
			}
		}

	}
}
