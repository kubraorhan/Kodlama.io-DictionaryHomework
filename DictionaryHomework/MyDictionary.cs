using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    public class MyDictionary<Tkey,TValue>
    {
        Tkey[] keys;
        TValue[] values;
        public MyDictionary()
        {
           keys = new Tkey[0];
           values = new TValue[0];
        }
        public void Add(Tkey key, TValue value)
        {
            var TempKeyArray = keys;
            keys = new Tkey[keys.Length + 1];

            var TempValueArray = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < TempKeyArray.Length; i++)
            {
                keys[i] = TempKeyArray[i];
                values[i] = TempValueArray[i];
            }


            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine(key + ".value is " +value);
            
        }

        
    }
}
