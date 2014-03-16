#define ERROR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool b = SomeMethod();

		}

		private static bool SomeMethod()
		{
			int m;
			int n = 2;
			bool b_const = true;
			
			// XS use of unassigned variable !!
			// VS 2012 OK.
			bool b = 
					F( 
						() => 
							F1(n, out m) 
							&&  
							Ferror( n + 1 + m )
					)
				#if ERROR
				// Error CS0165: Use of unassigned local variable `m' (CS0165)
					&&
					true
				#endif
					;

			return b;
		}

		protected static bool F(Func<bool> rule) // (join) 
		{
			return true;
		}

		private static bool F1(int j, out int m)
		{
			m = 2;

			return true;
		}

		private static bool Ferror(int i)
		{
			return true;
		}

		private static bool Fouter()
		{
			return true;
		}
	}
}
