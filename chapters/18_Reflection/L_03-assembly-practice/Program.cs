using System;
using System.Reflection;

namespace L_03_assembly_practice
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Assembly asm = Assembly.LoadFrom(@"C:\Users\kypos\Desktop\metanit\metanit_learning\chapters\18_Reflection\L_03-assembly\bin\Debug\netcoreapp3.1\L_03-assembly.dll");

				Type t = asm.GetType(@"L_03_assembly.Program", true, true);

				object instance = Activator.CreateInstance(t);

				MethodInfo method = t.GetMethod("GetResult");

				object result = method.Invoke(instance, new object[] { 6, 100, 3 });
				Console.WriteLine(result);

				Console.WriteLine("Вызов метода main");

				Assembly assm = Assembly.LoadFrom(@"C:\Users\kypos\Desktop\metanit\metanit_learning\chapters\18_Reflection\L_03-assembly\bin\Debug\netcoreapp3.1\L_03-assembly.dll");
				Type t2 = assm.GetType(@"L_03_assembly.Program", true, true);

				object programInst = Activator.CreateInstance(t2);
				MethodInfo mainMethod = t2.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);

				object res = mainMethod.Invoke(programInst, new object[] { new string[] { } });
				Console.WriteLine(res);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}
