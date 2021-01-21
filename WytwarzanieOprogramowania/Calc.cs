using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WytwarzanieOprogramowania
{
    public class Calc
    {
        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;

        public static double Add(double a, double b) => a + b;
        public static double Sub(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => a / b;
        /*konwersja z dec na inny system przyjmujemy liczbe zwracamy tablice intow  */
        public static int[] dectobin(int n) {
            int i;
            int[] a = new int[10];
         
            for (i = 0; n > 0; i++)
            {
                /*bity sa zapisywane od tyłu w każdej konwersji*/
                a[i] = n % 2;
                n = n / 2;
            }
            return a;
        }

        public static int[] dectookt(int n)
        {
            int i;
            int[] a = new int[10];

            for (i = 0; n > 0; i++)
            {
                a[i] = n % 8;
                n = n / 8;
            }
            return a;
        }

        public static int[] dectohex(int n)
        {
            int i;
            int[] a = new int[10];

            for (i = 0; n > 0; i++)
            {
                a[i] = n % 16;
                n = n / 16;
            }
            return a;
        }
        /*konwersja z innego systemu na dec przyjmujemy tablice intów zwracamy inta */
        public static int bintodec(int[] n)
        {
            int i;
            int a=0;
            int rozmiar = n.Length;
            for (i = 0; i<rozmiar; i++)
            {
                a += n[i] * 2 ^ i;
            }
            return a;
        }
        public static int okttodec(int[] n)
        {
            int i;
            int a = 0;
            int rozmiar = n.Length;
            for (i = 0; i<rozmiar; i++)
            {
                a += n[i] * 8 ^ i;
            }
            return a;
        }

        public static int hextodec(int[] n)
        {
            int i;
            int a = 0;
            int rozmiar = n.Length;
            for (i = 0; i < rozmiar; i++)
            {
                a += n[i] * 16 ^ i;
            }
            return a;
        }
        /*(a i b to liczby decymalne bitowe hex i okt zapisane jako int*/ 
        public static int OR(int a, int b) => a | b;
        public static int AND(int a, int b) => a & b;
        public static int XOR(int a, int b) => a ^ b;
        public static int NOT(int a) => ~a;
        /*(a  to liczba decymalna bitowa hex i okt zapisana jako int a b  to o ile bitów przesuwamy*/
        public static int Lsh(int a, int b) => a << b;
        public static int Rsh(int a, int b) => a >> b;
    }

}
