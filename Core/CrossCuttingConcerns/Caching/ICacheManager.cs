using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    // Verileri Db yerine geçici olarak memory'de tutarız.
    public interface ICacheManager
    {
        /* Key,Value
         Key -> Cache'e verdiğimiz isim.
         */
        T Get<T>(string key); //Liste ya da tek bir değer olabileceği için generic değer veririz.
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key); //Cash de var mı ? Yoksa Db'den ekle.
        void Remove(string key);
        void RemoveByPattern(string pattern); //Çalışma anında bellekten silmeye yarar. (Reflection)
    }
}
