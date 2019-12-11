using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : TabbedPage
    {
        //create empty game grid array to fill
        int[,] gameGrid = new int[5, 5];

        //arrays for easy mode game grids
        int[,] easyGameGrid1 = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] easyGameGrid2 = new int[5, 5] { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 1, 1, 1 } };
        int[,] easyGameGrid3 = new int[5, 5] { { 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 } };
        int[,] easyGameGrid4 = new int[5, 5] { { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] easyGameGrid5 = new int[5, 5] { { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] easyGameGrid6 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 1, 1, 1, 1, 1 } };
        int[,] easyGameGrid7 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 } };
        int[,] easyGameGrid8 = new int[5, 5] { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 1 }, { 0, 1, 0, 0, 1 }, { 0, 1, 0, 0, 1 }, { 0, 0, 0, 0, 1 } };
        int[,] easyGameGrid9 = new int[5, 5] { { 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] easyGameGrid10 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0 } };

        //arrays for normal mode game grids
        int[,] normalGameGrid1 = new int[5, 5] { { 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1 } };
        int[,] normalGameGrid2 = new int[5, 5] { { 0, 1, 1, 1, 1 }, { 0, 0, 1, 1, 1 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] normalGameGrid3 = new int[5, 5] { { 0, 0, 0, 1, 1 }, { 0, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 0 } };
        int[,] normalGameGrid4 = new int[5, 5] { { 1, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 } };
        int[,] normalGameGrid5 = new int[5, 5] { { 1, 1, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 0 } };
        int[,] normalGameGrid6 = new int[5, 5] { { 1, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 1, 1 } };
        int[,] normalGameGrid7 = new int[5, 5] { { 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 1, 1, 1 } };
        int[,] normalGameGrid8 = new int[5, 5] { { 1, 1, 1, 0, 0 }, { 1, 1, 1, 0, 0 }, { 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] normalGameGrid9 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1 } };
        int[,] normalGameGrid10 = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

        //arrays for hard mode game grids
        int[,] hardGameGrid1 = new int[5, 5] { { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 1, 0 } };
        int[,] hardGameGrid2 = new int[5, 5] { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] hardGameGrid3 = new int[5, 5] { { 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0 } };
        int[,] hardGameGrid4 = new int[5, 5] { { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 } };
        int[,] hardGameGrid5 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, 1 } };
        int[,] hardGameGrid6 = new int[5, 5] { { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] hardGameGrid7 = new int[5, 5] { { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] hardGameGrid8 = new int[5, 5] { { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 } };
        int[,] hardGameGrid9 = new int[5, 5] { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int[,] hardGameGrid10 = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 1 } };

        //declare variables
        int hitCount = 8, turnsLeft=15, gameDifficulty=1;
        Boolean won = false, lost = false; 

        public MainPage()
        {
            InitializeComponent();
            generateGrid();
            DisplayAlert("Welcome!", "Find and sink all battleships on the radar to win. Difficulty is set to 'easy'. Change the game difficulty and read game rules in the 'Settings' Tab.", "Ok");
        }

        //generate a new game grid
        public void generateGrid()
        {
            //generate random number to determine which grid to utilize
            Random rnd = new Random();
            int gridNo = rnd.Next(1, 10);
            
            //generate an 'easy' mode game grid
            if (gameDifficulty == 1)
            {
                turnsLeft = 15;
                setTurnsLeft();
                hitCount = 8;
                switch (gridNo)
                {
                    case 1:
                        gameGrid = easyGameGrid1;
                        break;
                    case 2:
                        gameGrid = easyGameGrid2;
                        break;
                    case 3:
                        gameGrid = easyGameGrid3;
                        break;
                    case 4:
                        gameGrid = easyGameGrid4;
                        break;
                    case 5:
                        gameGrid = easyGameGrid5;
                        break;
                    case 6:
                        gameGrid = easyGameGrid6;
                        break;
                    case 7:
                        gameGrid = easyGameGrid7;
                        break;
                    case 8:
                        gameGrid = easyGameGrid8;
                        break;
                    case 9:
                        gameGrid = easyGameGrid9;
                        break;
                    case 10:
                        gameGrid = easyGameGrid10;
                        break;
                    default:
                        ;
                        break;
                }
            }

            //gernerate a 'normal' mode game grid
            else if (gameDifficulty == 2)
            {
                turnsLeft = 12;
                setTurnsLeft();
                hitCount = 9;
                switch (gridNo)
                {
                    case 1:
                        gameGrid = normalGameGrid1;
                        break;
                    case 2:
                        gameGrid = normalGameGrid2;
                        break;
                    case 3:
                        gameGrid = normalGameGrid3;
                        break;
                    case 4:
                        gameGrid = normalGameGrid4;
                        break;
                    case 5:
                        gameGrid = normalGameGrid5;
                        break;
                    case 6:
                        gameGrid = normalGameGrid6;
                        break;
                    case 7:
                        gameGrid = normalGameGrid7;
                        break;
                    case 8:
                        gameGrid = normalGameGrid8;
                        break;
                    case 9:
                        gameGrid = normalGameGrid9;
                        break;
                    case 10:
                        gameGrid = normalGameGrid10;
                        break;
                    default:
                        ;
                        break;
                }
            }

            //generate 'hard' mode game grid
            else if (gameDifficulty == 3)
            {
                turnsLeft = 10;
                setTurnsLeft();
                hitCount = 4;
                switch (gridNo)
                {
                    case 1:
                        gameGrid = hardGameGrid1;
                        break;
                    case 2:
                        gameGrid = hardGameGrid2;
                        break;
                    case 3:
                        gameGrid = hardGameGrid3;
                        break;
                    case 4:
                        gameGrid = hardGameGrid4;
                        break;
                    case 5:
                        gameGrid = hardGameGrid5;
                        break;
                    case 6:
                        gameGrid = hardGameGrid6;
                        break;
                    case 7:
                        gameGrid = hardGameGrid7;
                        break;
                    case 8:
                        gameGrid = hardGameGrid8;
                        break;
                    case 9:
                        gameGrid = hardGameGrid9;
                        break;
                    case 10:
                        gameGrid = hardGameGrid10;
                        break;
                    default:
                        ;
                        break;
                }
            }
            
        }//end generateGrid()

        //code for when "easy" button is clicked
        private void Easy_Button_Clicked(object sender, EventArgs e)
        {
            gameDifficulty = 1;
            generateGrid();
            ResetGrid();
            DisplayAlert("Easy Difficulty", "Difficulty changed to 'Easy'", "Ok");
        }

        //code for when "normal" button is clicked
        private void Normal_Button_Clicked(object sender, EventArgs e)
        {
            gameDifficulty = 2;
            generateGrid();
            ResetGrid();
            DisplayAlert("Normal Difficulty", "Difficulty changed to 'Normal'", "Ok");
        }

        //code for when "hard" button is clicked
        private void Hard_Button_Clicked(object sender, EventArgs e)
        {
            gameDifficulty = 3;
            generateGrid();
            ResetGrid();
            DisplayAlert("Hard Difficulty", "Difficulty changed to 'Hard'", "Ok");
        }

        //code for when "New Game" button is clicked
        private void NewGameButtonClicked(object sender, EventArgs e)
        {
            generateGrid();
            ResetGrid();
            won = false;
            lost = false;
            DisplayAlert("New Game", "Grid Reset", "Ok");
        }

        //code for when a game grid button is clicked
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = Grid.GetRow(btn);
            int y = Grid.GetColumn(btn);

            //validate the player's button choice
            if (btn.Text == "miss" || btn.Text == "hit")
            {
                DisplayAlert("Error.", "Tile already chosen.", "Cancel");
            }

            else
            {
                //if the player's chosen tile contains a battleship
                if (gameGrid[x, y] == 1)
                {
                    btn.Text = "hit";
                    hitCount--;
                    turnsLeft--;
                }

                //if the player's chosen tile does not contain a battleship 
                else if(gameGrid[x, y] == 0)
                {
                    btn.Text = "miss";
                    turnsLeft--;
                }

                //display message at end of game
                for (int col = 0; col < gameGrid.GetLength(0); col++)
                {
                    //don't display a message if game is already over
                    if (won == true || lost == true)
                    {
                        break;
                    }

                    for (int row = 0; row < gameGrid.GetLength(1); row++)
                    {
                         if(won==true || lost==true)
                         {
                               break;
                         }
                         else if (btn.Text == "hit")
                         {
                               //check if player has sunk all battleships (player wins)
                               if (hitCount == 0)
                               {
                                   DisplayAlert("You Win.", "All boats sunk.", "Ok");
                                   won = true;
                               }
                         }
                         else if (btn.Text == "miss")
                         {
                               //check if player has ran out of turns (player loses)
                               if (turnsLeft == 0)
                               {
                                   DisplayAlert("You Lose.", "Ran out of turns.", "Ok");
                                   lost = true;
                               }
                         }
                    }
                }//end of for loop

            }//end of else path

            setTurnsLeft();

        }//end of Button_CLicked()

        //display the number of turns left 
        public void setTurnsLeft()
        {
            switch (turnsLeft)
            {
                case 0:
                    Turns.Text = "0";
                    break;
                case 1:
                    Turns.Text = "1";
                    break;
                case 2:
                    Turns.Text = "2";
                    break;
                case 3:
                    Turns.Text = "3";
                    break;
                case 4:
                    Turns.Text = "4";
                    break;
                case 5:
                    Turns.Text = "5";
                    break;
                case 6:
                    Turns.Text = "6";
                    break;
                case 7:
                    Turns.Text = "7";
                    break;
                case 8:
                    Turns.Text = "8";
                    break;
                case 9:
                    Turns.Text = "9";
                    break;
                case 10:
                    Turns.Text = "10";
                    break;
                case 11:
                    Turns.Text = "11";
                    break;
                case 12:
                    Turns.Text = "12";
                    break;
                case 13:
                    Turns.Text = "13";
                    break;
                case 14:
                    Turns.Text = "14";
                    break;
                case 15:
                    Turns.Text = "15";
                    break;
                default:
                    ;
                    break;
            }
        }

        //reset game grid display
        public void ResetGrid()
        {
            button0_0.Text = ("( 0 , 0 )");
            button1_0.Text = ("( 1 , 0 )");
            button2_0.Text = ("( 2 , 0 )");
            button3_0.Text = ("( 3 , 0 )");
            button4_0.Text = ("( 4 , 0 )");

            button0_1.Text = ("( 0 , 1 )");
            button1_1.Text = ("( 1 , 1 )");
            button2_1.Text = ("( 2 , 1 )");
            button3_1.Text = ("( 3 , 1 )");
            button4_1.Text = ("( 4 , 1 )");

            button0_2.Text = ("( 0 , 2 )");
            button1_2.Text = ("( 1 , 2 )");
            button2_2.Text = ("( 2 , 2 )");
            button3_2.Text = ("( 3 , 2 )");
            button4_2.Text = ("( 4 , 2 )");

            button0_3.Text = ("( 0 , 3 )");
            button1_3.Text = ("( 1 , 3 )");
            button2_3.Text = ("( 2 , 3 )");
            button3_3.Text = ("( 3 , 3 )");
            button4_3.Text = ("( 4 , 3 )");

            button0_4.Text = ("( 0 , 4 )");
            button1_4.Text = ("( 1 , 4 )");
            button2_4.Text = ("( 2 , 4 )");
            button3_4.Text = ("( 3 , 4 )");
            button4_4.Text = ("( 4 , 4 )");
        }

    }
}
