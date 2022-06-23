using CompanyCup.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCup.helpers
{
    public static class ShortestPath
    {
        /*
           {1,0,5,0,5
            1,1,10,10,15
            0,15,10,0,1}
         */

        public static List<List<int>> GetShortestPath(World world, int x, int y, int sizeX, int sizeY, List<List<int>> stuff)
        {
            if (stuff == null)
                stuff = new List<List<int>>();

            stuff.Add(new List<int> { x, y });

            if (x == sizeX - 1 && y == sizeY - 1)
            {
                return stuff;
            }

            if (x == sizeX - 1)
            {
                return GetShortestPath(world, x, y + 1, sizeX, sizeY, stuff);
            }

            if (y == sizeY - 1)
            {
                return GetShortestPath(world, x + 1, y, sizeX, sizeY, stuff);
            }

            if ((int)world.Lanscape[x + 1][y] <= (int)world.Lanscape[x][y + 1])
            {
                return GetShortestPath(world, x + 1, y, sizeX, sizeY, stuff);

            }
            else
            {

                return GetShortestPath(world, x, y + 1, sizeX, sizeY, stuff);
            }
        }


    }
}
