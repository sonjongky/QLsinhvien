using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLsinhvien
{
	class Program
	{
		public static List<sinhvien> list = new List<sinhvien>();
		static void Main(string[] args)
		{
			menu();
			Console.ReadKey();
		}
		public static void menu()
		{
			Console.WriteLine("1. Nhap thong tin : ");
			Console.WriteLine("2. Xuat thong tin : ");
			Console.WriteLine("3.Sua thong tin : ");
			Console.WriteLine("4. Xoa thong tin: ");
			Console.WriteLine("5. Tim kiem theo MSSV : ");
			Console.WriteLine("6. Cap nhat ");
			Console.WriteLine("7. Thoat : ");
			Console.WriteLine("Ban lua chon : ");
			int lc = int.Parse(Console.ReadLine());
			switch (lc)
			{
				case 1: nhapds(); menu(); break;
				case 2: xuatds(); menu(); break;
				case 3: sua(); menu(); break;
				case 4: xoa(); menu();break;
				case 5: timkiem();menu();break;
				case 6: Console.WriteLine("Da cap nhat");menu(); break;
				case 7: break;
			}
		}
		public static void nhapds()
		{
			Console.WriteLine("Nhap so sinh vien can them : ");
			int sosv = int.Parse(Console.ReadLine());
			for(int i=0; i<sosv; i++)
			{
				sinhvien sv = new sinhvien();
				sv.nhap();
				list.Add(sv);
			}
		}
		public static void xuatds()
		{
			for( int i=0; i<list.Count; i++)
			{
				list[i].xuat();
			}
		}
		public static void timkiem()
		{
			Console.WriteLine("Nhap mssv can tim kiem : ");
			string tk= Console.ReadLine();
			for(int i=0;i<list.Count;i++)
			{
				if(list[i].Mssv== tk)
				{
					list[i].xuat();
				}
			}
		}
		public static void xoa()
		{
			Console.WriteLine("Nhap mssv can xoa : ");
			string ms = Console.ReadLine();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Mssv == ms)
				{
					list.RemoveAt(i);
				}
			}
		}
		public static void sua()
		{
			Console.WriteLine("Nhap mssv can sua : ");
			string ms = Console.ReadLine();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Mssv == ms)
				{
					list[i].nhap();
				}
			}
		}
	}
}
