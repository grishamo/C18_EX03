using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class Utils
    {
        public static object GetParam<T>(object[] args)
        {
            object returnInstance = null;

            foreach (object param in args)
            {
                if (param is T)
                {
                    returnInstance = param;
                    break;
                }
            }

            return returnInstance;
        }

        public static List<T> GetAllParams<T>(object[] args)
        {
            List<T> paramsList = new List<T>();

            foreach (object param in args)
            {
                if (param is T)
                {
                    paramsList.Add((T)param);
                }
            }

            return paramsList;
        }
    }
}
