/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 21/12/2023
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_module_tiga
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			BST tes = new BST();
			tes.add(1);
			tes.add(2);
			tes.add(3);
			
			Console.WriteLine(tes.Root.Data);
			Console.WriteLine(tes.Root.RightChild.RightChild.Data);
			Console.WriteLine(tes.Root.RightChild.Data);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}