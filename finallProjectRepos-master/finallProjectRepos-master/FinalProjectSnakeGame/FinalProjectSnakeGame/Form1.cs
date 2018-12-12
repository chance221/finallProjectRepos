using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSnakeGame
{
    public partial class snakeForm : Form

    {   //enum to determine that state of each field
        //
        Random rand;
        enum GameBoardFields
        {
            Free,
            Snake,
            Bonus
        };
        // enum to determine the snakes current direction
        enum Directions
        {
            Up,
            Down,
            Left,
            Right
        }
        //structure to determine the snakes location within an array

            //struct info found on youtube.com and also udemy.com
        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }
        //initializing the enums and arrays and setting values to each

            //GamrboardField instantiation found on udemy.com

        GameBoardFields[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions direction;
        Graphics g;

        public snakeForm()
        {
            InitializeComponent();//default constructor for the snake form(provided by winforms)

            gameBoardField = new GameBoardFields[11, 11]; //enum marks the walls for the game field 
                                                          //(one higher than game field)

            snakeXY = new SnakeCoordinates[100]; // as the game field itself is 10X10 the array needs 
                                                 //to be from 0 to 99 
            rand = new Random();
        }

        //this is an event that paints the objects to the win form by instantiating each 
        //aspect required to paint the walls

        private void snakeForm_Load(object sender, EventArgs e) 
        {
            picGamrBoard.Image = new Bitmap(420, 420); //sets the Bitmap to the size of the 
                                                       //gameboard including walls

            g = Graphics.FromImage(picGamrBoard.Image);// lets the compiler know that we are getting the 
                                                       //graphics for game from images to be defined later

            g.Clear(Color.White); //clears the background and sets the color to white
            
            //top and bottom walls
            for (int i = 1; i<=10; i++)
            {
                g.DrawImage(imgList1.Images[6], i * 35, 0); //top begins at coordinate 0 on the x axis and itterates 35px
                g.DrawImage(imgList1.Images[6], i * 35, 385);// bottome begins at the coordinate 385
            }

            //left and right walls
            for (int i = 0; i <= 11; i++)//as we are including the extra block required to make a sqyare 
                                         //to the left and right the interval needs to start at 0 and go to 11

            { // draws the images using an index of the images themselves 
                g.DrawImage(imgList1.Images[6], 0, i*35); //left begins at coordinate 0 on the y axis
                g.DrawImage(imgList1.Images[6], 385, i*35);// right begins at the coordinate 385 on the y axis
            }


            //snake positioning and movement found on udemy.com

            //initial snake body and head start position using the strucures snake coordinates array. 
            snakeXY[0].x = 5;//head is starting directly in middle of the board and set coodinates to the middle
            snakeXY[0].y = 5;
            snakeXY[1].x = 5;//first body part starting in the middle but one below head
            snakeXY[1].y = 6;//y coordinates altered to represent body
            snakeXY[2].x = 5;//second body part also starting in the middle of x axis
            snakeXY[2].y = 7;//second body part listed 2 below original head position

            //above it keeps trace of the position, but the actual drawing of those body parts is listed below
            g.DrawImage(imgList1.Images[5], 5 * 35, 5* 35); //head for both x, and y axis
            g.DrawImage(imgList1.Images[4], 5 * 35, 6 * 35); //first body part
            g.DrawImage(imgList1.Images[4], 5 * 35, 7 * 35); //second body part

            //this section sets the gameboard field to the snake maning nothing else but a snake exist in this field
            gameBoardField[5, 5] = GameBoardFields.Snake;//head
            gameBoardField[5, 6] = GameBoardFields.Snake;//1st body part
            gameBoardField[5, 7] = GameBoardFields.Snake;//2nd body part

            //sets initial direction to up and length counter to 3
            direction = Directions.Up;
            snakeLength = 3; //this will increase as the snake eats the bonuses

            //sets up a for loop that set up the bonuses to randomly appear on the screen through a Bonus method
            for (int i = 0; i <4; i++)
            {
                Bonus();//runs conus method
            }
            
            

        }

        //use of rand class found on udemy.com

        //bonus method that generates one of the 4 bonus images
        private void Bonus()
        {
            int x, y;
            var imgIndex = rand.Next(0, 4);

            do
            {
                x = rand.Next(1, 10);//randomly appears within the set field
                y = rand.Next(1, 10);//randomly appears within the set field
            } while (gameBoardField[x,y] !=GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Bonus;
            g.DrawImage(imgList1.Images[imgIndex], x * 35, y * 35);

        }

        
        //by sleecting the KeyDown event on the manager it automatically opens this method and adds
        //directions when each key is pressed
        private void frmSnakeKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)//e is the event and switch statement sets the direction 
            {
                case Keys.Up:
                    direction = Directions.Up;
                    break;
                case Keys.Down:
                    direction = Directions.Down;
                    break;
                case Keys.Left:
                    direction = Directions.Left;
                    break;
                case Keys.Right:
                    direction = Directions.Right;
                    break;

            }
        }
        //sets the parameter that the timer is an event that can cause game over

        //use of timer found on udemy.com

        private void GameOver()
            {
                timer.Enabled = false;
                MessageBox.Show("GAME OVER");
            }

        private void Timer_Tick(object sender, EventArgs e)
        { //deletes the end of the snake
            g.FillRectangle(Brushes.White, snakeXY[snakeLength - 1].x * 35,
                snakeXY[snakeLength - 1].y * 35, 35, 35);
            gameBoardField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = GameBoardFields.Free;

            //move snake field on the position of previous one
            for (int i = snakeLength; i >= 1; i--)
            {
                snakeXY[i].x = snakeXY[i - 1].x;
                snakeXY[i].y = snakeXY[i - 1].y;
            }

            g.DrawImage(imgList1.Images[4], snakeXY[0].x * 35, snakeXY[0].y * 35);


            //change the direction of the head

            //snake movement of head and body found on udemy.com and youtube

            switch (direction)
            {
                case Directions.Up:
                    snakeXY[0].y = snakeXY[0].y - 1;//the direction changes based on the last location
                    break;                          //of the snake head. As we approach 0 on the y axis
                case Directions.Down:               //we are heding up and vise versa
                    snakeXY[0].y = snakeXY[0].y + 1;
                    break;
                case Directions.Left:
                    snakeXY[0].x = snakeXY[0].x - 1;//left and right are functions of the x axis. as we go left 
                    break;                          //we are approaching 0, as we go right we are approaching 
                case Directions.Right:              //the upper bounds of x which is 10
                    snakeXY[0].x = snakeXY[0].x + 1;
                    break;
            }

            //we now need to check to see if we hit a wall.
            if (snakeXY[0].x < 1 || snakeXY[0].x > 10 || snakeXY[0].y < 1 || snakeXY[0].y > 10)
            {
                GameOver();
                picGamrBoard.Refresh();
                return;
            }
            //checks to see if snake hits itself.
            if (gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Snake)
                {
                GameOver();
                picGamrBoard.Refresh();
                return;
                }

            //check to see if the snake ate the bonus
            if (gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Bonus)
                {
                g.DrawImage(imgList1.Images[4], snakeXY[snakeLength].x * 35,//grows length of snake on 
                    snakeXY[snakeLength].y * 35);                           //x and y axis
                gameBoardField[snakeXY[snakeLength].x, snakeXY[snakeLength].y] = GameBoardFields.Snake;
                snakeLength++;

                if (snakeLength < 96)
                    Bonus();

                this.Text = "Snake - score: " + snakeLength;
                }

            //draw the head
            g.DrawImage(imgList1.Images[5], snakeXY[0].x * 35, snakeXY[0].y * 35);
            gameBoardField[snakeXY[0].x, snakeXY[0].y] = GameBoardFields.Snake;

            picGamrBoard.Refresh();
        }

    }
}
