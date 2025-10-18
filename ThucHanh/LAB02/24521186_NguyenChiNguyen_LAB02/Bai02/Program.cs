using System;

namespace LAB2.Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir;
            // Nhap duong dan thu muc, neu duong dan khong ton tai thi yeu cau nhap lai
            while (true)
            {
                Console.Write("Nhap duong dan thu muc: ");
                dir = Console.ReadLine();
                if(!Directory.Exists(dir))
                {
                    Console.WriteLine("Khong tim thay thu muc! Vui long thu lai duong dan khac!");
                }
                else
                {
                    break;
                }
            }

            /// Thuc hien xu ly va in ra tat ca thu muc va tap tin
            string[] childFolders = Directory.GetDirectories(dir);
            string[] childFiles = Directory.GetFiles(dir);
            // In ra cac thu muc va tap tin
            if(childFolders.Length != 0 || childFiles.Length != 0)
            {
                // In cac thu muc
                for(int i = 0; i < childFolders.Length; i++)
                {
                    Console.WriteLine("[DIR]\t" + Path.GetFileName(childFolders[i]));
                }
                // In cac tep tin
                for(int i = 0; i < childFiles.Length; i++)
                {
                    Console.WriteLine("[FILE]\t" + Path.GetFileName(childFiles[i]));
                }
            }
            else
            {
                Console.WriteLine("Khong co thu muc hay tap tin nao trong duong dan thu muc da nhap!");
            }
        }
    }
}