using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCode : MonoBehaviour
{

    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        //Sayý listesi oluþturuldu
        ArrayList sayiListe = new ArrayList();

        //Çýktý aldýðýmýzda sayýlarý alt alta yerine yan yana sýralanmasý için string deðiþkenleri oluþturuldu
        string tamListe = "Tam Liste =";
        string ikiyeBolunen = "2'ye Tam Bölünenler =";
        string uceBolunen = "3'e Tam Bölünenler =";
        string dordeBolunen = "4'e Tam Bölünenler =";
        string beseBolunen = "5'e Tam Bölünenler =";

        //Girilen ilk deðerden ikinci deðere kadar olan sayýlarý listeye ekleyen ifade
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            sayiListe.Add(i);
        }

        //Listedeki sayýlarý ilgili deðiþkenlere atayan ifade
        foreach (int eleman in sayiListe)
        {
            tamListe += "," + eleman;

            if (eleman % 2 == 0)//Liste içerisindeki 2'ye tam bölünen sayýlarý ikiyeBolunen deðiþkenine atayan ifade
            {
                ikiyeBolunen += "," + eleman;
            }
            if (eleman % 3 == 0)//Liste içerisindeki 3'e tam bölünen sayýlarý uceBolunen deðiþkenine atayan ifade
            {
                uceBolunen += "," + eleman;
            }
            if (eleman % 4 == 0)//Liste içerisindeki 4'e tam bölünen sayýlarý dordeBolunen deðiþkenine atayan ifade
            {
                dordeBolunen += "," + eleman;
            }
            if (eleman % 5 == 0)//Liste içerisindeki 5'e tam bölünen sayýlarý beseBolunen deðiþkenine atayan ifade
            {
                beseBolunen += "," + eleman;
            }
        }
        //Sayýlarý string olarak yazdýran methodlar
        print(tamListe);
        print(ikiyeBolunen);
        print(uceBolunen);
        print(dordeBolunen);
        print(beseBolunen);



    }
    //Sayýlarý unity içerisinden deðiþtirebilmek için deðiþkenler public olarak yazýldý
    public int a = 10;
    public int b = 50;

    private void Start()
    {
        //Fonksiyonu çalýþtýrýr
        bolenleriBul(a, b);

    }

}

