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
    /// A print maze method would be very useful.
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

        /// <summary>
        /// Constuctor to setup a new maze solver
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        public MazeSolver(char[,] maze, int xStart, int yStart)
        {
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

        }

        //This is the public method that will allow someone to use this class to solve the maze.
        //Feel free to change the return type if you like, or pass in parameters that you might need.
        //This is only a very small starting point.
        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point
        /// </summary>
        public void SolveMaze()
        {

        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal()
        {

        }
    }
}
