/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 21/12/2023
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace praktikum_module_tiga
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			BST bst = new BST();
			
			string m = Console.ReadLine();
			
			for (int i = 0; i < int.Parse(m); i++) {
				
				string inputUser = Console.ReadLine();
				
				String[] result = inputUser.Split(' ');
				
				if (result[0].Equals("I")) bst.add(int.Parse(result[1]));
				
				if (result[0].Equals("S")) bst.doS(int.Parse(result[1]));
				
				if (result[0].Equals("B")) bst.searchNodeVWithBFS(int.Parse(result[1]));
				
				if (result[0].Equals("D")) bst.searchNodeVWithDFS(int.Parse(result[1]));
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}