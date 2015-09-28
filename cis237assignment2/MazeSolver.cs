using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] mazeToSolve;
        int xStart;
        int yStart;
        bool solved = false;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        { }


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public char[,] SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.mazeToSolve = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            //Do work needed to use mazeTraversal recursive call and solve the maze.

            mazeTraversal(yStart, xStart);

            solved = false;

            return maze;
        }

        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private bool mazeTraversal(int ycoord, int xcoord)
        {
            try
            {
                //Implement maze traversal recursive call
                int up = ycoord - 1;
                int down = ycoord + 1;
                int left = xcoord - 1;
                int right = xcoord + 1;

                mazeToSolve[ycoord, xcoord] = 'O';

                if (mazeToSolve[down, xcoord] == '.')
                {   //First we check down to see if the path is open
                    mazeToSolve[ycoord, xcoord] = 'O'; //Set where we are as a O since we can progress from it
                    mazeTraversal(down, xcoord); //If this path leads us to the end, we never exit this, so....
                    if (!solved)
                    {
                        mazeToSolve[down, xcoord] = 'X'; //If we get here, we didn't solve it on that path. Overwrite O back to X
                    }
                }

                if (mazeToSolve[ycoord, left] == '.')
                {   //Look left
                    mazeToSolve[ycoord, xcoord] = 'O';
                    mazeTraversal(ycoord, left);
                    if (!solved)
                    {
                        mazeToSolve[ycoord, left] = 'X';
                    }
                }

                if (mazeToSolve[up, xcoord] == '.')
                {   //Look up
                    mazeToSolve[ycoord, xcoord] = 'O';
                    mazeTraversal(up, xcoord);
                    if (!solved)
                    {
                        mazeToSolve[up, xcoord] = 'X';
                    }
                }

                if (mazeToSolve[ycoord, right] == '.')
                {   //Look right
                    mazeToSolve[ycoord, xcoord] = 'O';
                    mazeTraversal(ycoord, right);
                    if (!solved)
                    {
                        mazeToSolve[ycoord, right] = 'X';
                    }
                }
            }

            catch (IndexOutOfRangeException)
            {
                solved = true; //Check to see if index is 12, then true, no try/catch
            }

            return false;

        }
    }
}
