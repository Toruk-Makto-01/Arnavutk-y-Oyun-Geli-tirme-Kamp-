using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCode : MonoBehaviour
{

    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        //Say� listesi olu�turuldu
        ArrayList sayiListe = new ArrayList();

        //��kt� ald���m�zda say�lar� alt alta yerine yan yana s�ralanmas� i�in string de�i�kenleri olu�turuldu
        string tamListe = "Tam Liste =";
        string ikiyeBolunen = "2'ye Tam B�l�nenler =";
        string uceBolunen = "3'e Tam B�l�nenler =";
        string dordeBolunen = "4'e Tam B�l�nenler =";
        string beseBolunen = "5'e Tam B�l�nenler =";

        //Girilen ilk de�erden ikinci de�ere kadar olan say�lar� listeye ekleyen ifade
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            sayiListe.Add(i);
        }

        //Listedeki say�lar� ilgili de�i�kenlere atayan ifade
        foreach (int eleman in sayiListe)
        {
            tamListe += "," + eleman;

            if (eleman % 2 == 0)//Liste i�erisindeki 2'ye tam b�l�nen say�lar� ikiyeBolunen de�i�kenine atayan ifade
            {
                ikiyeBolunen += "," + eleman;
            }
            if (eleman % 3 == 0)//Liste i�erisindeki 3'e tam b�l�nen say�lar� uceBolunen de�i�kenine atayan ifade
            {
                uceBolunen += "," + eleman;
            }
            if (eleman % 4 == 0)//Liste i�erisindeki 4'e tam b�l�nen say�lar� dordeBolunen de�i�kenine atayan ifade
            {
                dordeBolunen += "," + eleman;
            }
            if (eleman % 5 == 0)//Liste i�erisindeki 5'e tam b�l�nen say�lar� beseBolunen de�i�kenine atayan ifade
            {
                beseBolunen += "," + eleman;
            }
        }
        //Say�lar� string olarak yazd�ran methodlar
        print(tamListe);
        print(ikiyeBolunen);
        print(uceBolunen);
        print(dordeBolunen);
        print(beseBolunen);



    }
    //Say�lar� unity i�erisinden de�i�tirebilmek i�in de�i�kenler public olarak yaz�ld�
    public int a = 10;
    public int b = 50;

    private void Start()
    {
        //Fonksiyonu �al��t�r�r
        bolenleriBul(a, b);

    }

}

