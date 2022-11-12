using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Nilai Mutlak");
            Console.WriteLine("2. Nilai Terbesar");
            Console.WriteLine("3. Perpangkatan");
            Console.WriteLine("");
            Console.Write("Silakan pilih menu : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Console.Write("Masukkan sebuah bilangan : ");
                int bilangan = Convert.ToInt32(Console.ReadLine());
                int hasil = AbsoluteValue(bilangan);
                Console.WriteLine("Nilai mutlak dari {0} adalah {1}", bilangan, hasil);
            }
            else if (menu == 2)
            {
                Console.Write("Masukkan berapa angka untuk dibandingkan : ");
                int length = Convert.ToInt32(Console.ReadLine());
                int[] angka = new int[length];
                for (int i = 0; i <length; i++)
                {
                    Console.Write("Masukkan angka ke-{0} : ", i + 1);
                    angka[i] = Convert.ToInt32(Console.ReadLine());
                }
                int angkaTerbesar = MaximumNumber(angka);
                Console.WriteLine("Angka terbesar dari kumpulan angka tersebut adalah {0}", angkaTerbesar);
            }
            else if (menu == 3)
            {
                Console.Write("Masukkan nilai basis    : ");
                double basis = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai eksponen : ");
                int eksponen = Convert.ToInt32(Console.ReadLine());
                double result = Power(basis, eksponen);
                Console.WriteLine("Hasil dari perpangkatan {0} oleh {1} adalah {2}", basis, eksponen, result);
            }
        }

        static int AbsoluteValue(int value)
        {
            if (value < 0) return value * -1;
            return value;
        }

        static int MaximumNumber(int[] array)
        {
            int maxValue = 0;
            if (array.Length > 0)
            {
                maxValue = array[0];
                for (int i = 0; i < array.Length;i++)
                {
                    if (array[i] > maxValue) maxValue = array[i];
                }
            }
            return maxValue;
        }

        static double Power(double basis, int eksponen)
        {
            double result = 1.0;
            if (eksponen > 0)
            {
                for (int i = 0; i < eksponen; i++)
                {
                    result *= basis;
                }
            } 
            else
            {
                for (int i = 0; i > eksponen; i--)
                {
                    result /= basis;
                }
            }
            return result;
        }
    }
}
