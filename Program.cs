using System;
namespace Exercise {
    public class StudentCode {
        public static int DoubleMe(int number){
            return number*2;
        }
        public static int QuadrupleMe(int number){
            return DoubleMe(DoubleMe(number));
        }
        public static int DoubleNumberMultipleTimes(int number1 , int number2){
            for(int i =0; i < number2; i++){
                number1*=2;
            }
            return number1;
        }
    }
    class Program{
        static void Main(string[] args ){
            Console.WriteLine("Doubled Number: "+StudentCode.DoubleMe(2));
            Console.WriteLine("Quadrupled Number: "+StudentCode.QuadrupleMe(2));
            Console.WriteLine("Quadrupled Number: "+StudentCode.DoubleNumberMultipleTimes(2,3));
        }
    }
}