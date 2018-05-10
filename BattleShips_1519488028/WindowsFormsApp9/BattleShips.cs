using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int pX, int pY)
        {
            X = pX;
            Y = pY;
        }
    }

    public class BattleShips
    {
        public Action OnShipDeployFinished;
        public Action<bool> OnGameEnd;

        private int[,] playerMatrix = new int[10,10];
        private int[,] computerMatrix = new int[10, 10];
        private int[,] playerGuessMatrix = new int[10, 10];
        private int[,] computerGuessMatrix = new int[10, 10];

        private List<Point> computerGuessList = new List<Point>();

        private int playerShipCount = 5;
        private int computerShipCount = 5;
        private int playerShipDeploy = 0;

        public BattleShips()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Point point = new Point(i, j);
                    computerGuessList.Add(point);
                }
            }
        }

        public bool AddShip(int pX, int pY)
        {
            bool check = false;

            if (playerShipDeploy == playerShipCount)
            {
                return check;
            }

            if (playerMatrix[pY, pX] == 0)
            {
                playerMatrix[pY, pX] = 1;
                playerShipDeploy++;
                check = true;

                if (playerShipDeploy == playerShipCount)
                {
                    AddPcShips();
                    OnShipDeployFinished?.Invoke();
                }
            }

            return check;
        }

        public bool PlayerAttack(int pX, int pY, out int pShip)
        {
            pShip = 0;
            if (playerGuessMatrix[pY, pX] > 0) return false;
            
            int ship = computerMatrix[pY, pX];
            if (ship == 0)
            {
                playerGuessMatrix[pY, pX] = 10;
            }
            else
            {
                playerGuessMatrix[pY, pX] = ship;
                computerShipCount--;
                if (computerShipCount == 0)
                {
                    OnGameEnd?.Invoke(true);
                }
            }
            pShip = ship;
            return true;
        }

        public int PcAttack(out int pX, out int pY)
        {
            Random rnd = new Random();
            int ship = 0;

            int index = rnd.Next(0, computerGuessList.Count);
            Point point = computerGuessList[index];
            pX = point.X;
            pY = point.Y;
            computerGuessList.RemoveAt(index);
            ship = playerMatrix[point.Y, point.X];
            if (ship == 0)
            {
                computerGuessMatrix[point.Y, point.X] = 10;
            }
            else
            {
                computerGuessMatrix[point.Y, point.X] = ship;
                playerShipCount--;
                if (playerShipCount == 0)
                {
                    OnGameEnd?.Invoke(false);
                }
            }

            return ship;
        }

        private void AddPcShips()
        {
            Random rnd = new Random();

            int shipDeployed = 0;
            while (shipDeployed != computerShipCount)
            {
                int x = rnd.Next(0, 10);
                int y = rnd.Next(0, 10);

                if(computerMatrix[y,x] == 0)
                {
                    computerMatrix[y, x] = 1;
                    shipDeployed++;
                }
            }
        }
    }
}
