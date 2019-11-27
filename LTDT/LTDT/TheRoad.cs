using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT
{
    class TheRoad
    {
        int[,] map;
        int[,] cost;
        int[] road;
        int[] traverse;
        int[,] minRoad;
        int[,] truoc;
        int[,] minCost;
        int startPoint;
        int ends;
        int cash;
        int roadsAmount;
        int citysAmount;
        int roadsCount;
        int[] x; int[] y;

        #region propertie
        public int[,] Map { get => map; set => map = value; }
        public int[,] Cost { get => cost; set => cost = value; }
        public int[] Road { get => road; set => road = value; }
        public int[] Traverse { get => traverse; set => traverse = value; }
        public int StartPoint { get => startPoint; set => startPoint = value; }
        public int Ends { get => ends; set => ends = value; }
        public int Cash { get => cash; set => cash = value; }
        public int RoadsAmount { get => roadsAmount; set => roadsAmount = value; }
        public int RoadsCount { get => roadsCount; set => roadsCount = value; }
        public int CitysAmount { get => citysAmount; set => citysAmount = value; }
        public int[,] MinRoad { get => minRoad; set => minRoad = value; }
        public int[,] Truoc { get => truoc; set => truoc = value; }
        public int[] X { get => x; set => x = value; }
        public int[] Y { get => y; set => y = value; }
        public int[,] MinCost { get => minCost; set => minCost = value; }
        #endregion

        public TheRoad(int _startPoint, int _ends, int _cash, int _cityAmount, int _roadsAmount)
        {
            Map = new int[_cityAmount, _cityAmount];
            Cost = new int[_cityAmount, _cityAmount];
            CitysAmount = _cityAmount;
            X = new int[_cityAmount];
            Y = new int[_cityAmount];
            minRoad = new int[_cityAmount, _cityAmount];
            minCost = new int[_cityAmount, _cityAmount];
            truoc = new int[_cityAmount, _cityAmount];
            createMap(_cityAmount);
            
            
            Road = new int[_cityAmount];
            Traverse = new int[_cityAmount];

            startTraverse();

            RoadsAmount = _roadsAmount;
            StartPoint = _startPoint;
            Ends = _ends;
            Cash = _cash;
            RoadsCount = 0;
        }

        public void startTraverse()
        {
            for (int i = 0; i < Traverse.Length; i++)
            {
                Traverse[i] = 0;
            }
        }

        public void createPosition()
        {
            Random r = new Random();
            for(int i = 0; i< citysAmount; i++)
            {
                if (x[i] == 0)
                {
                    Y[i] = r.Next(0, 450);
                    X[i] = r.Next(0, 550);
                }
            }
        }

        public void createMap(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    truoc[i, j] = i;
                    if (i != j)
                    {
                        Map[i, j] = int.MaxValue;
                        Cost[i, j] = int.MaxValue;
                        minRoad[i, j] = int.MaxValue;
                        minCost[i, j] = int.MaxValue;
                    }
                    else
                    {
                        MinRoad[i, j] = 0;
                        MinCost[i, j] = 0;
                        Map[i, j] = 0;
                        Cost[i, j] = 0;
                    }
                }
                x[i] = 0;
                y[i] = 0;
            }
        }

        public void findTheMinCost()
        {
            for (int k = 0; k < citysAmount; k++)
            {
                for (int i = 0; i < citysAmount; i++)
                {
                    for (int j = 0; j < citysAmount; j++)
                    {
                  //      MessageBox.Show("i = " + i + " j =" + j + " k = " + k + " MinRoad[i, j] =" + MinRoad[i, j] + " MinRoad[k, j]=" + MinRoad[k, j] + " MinRoad[i, k]=" + MinRoad[i, k]);
                        if (MinCost[i, j] > MinCost[k, j] + MinCost[i, k] && i != j && MinCost[k, j] != int.MaxValue && MinCost[i, k] != int.MaxValue)
                        {
                            MinCost[i, j] = MinCost[k, j] + MinCost[i, k];
                            Truoc[i, j] = truoc[k, j];
                        }
                    }
                }
            }
        }

        public void findTheMinRoad()
        {
            for (int k = 0; k < citysAmount; k++)
            {
                for (int i = 0; i < citysAmount; i++)
                {
                    for (int j = 0; j < citysAmount; j++)
                    {
                        //      MessageBox.Show("i = " + i + " j =" + j + " k = " + k + " MinRoad[i, j] =" + MinRoad[i, j] + " MinRoad[k, j]=" + MinRoad[k, j] + " MinRoad[i, k]=" + MinRoad[i, k]);
                        if (MinRoad[i, j] > MinRoad[k, j] + MinRoad[i, k] && i != j && MinRoad[k, j] != int.MaxValue && MinRoad[i, k] != int.MaxValue)
                        {
                            MinRoad[i, j] = MinRoad[k, j] + MinRoad[i, k];
                        }
                    }
                }
            }
        }

        public void DFS(int i)
        {
            Traverse[i] = 1;
            for (int j = 0; j < CitysAmount; j++)
            {
                if (Traverse[j] == 0 && Cost[i, j] != 0 && Cost[i, j] != int.MaxValue)
                {
                    DFS(j);
                }
            }
        }

        public void result()
        {
            int tg = ends;
            road[roadsCount] = ends;
            roadsCount++;
            while (tg != startPoint)
            {
                road[roadsCount] = truoc[startPoint, tg];
                tg = road[roadsCount];
                roadsCount++;
            }
            int[] roadtg = new int[roadsCount];
            for(int i = 0; i < roadsCount; i++)
            {
                roadtg[i] = road[i];
            }
            int j = 0;
            for(int i = roadsCount-1; i >= 0; i--)
            {
                road[j] = roadtg[i];
                j++;
            }
        }
    }
}
