using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BattleShip
    {
        public Action OnShipDeployFinished;

        private int[,] playerMatrix = new int[10, 10];
        private int[,] computerMatrix = new int[10, 10];
        private int[,] playerGuessMatrix = new int[10, 10];
        private int[,] computerGuessMatrix = new int[10, 10];

        private int playerShipCount = 5;
        private int computerShipCount = 5;
        private int playerShipDeploy = 0;

        public bool AddShip(int pY, int pX)
        {
            bool check = false;

            if (playerMatrix[pY, pX] == 0)
            {
                playerMatrix[pY, pX] = 1;
                playerShipDeploy++;
                check = true;

                if (playerShipDeploy == playerShipCount)
                {
                    AddPCShips();
                    //onshipdeployfinished.invoke();
                    if (OnShipDeployFinished != null)
                    {
                        OnShipDeployFinished();
                    }


                }
            }
            return check;
        }

        private void AddPCShips()
        {
            Random rnd = new Random();

            int shipDeployed = 0;
            while (shipDeployed != computerShipCount)
            {
                int x = rnd.Next(0, 10);
                int y = rnd.Next(0, 10);

                if (computerMatrix[y, x] == 0)
                {
                    computerMatrix[y, x] = 1;
                    shipDeployed++;
                }

            }

        }
    }
}