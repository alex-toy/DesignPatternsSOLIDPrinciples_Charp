﻿namespace UndoableCommand.BaseCommands;

public interface ICommand
{
    void Execute();
    void UnExecute();
}
