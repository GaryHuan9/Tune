using System.IO;
using System.Text.RegularExpressions;
using CodeHelpers.Diagnostics;
using CodeHelpers.Files;

namespace Tune
{
	class Program
	{
		static void Main()
		{
			// using FileWriter writer = new FileWriter("dictionary.words");
			//
			// writer.Write(0);
			// int count = 0;
			//
			// foreach (string line in File.ReadLines("/Users/ghuang21/Things/Programming/C#/Tune/Tune/dictionary.txt"))
			// {
			// 	string[] slices = line.Split('"');
			// 	if (slices.Length < 5) continue;
			//
			// 	char character = Regex.Unescape($@"\u{slices[1]}")[0];
			// 	string[] tunes = slices[3].Split(',');
			//
			// 	if (tunes.Length == 0) continue;
			//
			// 	writer.Write(character);
			// 	writer.Write((byte)tunes.Length);
			//
			// 	for (int i = 0; i < tunes.Length; i++) writer.Write(tunes[i]);
			// 	count++;
			// }
			//
			// writer.Seek(0, SeekOrigin.Begin);
			// writer.Write(count);

			using FileReader reader = new FileReader("../../../dictionary.words");

			int count = reader.ReadInt32();

			for (int i = 0; i < count; i++)
			{

			}
		}
	}
}