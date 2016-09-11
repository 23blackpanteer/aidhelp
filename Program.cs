using System;
using System.IO;
using test;

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
	//	public static void Main(){
	//	}
			public static void jan(){
				Console.WriteLine("klasa test2 metoda jan");
			}

}
	}