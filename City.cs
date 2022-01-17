using System;

namespace EfCore
{
    public class City
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public int CountryId { set; get; }
        public Country Country { set; get; }

    }
}
    