using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string N1 = Console.ReadLine();
            int N = N1.Length;
            char[] zb7 = { '!', '”', '#', '$', '%', '&', '‟', '(', ')', '*' };
            int[] zzz = new int[8];
            byte[] zz = new byte[8];
            char[] s = new char[8];
            int Q = N % 5;
            Random f = new Random();
            for (int i = 0; i < Q; i++)
            {
                zzz[i] = f.Next(0, 9);
            }
            for (int i = Q - 1; i < 8; i++)
            {
               zz[i] = Convert.ToByte(f.Next(192, 223));
            }
            char[] ds = System.Text.Encoding.GetEncoding(1251).GetChars(zz);
            int j = Q - 1;
            for (int i = Q - 1; i < 8; i++)
            {
                s[j] = ds[i];
                j++;
            }
            Console.Write("Пароль: ");
            for (int i = 0; i < Q; i++)
            {
                Console.Write(zzz[i]);
            }
            s[5] = zb7[f.Next(zb7.Length)];
            for (int i = Q-1; i < 8; i++)
            {
                Console.Write(s[i]);
            }
            
            Console.ReadKey();
        }
    }
}
