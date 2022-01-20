namespace SakilaEFCore
{
    public class Country {

        public int Id {set; get;}
        public String Name {set; get;}
        public DateTime LastUpdate {set; get;}

        public List<City> Cities {set; get;}

        

    }
}