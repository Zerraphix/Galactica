using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    class Star : SpaceObjects
    {

        public StarType Type { get; set; }
        public int Temperature { get; set; }

        public List<Planet> PlanetList = new List<Planet>();

        public Position _Position
        {
            get { return new Position() { x = 0, y = 0 }; }            
        }
    }
}
