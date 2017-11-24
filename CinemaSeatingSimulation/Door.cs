using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Door
    {
        private int dWidth, dHeight, posX, posY;


        public Door(int dWidth, int dHeight, int posX, int posY)
        {
            this.dWidth = dWidth;
            this.dHeight = dHeight;
            this.posX = posX;
            this.posY = posY;
        }

        public int DWidth
        {
            get { return this.dWidth; }
            //set { dWidth = value; }
        }
        public int DHeight
        {
            get { return this.dHeight; }
            //set { dHeight = value; }
        }

        public int PosX
        {
            get { return this.posX; }
            //set { posX = value; }
        }
        public int PosY
        {
            get { return this.posY; }
            //set { posY = value; }
        }
    }
}
