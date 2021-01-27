using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WytwarzanieOprogramowania
{
    public class Calc
    {
        public static long pamiec = 0;
        public static long word = 0;
        public static string text;

        //Sekcja dodawania
        public static long Add(dynamic a, dynamic b) => a + b;

        //Sekcja odejmowania
        public static long Sub(dynamic a, dynamic b) => a - b;

        //Sekcja mnożenia
        public static dynamic Multiply(dynamic a, dynamic b) => a * b;

        //Sekcja dzielenia
        public static long Divide(dynamic a, dynamic b) => a / b;

        /*konwersja na inny system  */
        public static string convert(dynamic n, int sys)
        {
            if (n is sbyte)
                return Convert.ToString((byte)n, sys);
            return Convert.ToString(n, sys);

        }
        public static string convertToDec(string n, int sys)
        {
            return Convert.ToInt64(n, sys).ToString();
        }

        //Sekcja OR
        public static long OR(dynamic a, dynamic b) => a | b;

        //Sekcja AND
        public static long AND(dynamic a, dynamic b) => a & b;

        //XOR
        public static long XOR(dynamic a, dynamic b) => a ^ b;

        //NOT
        public static long NOT(dynamic a) => ~a;
        
        //Sekcja Lsh
        public static long Lsh(dynamic a, int b) => a << b;

        //Sekcja Rsh
        public static long Rsh(dynamic a, int b) => a >> b;
        public static string toString(dynamic a) => Convert.ToString(a);
        /* nowe rzeczy */
        public static long PlusMinus(long a) => -1 * a;
        public static long PlusMinus(int a) => -1 * a;
        public static long PlusMinus(short a) => -1 * a;
        public static long PlusMinus(sbyte a) => -1 * a;

        public static long Modulo(long a, long b) => a % b;
        public static long Modulo(int a, int b) => a % b;
        public static long Modulo(short a, short b) => a % b;
        public static long Modulo(sbyte a, sbyte b) => a % b;
        public static double Modulo(double a, double b) => a % b;

        public static long Rol(dynamic a) => Lsh(a,1);
        public static long Ror(dynamic a) => Rsh(a, 1);

        private static long clear_val() => 0;
        public static long C() => clear_val();

        public static string Backspace(string text) => text.Substring(0, text.Length - 1); 
        public static string CE() => "0";
        
        public static sbyte Byte(dynamic b) => Convert.ToSByte((sbyte)(b & ((sbyte)-1)));
        public static short Word(dynamic b) => Convert.ToInt16((short)(b & ((short)-1)));
        public static int DWord(dynamic b) => Convert.ToInt32((int)(b & (-1)));
        public static long QWord(dynamic b) => Convert.ToInt64((long)(b & ((long)-1)));

        // Memory functions
        public static void Mplus(dynamic a, ref long pamiec) => pamiec = pamiec + a;
        public static void Mminus(dynamic a, ref long pamiec) => pamiec = pamiec - a;
        public static void MC(ref long a) => a = clear_val();

    }

}
