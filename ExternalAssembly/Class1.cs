using System;
using System.Reflection;
using MethodDecorator.Fody.Interfaces;

namespace ExternalAssembly {
	public class TestAttribute :Attribute, IMethodDecorator {
		public void Init(object instance, MethodBase method, object[] args)
		{
			Console.WriteLine("INVOke " + method.Name);
			Console.WriteLine("Invoke " + args.Length);
		}

		public void OnEntry()
		{
			Console.WriteLine("Entry");
		}

		public void OnExit()
		{
			Console.WriteLine("Exit");
		}

		public void OnException(Exception exception)
		{
			
			Console.WriteLine("Exception "  + exception.Message);
		}
	}
}