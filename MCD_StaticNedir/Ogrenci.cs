﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticNedir
{
    public class Ogrenci
    {

        public string Isim { get; set; }
        public string  Soyisim { get; set; }
        public string  EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot..");
            Test2();
            //Static olmayan bir metot static olan bir metodu çağırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN kullanılabilir.");
            // Test1(); 
            // Static olan bir metot static olmayan bir metotu vb. çağıramaz.
        }
    }
}
