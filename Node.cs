/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 21/12/2023
 * Time: 14:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_module_tiga
{
	/// <summary>
	/// Description of Node.
	/// </summary>
	public class Node
	{
		public int Data;
		public Node Parent;
		public Node LeftChild;
		public Node RightChild;
		
		public Node(int Data)
		{
			this.Data = Data;
		}
	}
}
