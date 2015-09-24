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
        char[,] maze;
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
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            //Do work needed to use mazeTraversal recursive call and solve the maze.

                mazeTraversal(maze, yStart, xStart);

            return maze;
        }

        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(char[,] maze, int ycoord, int xcoord)
        {
            try
            {
                //Implement maze traversal recursive call
                int up = ycoord - 1;
                int down = ycoord + 1;
                int left = xcoord - 1;
                int right = xcoord + 1;

                //If solved gets flipped to true, exit the while loops

                if (maze[down, xcoord] == '.')
                {   //First we check down to see if the path is open
                    maze[ycoord, xcoord] = 'O'; //Set where we are as a O since we can progress from it
                    mazeTraversal(maze, down, xcoord); //If this path leads us to the end, we never exit this, so....
                    maze[down, xcoord] = 'X'; //If we get here, we didn't solve it on that path. Overwrite O back to X
                }
                //else
                //{
                //    if (maze[down, xcoord] == '#')
                //    {
                //        maze[ycoord, xcoord] = 'X';
                //    }
                //    else
                //    {

                //    }
                //}

                if (maze[ycoord, left] == '.')
                {   //Look left
                    maze[ycoord, xcoord] = 'O';
                    mazeTraversal(maze, ycoord, left);
                    maze[ycoord, left] = 'X';
                }
                //else
                //{
                //    if (maze[ycoord, left] == '#')
                //    {
                //        maze[ycoord, xcoord] = 'X';
                //    }
                //    else
                //    {

                //    }
                //}

                if (maze[up, xcoord] == '.')
                {   //Look up
                    maze[ycoord, xcoord] = 'O';
                    mazeTraversal(maze, up, xcoord);
                    maze[up, xcoord] = 'X';
                }
                //else
                //{
                //    if (maze[up, xcoord] == '#')
                //    {
                //        maze[ycoord, xcoord] = 'X';
                //    }
                //    else
                //    {

                //    }
                //}

                if (maze[ycoord, right] == '.')
                {   //Look right
                    maze[ycoord, xcoord] = 'O';
                    mazeTraversal(maze, ycoord, right);
                    maze[ycoord, right] = 'X';
                }
                //else
                //{
                //    if (maze[ycoord, right] == '#')
                //    {
                //        maze[ycoord, xcoord] = 'X';
                //    }
                //    else
                //    {

                //    }
                //}
            }

            catch (IndexOutOfRangeException)
            {
                solved = true;
            }

        }
    }
}
