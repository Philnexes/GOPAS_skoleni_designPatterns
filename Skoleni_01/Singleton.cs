using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoleni_01
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> lazyInstance = new Lazy<Singleton>(()=>new Singleton(), true);
        //private static Singleton instance;
        //private static object SynchLock = new object();

        public static Singleton Instance
        {
            get
            {
                /*
                  if(Instance == null)
                    lock(SynchLock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                return instance;
                */
                return lazyInstance.Value;
            }
        }

        private Singleton() { }
        public void DoStuff()
        {
            Console.WriteLine("Doing stuff..");
        }
    }
}