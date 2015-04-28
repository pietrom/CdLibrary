using CdLibrary.Utils;

namespace CdLibrary {
	class CdLibrary {
		private Console console;
		
		public CdLibrary(Console console) {
			this.console = console;
		}
		
		public void run(string[] args) {
			Welcome();
			ShowArgs(args);
			GoodBye();
			console.WriteLine();
			console.ReadLine();
		}
		
		void Welcome() {
			console.WriteLine("***** Welcome to CdLibrary *****");
		}
		
		void ShowArgs(string[] args) {
			console.WriteLine("There are " + args.Length + " CLI params");
			for(int i = 0; i < args.Length; i++) {
				console.WriteLine(args[i]);
			}
		}
		
		void GoodBye() {
			console.WriteLine("***** Good bye! *****");
		}
	}
}