using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class HexagonFactory
    {
        IDictionary<string, Hexagon> flyDico =
            new Dictionary<string, Hexagon>();


        public Hexagon getHexagons(string fieldType)
        {
            Hexagon res;
            bool test = flyDico.TryGetValue(fieldType, out res);
            if( test )
            {
                return res;               
            }
            switch (fieldType)
            {
                case "Desert":
                    res = new Desert();
                    break;
                case "Mountain":
                    res = new Mountain();
                    break;
                case "Plain":
                    res = new Plain();
                    break;
                case "Woods":
                    res = new Woods();
                    break;
            }
            return res;
        }
    }
}
