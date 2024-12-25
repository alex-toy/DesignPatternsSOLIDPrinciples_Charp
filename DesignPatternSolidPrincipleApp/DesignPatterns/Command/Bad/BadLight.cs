﻿namespace DesignPatterns.Commands.Bad;

public class BadLight
{
    public void TurnOn()
    {
        Console.WriteLine(nameof(TurnOn));
    }

    public void TurnOff()
    {
        Console.WriteLine(nameof(TurnOff));
    }

    public void Dim()
    {
        Console.WriteLine(nameof(Dim));
    }

    public void Bright()
    {
        Console.WriteLine(nameof(Bright));
    }
}
