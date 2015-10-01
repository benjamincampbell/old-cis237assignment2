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
        private char[,] mazeToSolve;
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
            solved = false;

            mazeTraversal(yStart, xStart);

            return mazeToSolve;
        }

        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(int xcoord, int ycoord)
        {
            try
            {
                //Implement maze traversal recursive call

                //Set our new directions with the given coordinates
                int up = xcoord - 1;
                int down = xcoord + 1;
                int left = ycoord - 1;
                int right = ycoord + 1;

                //Set our current location to O since it is an open spot, potentially leading us to the end
                mazeToSolve[xcoord, ycoord] = 'O';

                //if (up < 0 || down == mazeToSolve.GetLength(0) || left < 0 || right == mazeToSolve.GetLength(1))
                //{   //This method checks to see if and direction is going to take us out of the array, to prevent an IndexOutOfRange Exception
                //    solved = true;
                //}
                if (mazeToSolve[down, ycoord] == '.' && !solved)
                {   //First we check down to see if the path is open, if so, we go to it
                    mazeTraversal(down, ycoord); //If this path leads us to the end, we never exit this, so....
                    if (!solved)
                    {
                        mazeToSolve[down, ycoord] = 'X'; //If we get here, we didn't solve it on that path. Overwrite O back to X
                    }
                }

                if (mazeToSolve[xcoord, left] == '.' && !solved)
                {   //Look left
                    mazeTraversal(xcoord, left);
                    if (!solved)
                    {
                        mazeToSolve[xcoord, left] = 'X';
                    }
                }

                if (mazeToSolve[up, ycoord] == '.' && !solved)
                {   //Look up
                    mazeTraversal(up, ycoord);
                    if (!solved)
                    {
                        mazeToSolve[up, ycoord] = 'X';
                    }
                }

                if (mazeToSolve[xcoord, right] == '.' && !solved)
                {   //Look right
                    mazeTraversal(xcoord, right);
                    if (!solved)
                    {
                        mazeToSolve[xcoord, right] = 'X';
                    }
                }
            }

            catch (IndexOutOfRangeException)
            {
                solved = true; //Check to see if index is 12, then true, no try/catch
            }

        }
    }
}
