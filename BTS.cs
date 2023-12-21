/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 21/12/2023
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_module_tiga
{
	/// <summary>
	/// Description of BTS.
	/// </summary>
	public class BTS
	{
		public Node Root;
		
		public BTS()
		{
			this.Root = null;
		}
		
		public bool IsEmpty()
		{
			return this.Root == null;
		}
		
		public void add(int data)
		{
			Node baru = new Node(data);
			
			if (IsEmpty())
			{
				this.Root = baru;
				return;
			}
			
			// cari posisi tempat node baru
			
			Node TempRoot = this.Root;
			
			while(true)
			{
				// Bandingkan Node Baru Dengan TempRoot
				// left
				if (data < TempRoot.Data)
				{
					
					if (TempRoot.LeftChild == null)
					{
						TempRoot.LeftChild = baru;
						break;
					}
					
					// geser kiri
					TempRoot = TempRoot.LeftChild;
					
				}
				// right
				else
				{
					if (TempRoot.RightChild == null)
					{
						TempRoot.RightChild = baru;
						break;
					}
					
				
					// Geser kanan
					TempRoot = TempRoot.RightChild;
				}
				
			}
			
			
			
		}
		
	}
	
	
}
