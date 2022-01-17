using System;


namespace EfCore
{

    class MyApp
    {
        public static void Main(string[] args)
        {
            SakilaContext context = new SakilaContext(); 
            var h = context.Countries.ToList();                     
        }
    }


}