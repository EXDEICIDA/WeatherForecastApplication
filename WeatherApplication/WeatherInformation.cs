using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication
{
    internal class WeatherInformation
    {

        //We are creating exact same clases in the api call
        public class coord 
        {
            //property one for the longitude
            //property two for latitude
           public double lon { get; set; }
           public double lat { get; set; }
        }

        public class weather
        {
            //in this class we have main , description and icon so we will create them

           public string main {  get; set; }
           public string description { get; set; }
           public string icon { get; set; }

        }

        public class main 
        {
          public  double temp { get; set; }
          public   double pressure { get; set; }
          public  double humidity { get; set; }
        }

        public class wind 
        {
          public  double speed { get; set; }

        }

        public class sys
        {
          public long sunrise { get; set; }
           public long sunset { get; set; }
        }

        public class root
        {
            //a root class for all classes
          public coord coord { get; set; }
          public List <weather> weather { get; set;}
          public main main { get; set; }
          public wind wind { get; set; }
          public sys sys { get; set; }





        }





    }
}
