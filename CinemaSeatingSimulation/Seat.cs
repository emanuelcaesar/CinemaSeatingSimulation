﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Seat
    {

        private string seatId;
        private int posX, posY, sHeight, sWidth, position=-1;
        private System.Drawing.Color seatColor;

        public Seat()
        {
        }

		public Seat(int posX, int posY)
		{
			this.posX = posX;
			this.posY = posY;
		}

        public Seat(string seatId, int posX, int posY, int height, int width)
        {
            this.seatId = seatId;
            this.posX = posX;
            this.posY = posY;
            this.sHeight = height;
            this.sWidth = width;
            this.seatColor = System.Drawing.Color.Maroon;
        }

        public string SeatId
        {
            get { return this.seatId; }
            set { seatId = value; }
        }
        public int PosX
        {
            get { return this.posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return this.posY; }
            set { posY = value; }
        }

        public int SHeight
        {
            get { return this.sHeight; }
            set { sHeight = value; }
        }

        public int SWidth
        {
            get { return this.sWidth; }
            set { sWidth = value; }
        }

        public System.Drawing.Color SeatColor
        {
            get { return this.seatColor; }
            set { seatColor = value; }
        }
	}   

}
