using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WytwarzanieOprogramowania
{
    public class Calc
    {
        
        //Sekcja dodawania
        public static long Add(long a, long b) => a + b;
        public static int Add(int a, int b) => a + b;
        public static short Add(short a, short b) => (short)(a + b);
        public static sbyte Add(sbyte a, sbyte b) => (sbyte)(a + b);
        public static double Add(double a, double b) => a + b;
        //Sekcja odejmowania
        public static long Sub(long a, long b) => a - b;
        public static int Sub(int a, int b) => a - b;
        public static short Sub(short a, short b) => (short)(a - b);
        public static sbyte Sub(sbyte a, sbyte b) => (sbyte)(a - b);
        public static double Sub(double a, double b) => a - b;

        //Sekcja mnożenia
        public static long Multiply(long a, long b) => a * b;
        public static int Multiply(int a, int b) => a * b;
        public static short Multiply(short a, short b) => (short)(a * b);
        public static sbyte Multiply(sbyte a, sbyte b) => (sbyte)(a * b);
        public static double Multiply(double a, double b) => a * b;

        //Sekcja dzielenia
        public static long Divide(long a, long b) => a / b;
        public static int Divide(int a, int b) => a / b;
        public static short Divide(short a, short b) => (short)(a / b);
        public static sbyte Divide(sbyte a, sbyte b) => (sbyte)(a / b);
        public static double Divide(double a, double b) => a / b;
       
        /*konwersja na inny system  */
        public static string convert(long n, int sys) => Convert.ToString(n, sys);
        public static string convert(int n, int sys) => Convert.ToString(n, sys);
        public static string convert(short n, int sys) => Convert.ToString(n, sys);
        public static string convert(sbyte n, int sys) => Convert.ToString((byte)n, sys);

        //Sekcja OR
        public static long OR(long a, long b) => a | b;
        public static int OR(int a, int b) => a | b;
        public static short OR(short a, short b) => (short)(a | b);
        public static sbyte OR(sbyte a, sbyte b) => (sbyte)(a | b);

        //Sekcja AND
        public static long AND(long a, long b) => a & b;
        public static int AND(int a, int b) => a & b;
        public static short AND(short a, short b) => (short)(a & b);
        public static sbyte AND(sbyte a, sbyte b) => (sbyte)(a & b);

        //XOR
        public static long XOR(long a, long b) => a ^ b;
        public static int XOR(int a, int b) => a ^ b;
        public static short XOR(short a, short b) => (short)(a ^ b);
        public static sbyte XOR(sbyte a, sbyte b) => (sbyte)(a ^ b);

        //NOT
        public static long NOT(long a) => ~a;
        public static int NOT(int a) => ~a;
        public static short NOT(short a) => (short)~a;
        public static sbyte NOT(sbyte a) => (sbyte)~a;
        
        //Sekcja Lsh
        public static long Lsh(long a, int b) => a << b;
        public static int Lsh(int a, int b) => a << b;
        public static short Lsh(short a, int b) => (short)(a << b);
        public static sbyte Lsh(sbyte a, int b) => (sbyte)(a << b);

        //Sekcja Rsh
        public static long Rsh(long a, int b) => a >> b;
        public static int Rsh(int a, int b) => a >> b;
        public static short Rsh(short a, int b) => (short)(a >> b);
        public static sbyte Rsh(sbyte a, int b) => (sbyte)(a >> b);

        /* nowe rzeczy */
        public static long PlusMinus(long a) => -1 * a;
        public static long PlusMinus(int a) => -1 * a;
        public static long PlusMinus(short a) => -1 * a;
        public static long PlusMinus(sbyte a) => -1 * a;

        public static long Modulo(long a, long b) => a % b;
        public static long Modulo(int a, int b) => a % b;
        public static long Modulo(short a, short b) => a % b;
        public static long Modulo(sbyte a, sbyte b) => a % b;

        public static long Rol(long a) => a << 1;
        public static long Ror(long a) => a >> 1;
        public static long Rol(int a) => a << 1;
        public static long Ror(int a) => a >> 1;
        public static long Rol(short a) => a << 1;
        public static long Ror(short a) => a >> 1;
        public static long Rol(sbyte a) => a << 1;
        public static long Ror(sbyte a) => a >> 1;

        public static long pamiec;
        public static long word=0;
        public static string text;
        public static long C(long a)=> a = 0;
        public static long Mplus(long a ,long pamiec) => pamiec + a;
        public static long Mminus(long a, long pamiec) => pamiec - a;
        public static long MC(long pamiec) => pamiec = 0;

        public static string Backspace(string text) => text=text.Substring(0, text.Length - 1); 
        public static string CE(string text) => text="0";
        public static string MR(long pamiec) => text =Convert.ToString(pamiec);
        public static sbyte Byte(long b) => Convert.ToSByte(b);
        public static sbyte Byte(int b) => Convert.ToSByte(b);
        public static sbyte Byte(short b) => Convert.ToSByte(b);
        public static short Word(long b) => Convert.ToInt16(b) ;
        public static short Word(int b) => Convert.ToInt16(b);
        public static short Word(sbyte b) => Convert.ToInt16(b);
        public static int DWord(long b) => Convert.ToInt32(b);
        public static int DWord(short b) => Convert.ToInt32(b);
        public static int DWord(sbyte b) => Convert.ToInt32(b);
        public static long QWord(int b) => Convert.ToInt64(b);
        public static long QWord(short b) => Convert.ToInt64(b);
        public static long QWord(sbyte b) => Convert.ToInt64(b);
       


    }

}
