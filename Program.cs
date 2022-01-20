using System;
using Microsoft.EntityFrameworkCore;

namespace SakilaEFCore
{

    class MyApp
    {
        public static void Main(string[] args)
        {
            SakilaContext context = new SakilaContext(); 
            
            var countries = context.Countries.Include(c=>c.Cities).ToList();  
            var cities = context.Cities.Include(c=>c.Country).ToList(); 

        }
    }


}