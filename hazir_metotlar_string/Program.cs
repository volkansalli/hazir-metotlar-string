using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string kütüphanesini tanıyalım");
            
            string dizi="sen ben o";
            //string dizi2="sen siz onlar";
            string dizia="a";
            string diziA="A";
            string[] isimler={"ahmet","mehmet","volkan","Murat","salih"};

            Console.WriteLine(dizi.Length);
            Console.WriteLine(dizi.ToUpper());
            Console.WriteLine(dizi.ToLower());
            Console.WriteLine(String.Concat(dizi," Merhaba"," ben saadettin teksoy","fgfgf","sddggg","fdfgjfdydjyd"));
            Console.WriteLine(dizi);

            Console.WriteLine("**** dizi.CompareTo *******");            
            Console.WriteLine(dizia.CompareTo(diziA));
            Console.WriteLine(diziA.CompareTo(dizia));
            
            Console.WriteLine("**** String.Compare *******");
            Console.WriteLine(String.Compare(dizia,diziA,true));
            Console.WriteLine(String.Compare(diziA,dizia,false));
            Console.WriteLine(String.Compare(diziA,dizia));

            Console.WriteLine("**** Array.Sort *******");
            Array.Sort(isimler);
            for(int i=0;i<isimler.Length;i++)
            Console.WriteLine(isimler[i]);
            
            Console.WriteLine("**** dizi.Contains ******");
            //string[] cumle={"haydi","söyle","seni","nasıl","sevdiğimi"}; array oldumu containi kabul etmiyor.

            string cumle="haydi söyle seni nasıl sevdiğimi";
            string[] nebucadnezar={"dün","bir","rüya","gördüm",".","bugün","unuttum"};
            string degisken="söyle";
            string degisken2="sessiz";
            Console.WriteLine(cumle.Contains(degisken));

            Console.WriteLine("**** dizi.EndWith/Startswith ******");
            Console.WriteLine(cumle.StartsWith("h"));
            Console.WriteLine(cumle.StartsWith("haydi"));
            Console.WriteLine(cumle.EndsWith("iğimi"));
            Console.WriteLine(cumle.EndsWith("hohoho"));

            Console.WriteLine("**** dizi.Indexof ******");
            Console.WriteLine(cumle.IndexOf("söy"));
            Console.WriteLine(cumle.IndexOf("sö"));
            Console.WriteLine(cumle.IndexOf("s"));
            Console.WriteLine(cumle.IndexOf("öy"));
            Console.WriteLine(cumle.IndexOf("söz"));
            Console.WriteLine(cumle.LastIndexOf("i"));
            
            Console.WriteLine(nebucadnezar[0].IndexOf("d"));

            Console.WriteLine("**** Padleft//Padright ******");
            Console.WriteLine(nebucadnezar[0].IndexOf("d"));
            Console.WriteLine(degisken.PadRight(10,'*')+degisken2.PadRight(10,'*'));

            Console.WriteLine("**** dizi.remove ******");
            Console.WriteLine(degisken.Remove(0,1));
            Console.WriteLine(degisken.Remove(3,2));
            
            Console.WriteLine("**** dizi.Replace ******");
            Console.WriteLine(cumle.Replace("haydi","şimdi"));
            string degisken3="sadfdfgfgdggaasassssaasa";
            Console.WriteLine(degisken3.Replace("sa","uu"));

            Console.WriteLine("**** dizi.Split() ******");
            Console.WriteLine(cumle.Split(" ")[0]);

            Console.WriteLine("**** dizi.Substring() ******");
            Console.WriteLine(cumle.Substring(4));
            Console.WriteLine(cumle.Substring(4,6));

            Console.WriteLine("**** string[].join ******");
            Console.WriteLine(string.Join("*",nebucadnezar));
            Console.WriteLine(string.Join(" ",nebucadnezar));
            Console.WriteLine(string.Join("",nebucadnezar));





            









            
        }
    }
}
