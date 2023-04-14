using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class HouseBuilder
    {
        private House house;

        public HouseBuilder()
        {
            house = new House();
        }

        public void SetSize(string size)
        {
            house.size = size;
        }

        public void SetMaterial(string material)
        {
            house.material = material;
        }

        public void SetHeight(string height)
        {
            house.height = height;
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
