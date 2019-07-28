using System;
namespace DesignPattern.Creational.SingleTon
{
    public class SingleTon
    {
        private static SingleTon instance;
        private static object syncLock = new object();
        private SingleTon()
        {

        }

        public static SingleTon GetSingleTon()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                        instance = new SingleTon();
                }
            }
            return instance;
        }

    }


}