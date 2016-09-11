using System;
using System.IO;
using tablice;

namespace test {
		class jakas {
		public static void Main(){
			jan ();
			test2.jakas.jan ();
		}

		public static void jan(){
			Console.WriteLine("klasa test metoda jan");
		}
	}
}
namespace test2 {
		class jakas {
			public static void jan(){
				Console.WriteLine("klasa test2 metoda jan");
			create.jakas ();
			}

	}
}

namespace tablice {
	class create {
		public static void jakas(){
			string[] numery;
			numery = new string[10];
			numery [0] = "1";
			numery [1] = "2";
			numery [2] = "3";
			numery [3] = "text";
			foreach (var x in numery) {
				Console.WriteLine (x);
			}
			srednie.numbers.liczenie();
		}
	}
}

namespace srednie {
	class numbers {
		public static void liczenie ()

		{
			int suma =0;
			int aa = 0;
			int[] num;
			num = new int[100];
			for (int i = 0; i < num.Length; ++i) {
				num [i] = i;
			}
		
			foreach (var x in num) {
				 ++aa;
				suma = suma + x; 
			}
			Console.WriteLine ("Srednia wynosi " +  Convert.ToDouble(suma/aa));
		}
	}
}
