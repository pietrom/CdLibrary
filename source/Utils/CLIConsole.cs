using System;

namespace CdLibrary.Utils {
	class CLIConsole : Console {
		public void WriteLine(string s) {
			System.Console.WriteLine(s);
		}
		
		public void WriteLine() {
			System.Console.WriteLine();
		}
		
		public string ReadLine() {
			return System.Console.ReadLine();
		}
	}
}