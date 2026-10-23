using System;
using System.Text;

public class HelloWorld {
    public static void Main(string[] args) {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

Random rnd = new Random();
        int sayi  = rnd.Next(1, 36);
        int deneme = 0;
        int tahmin;
        string izmirMarsi = @"İzmir'in dağlarında çiçekler açar,
Altın güneş orda sırmalar saçar
Bozulmuş düşmanlar, hep yel gibi kaçar,
Yaşa Mustafa Kemal Paşa yaşa;
Adın yazılacak mücevher taşa.

İzmir'in dağlarına bomba koydular,
Türk'ün sancağını öne koydular.
Şanlı zaferlerle düşmanı boğdular,
Kader böyle imiş ey garip ana;
Kanım feda olsun güzel vatana.

İzmir'in dağlarında oturdum kaldım;
Şehit olanları deftere yazdım,
Öksüz yavruları bağrıma bastım,
Kader böyle imiş ey garip ana;
Kanım feda olsun güzel vatana.

Peygamber kucağı şehitler yeri,
Çalındı borular haydi ileri.
Bozuldu çadırlar kalmayın geri,
Yaşa Mustafa Kemal Paşa yaşa;
Adın yazılacak mücevher taşa.

Türk oğluyum ben ölmek isterim;
Toprak diken olsa yatağım yerim;
Allah'ından utansın dönenler geri;
Yaşa Mustafa Kemal Paşa yaşa.
Adın yazılacak mücevher taşa.";
        
do
{
        
        Console.Write("tahmin gir:");
        tahmin = Convert.ToInt32(Console.ReadLine());

        deneme++;
        
        if (tahmin == sayi)
            Console.Write(izmirMarsi);
    
        else if (tahmin < sayi)
            Console.Write("kucuk tahmin\n");
    
        else if (tahmin > sayi)
            Console.Write("buyuk tahmin\n");
    
        else
            Console.Write("L\n");

        Console.Write($"\ndeneme:{deneme}\n");
    
}
    
        while(tahmin!= sayi);
        
        Console.Write($"\nsayi:{sayi}\n");
        
    }
}
