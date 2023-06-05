# tictactoe

A basic tic-tac-toe implemented with C#. Done in UI programming course.
It's possible to play against another human or against computer. When playing against computer, it evaluates the situation before its move and decides the move based on the following rules:

1) Win the game
2) Prevent the opponent from winning
3) If empty, play the center move. If center is already filled, find an empty corner
4) If any of the aforementioned criteria don't match, find any empty space

In this program the computer can only play with "O" (human plays with "X"). In multiplayer, "Player 1" is given "X" and "Player 2" has "O".
