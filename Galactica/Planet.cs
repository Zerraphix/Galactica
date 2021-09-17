using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    public enum PlanetType { Moon, Terrestial, Giant, Dwarf, Gas_Giant }
    class Planet : SpaceObjects
    {
        public PlanetType Type {  get; set; }
        public double Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }

        public List<Moon> MoonList = new List<Moon>();
        public int Distance(Star star)
        {
            return (int)Math.Sqrt(Math.Pow(star.position.x - position.x,2) + Math.Pow(star.position.y - position.y,2));
        }
    }
}
