using System;
using Week6.SupermercatoEF.Context;

namespace Week6.SupermercatoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new SupermercatoContext())
            {
                ctx.Database.EnsureCreated();
            }
        }

     
    }
}
