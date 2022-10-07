﻿using System;
using System.Threading;

Console.Clear();
Console.CursorVisible = false;

draw_mark();

string _last_datetime = "------";
bool _dot = false;

while (true)
{
    string _current_datetime = DateTime.Now.ToString("HHmmss");

    if (!_dot && Convert.ToInt32(_current_datetime[_current_datetime.Length-1].ToString())%2==0)
    {
        _dot = !_dot;
        draw_dot(_dot);
    }
    else if (_dot && Convert.ToInt32(_current_datetime[_current_datetime.Length - 1].ToString()) % 2 != 0)
    {
        _dot = !_dot;
        draw_dot(_dot);
    }

    if (_last_datetime != _current_datetime)
    {
        for (int i = 0; i < _current_datetime.Length; i++)
        {
            if (_last_datetime[i] != _current_datetime[i])
            {
                drawNumber(Convert.ToInt32(_current_datetime[i].ToString()), i);
            }
        }
    }
    _last_datetime = _current_datetime;
    Thread.Sleep(100);
}

void drawNumber(int _number, int _position)
{
    int _offset = getOffset(_position);
    char[][] _nummber_array = dotClock.Numbers.get_number(_number);
    drawArray(_offset, _nummber_array);
}

void drawArray(int _offset, char[][] _array)
{
    for (int _y = 0; _y < _array.Length; _y++)
    {
        for (int _x = 0; _x < _array[_y].Length; _x++)
        {
            Console.SetCursorPosition(_offset + _x, _y);
            Console.Write(_array[_y][_x]);
        }
    }
}

int getOffset(int _position)
{
    switch (_position)
    {
        case 1:
            return 8;
        case 2:
            return 21;
        case 3:
            return 29;
        case 4:
            return 42;
        case 5:
            return 50;
        default:
            return 0;
    }
}

void draw_dot(bool _dot)
{
    char[][] _array_dot = dotClock.dots.get_dot(_dot);
    drawArray(15, _array_dot);
    drawArray(36, _array_dot);
}

void draw_mark()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.SetCursorPosition(0, 15);
    Console.Write("github.com/dmbaev");
    Console.ForegroundColor = ConsoleColor.White;
}