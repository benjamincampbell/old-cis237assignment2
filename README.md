# Assignment 1 - Review of C# Basic Concepts and Introduction to Git

## Author

Benjamin Campbell

## Description

You must write a program to traverse a 12 x 12 maze and find a successful path from a starting point to an exit. You are given a hard coded maze in the program, as well as some starting coordinates. Each spot in the maze is represented by either a '#' or a '.' (dot). The #'s represent the walls of the maze, and the dots represent paths through the maze. Moves can be made only up, down, left, or right (not diagonally), one spot at a time, and only over paths (not into or across a wall). The exit will be any spot that is on the outside of the array. As your program attempts to find a path leading to the exit, it should place the character 'X' in each spot along the path. If a dead end is reached, your program should replace the X’s with '0'. But, the spots with '0' should be marked back to 'X' if these spots are part of a successful path leading to a final state. The output of your program is the maze configuration after each move. In your testing, you may assume that each maze has a path from its starting point to its exit point. If there is no exit, you will arrive at the starting spot again.

There is a method stub in the main program for transposing the 2D array. The progarm is setup to solve both the orignal maze, and the transposed maze. Your program should be able to solve both of them without any issue.

You are required to use recursion to solve this problem.

Please remember to fill out this README file with the relevent information that is missing.

Also make sure that you comment your name at the top of each file, and add comments for each method.

Comment anything else that isn't obvious about what you are trying to do in the code.

I also want you to comment the recursive method you implement thoroughly to show me that you know what is going on inside your method.

### Notes

It might be useful while developing this program to use a smaller sized maze, and then get it to work with the real ones.

Don't forget that you must have a base case for your recursive method or you will continue to get a stack overflow. 

## Outside Resources Used

## Known Problems, Issues, And/Or Errors in the Program

I couldn't get the maze solver to work without using the try/catch, which I know is not very good practice (since I should be avoiding errors in the first place)

Also in MazeSolver.cs, in the mazeTraversal() method, every time I check a direction I check if (direction == '.' && !solved). I tried envoloping all 4 of these within 1 if (!solved) to save redundancy, but when it would come out of the recursive calls it would then check other directions since it never was forced to see if the maze was solved yet. Doing this makes it so it stops checking any directions after the maze is solved.


