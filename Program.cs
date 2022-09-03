using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif
            Islemler islem =new Islemler();
            Console.WriteLine(islem.Expo(3,4));

            //extension metotlar
            string ifade ="Deneme Ornek";
            bool sonuc=ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
            }

            int[] dizi={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi=5;
            Console.WriteLine(sayi.IsEvenNumber());
            
        

        }
    }

    public class Islemler{

        public int Expo(int sayi,int üs){

            if(üs<2)
            return sayi;

            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3) * 3 
        //Expo(3,2) * 3 * 3
        //Expo(3,1) * 3 * 3 * 3
        //3 * 3 * 3 * 3 = 3^4

    }

    public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param ){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param ){
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param ){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){
            foreach(var item in param)
            Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param){
            return param%2==0;
        }
    }
}