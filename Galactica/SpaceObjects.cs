using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Position position {  get; set; }

        public class Position
        {
        public int x { get; set; }
        public int y { get; set; }

            public override string ToString()
            {
                return $"({x},{y})";
            }
        }
       
    }
}

