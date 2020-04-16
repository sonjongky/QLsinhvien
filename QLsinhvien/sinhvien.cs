using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLsinhvien
{
	class sinhvien
	{
		private string mssv;
		private string hoten;
		private string khoa;
		private int diemht;
		private int diemrl;
		private string hang;
		public string Mssv
		{
			get
			{
				return mssv;
			}
			set
			{
				mssv = value;
			}
		}
		
		public string Hoten
		{
			get
			{
				return hoten;
			}
			set
			{
				hoten = value;
			}
		}
		public string Khoa
		{
			get
			{
				return khoa;
			}
			set
			{
				khoa = value;
			}
		}
		public int Diemht
		{
			get
			{
				return diemht;
			}
			set
			{
				diemht = value;
			}
		}
		public int Diemrl
		{
			get
			{
				return diemrl;
			}
			set
			{
				diemrl = value;
			}
		}
		public string Hang
		{
			get
			{
				return hang;
			}
			set
			{
				hang = value;
			}
		}

		public sinhvien() { }
		public sinhvien(string mssv, string hoten, string khoa, int diemht, int diemrl)
		{
			this.Mssv = mssv;
			this.Hoten = hoten;
			this.Khoa = khoa;
			this.Diemht = diemht;
			this.Diemrl = diemrl;

		}
		public void nhap()
		{
			Console.Write("Nhap ma so sinh vien : ");
			Mssv = Console.ReadLine();
			Console.Write("Nhap  ho ten sinh vien : ");
			Hoten = Console.ReadLine();
			Console.Write("Nhap khoa sinh vien : ");
			Khoa = Console.ReadLine();
			Console.Write("Nhap diem hoc tap : ");
			Diemht = int.Parse(Console.ReadLine());
			Console.Write("Nhap diem ren luyen : ");
			Diemrl = int.Parse(Console.ReadLine());
			if(Diemht>= 9 && Diemrl >=90 ) { hang = "Xuat xac "; }
			else if (Diemht >= 9 && Diemrl >= 80 && Diemrl<90 ) { hang = "Gioi "; }
			else if (Diemht >= 9 && Diemrl >= 70 && Diemrl < 80) { hang = "Kha "; }
			else if (Diemht >= 8 && Diemrl >= 80 ) { hang = "Gioi "; }
			else if (Diemht >= 7 && Diemrl >= 70 ) { hang = "Kha "; }

			else { hang = "YEU"; }




		}
		public void xuat()
		{
			string chuoi = string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}", this.Mssv, this.Hoten, this.Khoa, this.Diemht, this.Diemrl, this.Hang);
			Console.WriteLine(chuoi);	
		}



	}


}
