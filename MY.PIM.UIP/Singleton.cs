using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.PIM.UIP
{
    public interface ISingleton
    { }
    public sealed class Singleton<T> where T : class, ISingleton,new()
    {
        public static T Instance
        {
            get
            {
                return Nested.LazyInstance;
            }
        }

        private static class Nested
        {
            internal static readonly T LazyInstance = new T();
        }
    }
}
