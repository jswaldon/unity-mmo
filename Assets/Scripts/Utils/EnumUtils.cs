using System;

namespace UnityNetcodeIO
{
    public class EnumUtils
    {
        public static string ToString<T>(T type)
        {
            return Enum.Parse(typeof(T), type.ToString()).ToString();
        }
    }
}