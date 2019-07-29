using System;
using System.Reflection;
using System.Threading.Tasks;
using ExternalAssembly;
using MethodDecorator.Fody.Interfaces;

namespace Test {
	class Program {
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Tas();
		}

		[Test]
		public static void Tas()
		{
			Console.WriteLine("ASdasdsad");
			TeCl();
		}
[Test]
		static void TeCl()
		{
			/*TeClass d = new TeClass("asd");
			var t = TeClass.Produce();
			Console.WriteLine(t.Hallo("asdgdfsg").Result);
			Console.WriteLine(t.Hallasdfo("sdfgsdfg").Result);
			*/
			THisisaTest.Hallo();

		}
	}

	public class TeClass {
		public string Dasda { get; set; }
		[Test]
		public TeClass(string d)
		{
			Dasda = d;
		}
		[Test]
		public static TeClass Produce()
		{
			return new TeClass("asljhdhsald");
		}
		[Test]
		private string Hall()
		{
			Console.WriteLine("Do Stuff");
			return "asodjhasdf";
		}
		[Test]
		public async Task<string> Hallo(string das)
		{
			
			await Task.Delay(1000);
			return das + "asd" + Hall();
		}
		
		[Test]
		public async Task<string> Hallasdfo(string das)
		{
			
			await Task.Delay(1000);
			//throw new Exception("EXCEPTION");
			return das + "asd" + Hall();
		}
	}

	
}