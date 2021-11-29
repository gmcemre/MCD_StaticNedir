using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Static: Nesne örneği alınmadan ulaşabildiğimiz metot , field , sınıf...
             * Tip M1 = new Tip();
             * Tip.
             */

            //Stack bölge içerisinde pointer ımız oluştu...
            Ogrenci o1;
            //Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();

            o1 = new Ogrenci();
            //Stack bölgede pointer => kendisini heap bölgede tamamladı..Static olmayan tanımlarını tamamladı..
            o1.Test1(); //Nesne örneği alındıktan sonra Test1 adındaki metoduma ulaşabildim.

            /*Static kavramı gerçek hayatta nerelerde kullanılır...
             * 
             * 1- Helper.cs => Kontroller
             * 2- Oluşturmuş olduğunuz nesnemizin  => bağımlılığı farklı class lara olduğu için (proje içerisinde özel olduğu için) nesne içerisinde static metot tanımları yapılır.
             * 3- Class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer ataması yaparız.Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır, değerimizi okuruz.
             * 4- [ Uygulama ] => [ ozelHelper] => [DLL]
             * 
             */
        }
    }
}
