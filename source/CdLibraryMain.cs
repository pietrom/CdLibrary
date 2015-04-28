using System;

namespace CdLibrary {
	class CdLibraryMain {
		static void Main(string[] args) {
			Welcome();
			ShowArgs(args);
			GoodBye();
			Console.WriteLine();
			Console.ReadLine();
		}
		
		static void Welcome() {
			Console.WriteLine("***** Welcome to CdLibrary *****");
		}
		
		static void ShowArgs(string[] args) {
			Console.WriteLine("There are " + args.Length + " CLI params");
			for(int i = 0; i < args.Length; i++) {
				Console.WriteLine(args[i]);
			}
		}
		
		static void GoodBye() {
			Console.WriteLine("***** Good bye! *****");
		}
	}
}