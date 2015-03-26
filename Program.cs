using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
      {           
            Random r = new Random();
            int a = 0;          
            int ToplamVezirAdeti = 0;
            int TehditSayisi = 0;
            int[,] tahta= new int[8,8];
            //hepsine 0 atayalım... hepsini 0 yapan Creat() fonksiyonu
           
           do{
             // sonra yeniden içine değer atayalım 0 yada 1 yapan fonksiyon. 1 ler veziri temsil ediyor.
             for (int i = 0; i < 8; i++)
             {
                 for (int j = 0; j < 8; j++)
                 {
                     a = r.Next(2);// 0 YADA 1 ATAYACAK
                     if (a==1 && ToplamVezirAdeti <= 8) //8 tane vezir atamayı garantiler.
                     {
                         tahta[i, j] = 1;  // 1 VEZİRİ İFADE EDİYOR.
                         ToplamVezirAdeti++;
                          for (int r = 0; r < j; r++)
                          {			 
			                     if (tahta[i,j] == tahta[r,j] ||  tahta[i,j] == tahta[i,j] << tahta[i,j-r] || tahta[i,j] == tahta[r,j] >> tahta[i,j-r])
                                 {
                                       TehditSayisi++;
                                       tahta[i, j] = 1;
                                  }
                         }                        
                      }
                     else
                     {
                         tahta[i, j] = 0;
                     }

                 }
             }
              DiziYaz(tahta);            
              Console.WriteLine(TehditSayisi + " DEFA VEZİR TEHDİT EDECEK ŞEKİLDE YERLEŞMİŞTİR.");
            }while(TehditSayisi<1);

            Console.ReadKey();
     }
        public static void DiziYaz(int[,] dizi)
        {
            Console.WriteLine("Random atama işlemi");
            for (int satir = 0; satir < dizi.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < dizi.GetLength(1); sutun++)
                {
                    Console.Write("{0} ", dizi[satir, sutun]);
                }
                Console.WriteLine();
            } 
        } 
 
}  }

