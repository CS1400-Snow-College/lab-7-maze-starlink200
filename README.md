# Maze
Objectives

    Make a basic, but super-cool, maze game.
    Practice more with arrays, text files, and the Console.
    (optional) Practice switch statements.

Step 1: Read This Overview

In this lab you will write a program that allows you to load and then navigate a maze like the following from a text file like the following (the player will start in the upper left corner and the target is the *):

map.txt:

   ##########################
#  #         ####     #     #
#  #         #    #   # ### #
#  ###########  ###       # #
#                 #  ##   #*#
#############################

Step 2: Environment Setup

    Accept the GitHub Classroom Assignment (Links to an external site.).
    Clone the repository and start a new console project and add it to the repository. (Refer to previous labs if you need to.)
    The repository should have a copy of a text file with this maze loaded into it. You can certainly make a more interesting maze as long as it functions the same.

Step 3: Programming

Incrementally add the following functionality to your program. After each step, make sure that you can still compile/run and that the program behaves as expected; then commit a checkpoint to your git repository (using git add . and git commit -m "write a description of the step here").

    (Preliminaries and story file) Add a comment to the top of your source code with the names of the author, the date, and the name of the lab. Display to the user a basic description of what the program will do.

    (Load from file) Within your Main method, create a string array variable called mapRows and use File.ReadAllLines to load the contents of map.txt into your variable. Clear the screen, and then write a loop to print out the rows of the map to the screen. (Make sure the program works and commit the changes to your repo.)

    (Basic User controls)
        Move the cursor position to the top left corner of the screen (this would be a great time to read chapter 4)
        Create a "do-while" loop that accepts user input (one key at a time without echoing --- hint: Console.ReadKey(true).Key will evaluate to a ConsoleKey value.
        On each iteration through the loop, process a pressed key as follows:
    Key 	Action
    ConsoleKey.Escape 	return from Main
    ConsoleKey.UpArrow 	Console.CursorTop--;
    ConsoleKey.DownArrow 	Console.CursorTop++;
    ConsoleKey.LeftArrow 	Console.CursorLeft--;
    ConsoleKey.RightArrow 	Console.CursorLeft++;

Notice what happens when you move the cursor off of the page (that is fine for now). (Make sure the program works and commit the changes to your repo.)

    (Stay on the map) Update your handling of user input to ensure the following:
        Never allow Console.CursorTop to be less than 0 or greater than Console.BufferHeight or mazeRows.Length
        Never allow Console.CursorLeft to be less than 0 or greater than Console.BufferWidth or the length of the mazeRow.
        hint: consider writing a method static void TryMove(int proposedTop, int proposedLeft, string[] mazeRows) that sets CursorTop=proposedTop and CursorLeft=proposedTop only if the proposed location is valid.

(Make sure the program works and commit the changes to your repo.)

    (Detect the win) Break out of the loop, clear the screen, and print a congratulatory message if the current cell (i.e. mazeRows[Console.CursorTop][Console.CursorLeft] is '*'). (Make sure the program works and commit the changes to your repo.)

    (Enforce walls) Update your TryMove code to additionally enforce that no move is taken if it would land the player on a '#' cell. (Make sure the program works and commit the changes to your repo.)

    (optional) (More Features) (5 bonus points each)

        Add random dollar signs to the maze. When your player passes over them, make them disappear and add to the players score
        Add a timer (remember that stopwatch function) and record how long it takes to complete the maze

Submission

Make sure to add, commit and push so your code makes it back up to GitHub. Submit the url of your repository.
Grading

Grading must be done in person or via Teams with me.
