using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Sayi = new MyDictionary<int, string>();
            Sayi.Add(1 , "Bir");
            Sayi.Add(2 , "İki");
            Sayi.Add(3 , "Üç");
            Sayi.Add(4 , "Dört");
            Sayi.Add(5 , "Beş");


            Console.WriteLine(Sayi.Count);
            Console.WriteLine("************");

            Sayi.Added();

            
        }
    }

    class MyDictionary<T,V>
    {
        T[] t_array;
        V[] v_array;
       
        public MyDictionary()
        {
            t_array =new T[0];
            v_array =new V[0];
        }

        public void Add(T key, V value)
        {
            T[] tempKey = t_array;
            t_array = new T[t_array.Length + 1];

            V[] tempValue = v_array;
            v_array = new V[v_array.Length + 1];


            for (int i = 0; i < tempValue.Length; i++)
            {
                v_array[i]= tempValue[i];
                t_array[i]= tempKey[i];
            }

            v_array[v_array.Length - 1] = value;
            t_array[t_array.Length - 1] = key;
        }

        public int Count
        {
            get
            {
                return t_array.Length;
            }
        }

        public void Added()
        {
            for (int i = 0; i < v_array.Length; i++)
            {
               Console.WriteLine(t_array[i]+ " , " + v_array[i]);    
            }
        }
    }

        
    
}
