namespace SimpleConsole {

	internal class ShowCompletions {

		public void DemoA() {
			List<string> list = new List<string>();
		}

		public void DemoB() {
			string colors = "Orange,Blue,Teal,Brown,Green.";
			string cities = "Renton, Issaquah, Redmond.";





		}
		public static string RemoveCommas(string input) {
			return string.IsNullOrEmpty(input) ? string.Empty : input.Replace(",", string.Empty);

		}
		public static string RemovePeriods(string input) {
			return string.IsNullOrEmpty(input) ? string.Empty : input.Replace(".", string.Empty);

		}

		public class Color {
			public string Name { get; set; }
			public string Hex { get; set; }
		}
	}
}