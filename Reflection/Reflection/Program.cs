using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Type listType = typeof(List<int>);
            Type[] parameterTypes = { typeof(int) };
            MethodInfo addMethod = listType.GetMethod("Add", parameterTypes);
            for (int i = 0; i < 9; i++)
            {
                addMethod.Invoke(list, new object[] { i });
            }
        }
    }
}
