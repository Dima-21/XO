using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _Weather
{
    class Weather
    {
        XmlTextReader reader = new XmlTextReader("APIWeather.xml");
        public void WeatherDay()
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                    if (reader.Name.Equals("day"))
                    {
                        string date = reader.GetAttribute("value");
                        date = date.Insert(4, ".");
                        date = date.Insert(7, ".");
                        Console.WriteLine($"{reader.GetAttribute("name")} {date}");
                    }
                if (reader.Name.Equals("tempmin"))
                    Console.WriteLine($"Мин. тепмература:{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                if (reader.Name.Equals("tempmax"))
                {
                    Console.WriteLine($"Макс. тепмература:{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                    break;
                }
               
            }
        }
        public void WeatherNow()
        {
            while (reader.Read())
            {
                Console.WriteLine("Погода");
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("day"))
                    {
                        Console.WriteLine();
                        string date = reader.GetAttribute("value");
                        date = date.Insert(4, ".");
                        date = date.Insert(7, ".");
                        Console.WriteLine($"{reader.GetAttribute("name")} {date}");
                    }
                   
                }
            }
        }

    }
}
