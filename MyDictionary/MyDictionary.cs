using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,Q>
    {
        T[] takim ;
        Q[] oyuncu;
        public MyDictionary()
        {
            takim = new T[0];
            oyuncu = new Q[0];

           
        }
        T[] temptakim;
        Q[] tempoyuncu;
        public void Add (T takim1 , Q oyuncu1)
        {
            temptakim = takim;
            tempoyuncu = oyuncu;

            takim = new T[takim.Length + 1];
            oyuncu = new Q[oyuncu.Length + 1];

            for(int i = 0; i<temptakim.Length; i++)
            {
                takim[i] = temptakim[i];
            }
            for (int i = 0; i < temptakim.Length; i++)
            {
                oyuncu[i] = tempoyuncu[i];
            }

            takim[takim.Length - 1] = takim1;
            oyuncu[oyuncu.Length - 1] = oyuncu1;
        }
        public void Ekran()
        {
            for (int i = 0; i < takim.Length; i++)
            {
                Console.WriteLine("takım: " + takim[i] + "---" + " oyuncu: " + oyuncu[i]);
            }
        }
        public void Count()
        {
            Console.WriteLine(takim.Length);
        }


    }

      
}
