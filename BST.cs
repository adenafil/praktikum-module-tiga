/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 21/12/2023
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace praktikum_module_tiga
{
	/// <summary>
	/// Description of BTS.
	/// </summary>
	public class BST
	{
		// variable akar
		public Node Root;
		// variabel untuk menampung data apakah data yang di cari
		// melalui DFS ditemukan
		private bool isDFSvalueFound = false;
		// s untuk menampung data seluruh BST
		// yang nantinya akan berfungsi untuk menampilkan
		// nilai dari command S "value"
		private List<int> s = new List<int>();
		
		// constructor
		public BST()
		{
			this.Root = null;
		}
		
		/// <summary>
		/// Method untuk mengecek apakah BST kosong atau tidak
		/// </summary>
		/// <returns>false jika kosong dan sebaliknya</returns>
		public bool IsEmpty()
		{
			return this.Root == null;
		}
		
		/// <summary>
		/// Method untuk menambahkan data ke dalam BST
		/// </summary>
		/// <param name="data">data yang akan disimpan pada BST</param>
		public void add(int data)
		{
			// Membuat variabel baru dengan tipe Node
			Node baru = new Node(data);
			// membuat variabel level untuk menampung level tiap akar
			int level = 1;
			
			// jika kosong maka jadikan var Baru sebagai akar
			if (IsEmpty())
			{
				// mengasign node root menjadi node baru
				this.Root = baru;
				// menambahkan data (bukan node) ke var list s
				s.Add(data);
				// console level
				Console.WriteLine(level);
				// stop 
				return;
			}
			
			// membuat var tempRoot karena ingin traversal sebuah BST
			Node TempRoot = this.Root;
			
			// masuk ke looping dengan kondisi selama benar dan data pada BST harus tidak ada yang sama
			while(true && !has(TempRoot, data))
			{
				// menambah data ke dalam list s
				s.Add(data);
				// Bandingkan Node Baru Dengan TempRoot
				// left
				if (data < TempRoot.Data)
				{
					// increment level
					level++;
					
					// jika tempRoot child kiri null maka asign dengan node baru
					if (TempRoot.LeftChild == null)
					{
						// assign left child dengan var(node) baru
						TempRoot.LeftChild = baru;
						// console level
						Console.WriteLine(level);
						break;
					}
					
					// geser kiri
					TempRoot = TempRoot.LeftChild;
					
				}
				// right
				else
				{
					// increment level
					level++;
					
					// jika tempRoot child kiri null maka asign dengan node baru
					if (TempRoot.RightChild == null)
					{
						// assign right child dengan var(node) baru
						TempRoot.RightChild = baru;
						// console level
						Console.WriteLine(level++);
						break;
					}
					
				
					// Geser kanan
					TempRoot = TempRoot.RightChild;
				}
				
			}
			
			
		}
		
		/// <summary>
		/// Method untuk mengecek apakah BST Node memiliki data tersebut
		/// berfungsi untuk mencegah data duplikat pada BST
		/// </summary>
		/// <param name="node">Node pada bst</param>
		/// <param name="value">Data pada node</param>
		/// <returns>true jika ada dan sebaliknya</returns>
		public bool has(Node node, int value)
		{
			// cek root jika data pada root sama maka console "duplikat"
			if (node.Data == value) {
				Console.WriteLine("Duplikat");
				return true;
			}
			
			// mengecek dan mengtraversal bst apakah ada data pada node yang sama
			while (true)
			{
				// cek apakah dia right child or left child
				// di sini kita akan masuk ke lefft child
				if (value < node.Data)
				{
					// jika null alias tidak ada maka return false
					if (node.LeftChild == null) return false;
					
					// jika ada maka return true
					if (node.LeftChild.Data == value) return true;
					
					// node akan menggeser ke kiri / LeftChild jika data duplikat masih tidak ditemukan
					node = node.LeftChild;
					
				}
				else
				{
					// jika null alias tidak ada maka return false
					if (node.RightChild == null) return false;
					
					// jika ada maka return true
					if (node.RightChild.Data == value) return true;

					// node akan menggeser ke kiri / LeftChild jika data duplikat masih tidak ditemukan					
					node = node.RightChild;
				}
				
			}
			
		}
		
		/// <summary>
		/// Method untuk mengcari data pada BST dengan BFS
		/// </summary>
		/// <param name="value">data pada node yang mau dicari</param>
		public void searchNodeVWithBFS(int value)
		{
			// Membuat Queue dengan nama list
			Queue<Node> list = new Queue<Node>();
			// membuat var bool untuk menampung apakah data tersebut ditemukan atau tidak
			bool isFound = false;
			
			// add list dengan data root
			list.Enqueue(Root);
			
			// selamat data list tidaklah maka lakukan looping
			while (list.Count != 0)
			{
				// mengdeque list dan menampungnya ke Node current
				Node current = list.Dequeue();
				
				// console data pada node current
				Console.Write(current.Data + " ");
				
				// jika data pada node matching dengan parameter value
				if (current.Data == value)
				{
					// maka asign isFound menjadi true
					isFound = true;
					// dan stop looping
					break;
				}
				
				// jika node curren leftChild tidak kosong maka add ke list 
				if (current.LeftChild != null) list.Enqueue(current.LeftChild);
				
				// jika node curren rightChild tidak kosong maka add ke list 
				if (current.RightChild != null) list.Enqueue(current.RightChild);
				
			}
			
			// jika data pada parameter value tidak ditemukan setelah looping tadi
			// maka console =1
			if (!isFound) Console.WriteLine("-1");
			Console.WriteLine();
			
		}
		
		/// <summary>
		/// Method untuk mencari data node dengan DFS pada BST
		/// </summary>
		/// <param name="value"></param>
		public void searchNodeVWithDFS(int value)
		{
			// melakukan traversal
			preOrderTraversal(Root, value);
			
			// jika tidak ditemukan maka print -1
			if (!isDFSvalueFound) Console.Write("-1");
			
			// asign var isDFSvalueFound untuk reset value ke bawaan pabrik
			isDFSvalueFound = false;
		
			Console.WriteLine();
		}
		
		/// <summary>
		/// Method untuk melakukan traversal dengan cara recursive
		/// </summary>
		/// <param name="r">Node root</param>
		/// <param name="value">nilai yang ingin dicari pada data root</param>
		public void preOrderTraversal(Node r, int value)
		{
			// jika root tidak kosong dan juga datanya masih belum ditemukan
			if (r != null && !isDFSvalueFound)
			{
				// maka print data pada root tersebut
				Console.Write(r.Data + " ");
				
				// jika sudah ketemu
				if (value == r.Data)
				{
					// maka asign isDFSValue dengan true
					isDFSvalueFound = true;
					// kemudian stop recursive
					// pada dasarnya recursive masih jalan
					// cuma tak akan pernah lagi masuk ke kondisi ini karena variabel
					// isDFSValueFound tadi sudah menjadi true
					return;
				}
				
				// lakukan traversal ke child kiri untuk mencari data yang sama
				preOrderTraversal(r.LeftChild, value);
				
				// lakukan traversal ke child kanan untuk mencari data yang sama
				preOrderTraversal(r.RightChild, value);
			}
		}
		
		/// <summary>
		/// Method untuk command S
		/// </summary>
		/// <param name="value">nilai setelah command S</param>
		public void doS(int value) 
		{
			// mengasing list SortS dengan list S
			List<int> sortS = s;
			// lalu lakukan sort
			sortS.Sort();
			
			// kemudian print dengan index pada parameter value
			Console.WriteLine(sortS.ToArray()[value - 1]);
			
		}
		
	}
	
	
}
