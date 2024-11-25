﻿namespace DesignPatterns.Memento.Generic;

public class State<T>
{
    private readonly DateTime _createdAt;
    public DateTime CreatedAt { get => _createdAt; }

    private readonly T _item;
    public T Editor { get => _item; }

    public State(T item)
    {
        _item = item;
        _createdAt = DateTime.UtcNow;
    }
}