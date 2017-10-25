using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeatingSimulation
{
    public partial class FormLayoutTry1 : Form
    {
        public FormLayoutTry1()
        {
            InitializeComponent();
        }

        List<Panel> users = new List<Panel>();
        List<Seat> seatList = new List<Seat>();
        private int x, y, height, width;
        private Color seatColor;
        private string alp;
        Random rand = new Random();
        public int randInt, z;

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {
            //Adding Seats Position
            /*
            Seat seatB1 = new Seat("B1", 120, 120);
            Seat seatB2 = new Seat("B2", 133, 120);
            Seat seatB3 = new Seat("B3", 146, 120);
            Seat seatB4 = new Seat("B4", 159, 120);
            Seat seatB5 = new Seat("B5", 172, 120);
            Seat seatB6 = new Seat("B6", 185, 120);
            Seat seatB7 = new Seat("B7", 198, 120);
            Seat seatB8 = new Seat("B8", 211, 120);
            Seat seatB9 = new Seat("B9", 224, 120);
            Seat seatB10 = new Seat("B10", 237, 120);

            Seat seatB11 = new Seat("B11", 263, 120);
            Seat seatB12 = new Seat("B12", 276, 120);
            Seat seatB13 = new Seat("B13", 289, 120);
            Seat seatB14 = new Seat("B14", 302, 120);
            Seat seatB15 = new Seat("B15", 315, 120);
            Seat seatB16 = new Seat("B16", 328, 120);
            Seat seatB17 = new Seat("B17", 341, 120);
            Seat seatB18 = new Seat("B18", 354, 120);
            Seat seatB19 = new Seat("B19", 367, 120);
            Seat seatB20 = new Seat("B20", 380, 120);

            Seat seatC1 = new Seat("C1", 120, 140);
            Seat seatC2 = new Seat("C2", 133, 140);
            Seat seatC3 = new Seat("C3", 146, 140);
            Seat seatC4 = new Seat("C4", 159, 140);
            Seat seatC5 = new Seat("C5", 172, 140);
            Seat seatC6 = new Seat("C6", 185, 140);
            Seat seatC7 = new Seat("C7", 198, 140);
            Seat seatC8 = new Seat("C8", 211, 140);
            Seat seatC9 = new Seat("C9", 224, 140);
            Seat seatC10 = new Seat("C10", 237, 140);

            Seat seatC11 = new Seat("C11", 263, 140);
            Seat seatC12 = new Seat("C12", 276, 140);
            Seat seatC13 = new Seat("C13", 289, 140);
            Seat seatC14 = new Seat("C14", 302, 140);
            Seat seatC15 = new Seat("C15", 315, 140);
            Seat seatC16 = new Seat("C16", 328, 140);
            Seat seatC17 = new Seat("C17", 341, 140);
            Seat seatC18 = new Seat("C18", 354, 140);
            Seat seatC19 = new Seat("C19", 367, 140);
            Seat seatC20 = new Seat("C20", 380, 140);

            Seat seatD1 = new Seat("D1", 120, 160);
            Seat seatD2 = new Seat("D2", 133, 160);
            Seat seatD3 = new Seat("D3", 146, 160);
            Seat seatD4 = new Seat("D4", 159, 160);
            Seat seatD5 = new Seat("D5", 172, 160);
            Seat seatD6 = new Seat("D6", 185, 160);
            Seat seatD7 = new Seat("D7", 198, 160);
            Seat seatD8 = new Seat("D8", 211, 160);
            Seat seatD9 = new Seat("D9", 224, 160);
            Seat seatD10 = new Seat("D10", 237, 160);
        
            Seat seatD11 = new Seat("D11", 263, 160);
            Seat seatD12 = new Seat("D12", 276, 160);
            Seat seatD13 = new Seat("D13", 289, 160);
            Seat seatD14 = new Seat("D14", 302, 160);
            Seat seatD15 = new Seat("D15", 315, 160);
            Seat seatD16 = new Seat("D16", 328, 160);
            Seat seatD17 = new Seat("D17", 341, 160);
            Seat seatD18 = new Seat("D18", 354, 160);
            Seat seatD19 = new Seat("D19", 367, 160);
            Seat seatD20 = new Seat("D20", 380, 160);

            Seat seatE1 = new Seat("E1", 120, 180);
            Seat seatE2 = new Seat("E2", 133, 180);
            Seat seatE3 = new Seat("E3", 146, 180);
            Seat seatE4 = new Seat("E4", 159, 180);
            Seat seatE5 = new Seat("E5", 172, 180);
            Seat seatE6 = new Seat("E6", 185, 180);
            Seat seatE7 = new Seat("E7", 198, 180);
            Seat seatE8 = new Seat("E8", 211, 180);
            Seat seatE9 = new Seat("E9", 224, 180);
            Seat seatE10 = new Seat("E10", 237, 180);

            Seat seatE11 = new Seat("E11", 263, 180);
            Seat seatE12 = new Seat("E12", 276, 180);
            Seat seatE13 = new Seat("E13", 289, 180);
            Seat seatE14 = new Seat("E14", 302, 180);
            Seat seatE15 = new Seat("E15", 315, 180);
            Seat seatE16 = new Seat("E16", 328, 180);
            Seat seatE17 = new Seat("E17", 341, 180);
            Seat seatE18 = new Seat("E18", 354, 180);
            Seat seatE19 = new Seat("E19", 367, 180);
            Seat seatE20 = new Seat("E20", 380, 180);
            */

            x = 120;
            y = 90;
            height = 10;
            width = 10;
            seatColor = Color.Maroon;
            alp = "";

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 22; j++)
                {
                    switch (i)
                    {
                        case 0:
                            alp = "A";
                            break;
                        case 1:
                            alp = "B";
                            break;
                        case 2:
                            alp = "C";
                            break;
                        case 3:
                            alp = "D";
                            break;
                        case 4:
                            alp = "E";
                            break;
                        case 5:
                            alp = "F";
                            break;
                        case 6:
                            alp = "G";
                            break;
                        case 7:
                            alp = "H";
                            break;
                        case 8:
                            alp = "I";
                            break;
                        case 9:
                            alp = "J";
                            break;
                    }
                    if(j == 11)
                    {
                        x = x + 20;
                    }
                    seatList.Add(new Seat(alp+""+(j + 1), x, y, height, width, seatColor));
                    x = x + 13;
                }
                x = 120;
                y = y + 20;
            }

            for (int i = 0; i < seatList.Count; i++)
            {
                Panel p = new Panel();
                p.Location = new Point(seatList[i].PosX, seatList[i].PosY);
                p.Size = new Size(seatList[i].SHeight, seatList[i].SWidth);
                p.BackColor = seatList[i].SeatColor;
                this.Controls.Add(p);
            }
            

            //Adding Panel Seats
            /*
            Panel pnlB1 = new Panel();
            Panel pnlB2 = new Panel();
            Panel pnlB3 = new Panel();
            Panel pnlB4 = new Panel();
            Panel pnlB5 = new Panel();
            */

            //Adding Seat Placement to Form
            /*
            SeatPlacement(seatB1, new Panel());
            SeatPlacement(seatB2, new Panel());
            SeatPlacement(seatB3, new Panel());
            SeatPlacement(seatB4, new Panel());
            SeatPlacement(seatB5, new Panel());
            SeatPlacement(seatB6, new Panel());
            SeatPlacement(seatB7, new Panel());
            SeatPlacement(seatB8, new Panel());
            SeatPlacement(seatB9, new Panel());
            SeatPlacement(seatB10, new Panel());

            SeatPlacement(seatB11, new Panel());
            SeatPlacement(seatB12, new Panel());
            SeatPlacement(seatB13, new Panel());
            SeatPlacement(seatB14, new Panel());
            SeatPlacement(seatB15, new Panel());
            SeatPlacement(seatB16, new Panel());
            SeatPlacement(seatB17, new Panel());
            SeatPlacement(seatB18, new Panel());
            SeatPlacement(seatB19, new Panel());
            SeatPlacement(seatB20, new Panel());

            SeatPlacement(seatC1, new Panel());
            SeatPlacement(seatC2, new Panel());
            SeatPlacement(seatC3, new Panel());
            SeatPlacement(seatC4, new Panel());
            SeatPlacement(seatC5, new Panel());
            SeatPlacement(seatC6, new Panel());
            SeatPlacement(seatC7, new Panel());
            SeatPlacement(seatC8, new Panel());
            SeatPlacement(seatC9, new Panel());
            SeatPlacement(seatC10, new Panel());

            SeatPlacement(seatC11, new Panel());
            SeatPlacement(seatC12, new Panel());
            SeatPlacement(seatC13, new Panel());
            SeatPlacement(seatC14, new Panel());
            SeatPlacement(seatC15, new Panel());
            SeatPlacement(seatC16, new Panel());
            SeatPlacement(seatC17, new Panel());
            SeatPlacement(seatC18, new Panel());
            SeatPlacement(seatC19, new Panel());
            SeatPlacement(seatC20, new Panel());

            SeatPlacement(seatD1, new Panel());
            SeatPlacement(seatD2, new Panel());
            SeatPlacement(seatD3, new Panel());
            SeatPlacement(seatD4, new Panel());
            SeatPlacement(seatD5, new Panel());
            SeatPlacement(seatD6, new Panel());
            SeatPlacement(seatD7, new Panel());
            SeatPlacement(seatD8, new Panel());
            SeatPlacement(seatD9, new Panel());
            SeatPlacement(seatD10, new Panel());

            SeatPlacement(seatD11, new Panel());
            SeatPlacement(seatD12, new Panel());
            SeatPlacement(seatD13, new Panel());
            SeatPlacement(seatD14, new Panel());
            SeatPlacement(seatD15, new Panel());
            SeatPlacement(seatD16, new Panel());
            SeatPlacement(seatD17, new Panel());
            SeatPlacement(seatD18, new Panel());
            SeatPlacement(seatD19, new Panel());
            SeatPlacement(seatD20, new Panel());

            SeatPlacement(seatE1, new Panel());
            SeatPlacement(seatE2, new Panel());
            SeatPlacement(seatE3, new Panel());
            SeatPlacement(seatE4, new Panel());
            SeatPlacement(seatE5, new Panel());
            SeatPlacement(seatE6, new Panel());
            SeatPlacement(seatE7, new Panel());
            SeatPlacement(seatE8, new Panel());
            SeatPlacement(seatE9, new Panel());
            SeatPlacement(seatE10, new Panel());

            SeatPlacement(seatE11, new Panel());
            SeatPlacement(seatE12, new Panel());
            SeatPlacement(seatE13, new Panel());
            SeatPlacement(seatE14, new Panel());
            SeatPlacement(seatE15, new Panel());
            SeatPlacement(seatE16, new Panel());
            SeatPlacement(seatE17, new Panel());
            SeatPlacement(seatE18, new Panel());
            SeatPlacement(seatE19, new Panel());
            SeatPlacement(seatE20, new Panel());
            */
            //Adding Users

            Panel pnlUser = new Panel();
            
            for (int i = 0; i < 20; i++) {
                randInt = rand.Next(0, seatList.Count);
                users.Add(new Panel());
                users[i].Location = new Point(0, 0);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(9, 9);
                this.Controls.Add(users[i]);

                //Simulation Start
                z = i;
                timerSimulation.Start();
            };
            //Point UsersLocation;
            //UsersLocation.X = 0;
            

        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            //users[0].Left--;
            
            if (users[z].Top < seatList[randInt].PosY - seatList[randInt].SHeight)
                users[z].Top++;

            else if (users[z].Top == seatList[randInt].PosY - seatList[randInt].SHeight)
            {
                if (users[z].Left < seatList[randInt].PosX)
                    users[z].Left++;
                else if (users[z].Left == seatList[randInt].PosX)
                {
                    while (users[z].Top < seatList[randInt].PosY)
                    {
                        users[z].Top++;
                        if (users[z].Top == seatList[randInt].PosY)
                        {
                            users[z].BringToFront();
                            timerSimulation.Stop();
                        }
                    }
                }
            }

        }

        private void SeatPlacement(Seat s, Panel p)
        {
            p = new Panel();
            p.Location = new Point(s.PosX, s.PosY);
            p.Size = new Size(10, 10);
            p.BackColor = Color.Maroon;
            this.Controls.Add(p);
        }
    }
}
