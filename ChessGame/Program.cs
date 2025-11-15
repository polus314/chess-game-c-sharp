using ChessUI;
using ChessLogic;
using System;

// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Display d = new Display();
Board b = new Board();

Console.Clear();

string fen = b.GetFEN();
d.PrintBoard(fen);

Thread.Sleep(1000);

b.MovePiece("e2", "e4");
fen = b.GetFEN();
Console.SetCursorPosition(0, 0);
d.PrintBoard(fen);

Thread.Sleep(1000);

b.MovePiece("e7", "e5");
fen = b.GetFEN();
Console.SetCursorPosition(0, 0);
d.PrintBoard(fen);

Thread.Sleep(1000);

b.MovePiece("g1", "f3");
fen = b.GetFEN();
Console.SetCursorPosition(0, 0);
d.PrintBoard(fen);

Thread.Sleep(1000);

b.MovePiece("b8", "c6");
fen = b.GetFEN();
Console.SetCursorPosition(0, 0);
d.PrintBoard(fen);