using System;
using System.Reflection;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class Singelton<T>
        where T: class
    {
        private static readonly object sr_LockKey = new object();
        private static T s_Instance = null;

        private Singelton() {}

        public static T Instance
        {
            get {
                if (s_Instance == null)
                {
                    lock (sr_LockKey)
                    {
                        if (s_Instance == null)
                        {
                            Type instanceType = typeof(T);

                            // Invoke private constructor of T
                            s_Instance = instanceType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null).Invoke(null) as T;
                        }
                    }
                }
                return s_Instance;
            }

        }
    }
}
