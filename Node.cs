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
		// data untuk menampung data node atau akar
		public int Data;
		
		// leftChild untuk menampung akar kiri
		public Node LeftChild;
		
		// rightChild untuk menampung akar kanan
		public Node RightChild;
		
		// Constructor Node
		public Node(int Data)
		{
			this.Data = Data;
		}
	}
}
