using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
namespace SimpleConsole {

	internal class Program {

		private static async Task Main(string[] args) {
			Console.WriteLine("Hello, World!");

			//	Console.WriteLine(await ShowIntellicode.GetWeather());

			ShowCommentCompletions.GetXmlContent();
		}

	}
}