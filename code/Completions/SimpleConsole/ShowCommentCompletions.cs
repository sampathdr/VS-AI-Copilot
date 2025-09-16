using System.Xml.Linq;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleConsole {
	internal class ShowCommentCompletions {

		public static void GetXmlContent() {
			string path = Environment.CurrentDirectory;
			string fileName =@"\data\WebColors.xml";
			string fullPath = path + fileName;

			// Load color data from an XML file and extract relevant elements
			XDocument doc = XDocument.Load(fullPath);

			// get color-name attribute value, hex value, use camel case for property names


		}

		public void XmlDone() {
			//string path = Environment.CurrentDirectory;
			//string fileName = @"\data\WebColors.xml";
			//string fullPath = path + fileName;

			//// Load color data from an XML file and extract relevant elements
			//XDocument doc = XDocument.Load(fullPath);
			//// get color-name attribute value, hex value, use camel case for property names
			//var colors = from color in doc.Descendants("Color")
			//						 select new
			//						 {
			//							 ColorName = (string)color.Attribute("color-name"),
			//							 HexValue = (string)color.Element("Hex"),
			//						 };
			//foreach (var color in colors)
			//{
			//	Console.WriteLine($"{color.ColorName}: {color.HexValue}");
			//}




		}

	}
}
