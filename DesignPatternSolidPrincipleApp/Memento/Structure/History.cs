using Memento.Basic;
using System.Reflection;

namespace Memento.Structure;

public class History<T> where T : class
{
    private List<State<T>> _history = new();
    private T _historable;

    public History(T historable)
    {
        _historable = historable;
    }

    public void Restore(State<T> state)
    {
        PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var property in properties)
        {
            if (property.CanWrite)
            {
                object? value = property.GetValue(state.Historable);
                property.SetValue(_historable, value);
            }
        }
    }

    public State<T> CreateState(T editor)
    {
        T newEditor = GetDeepCopy(editor);
        return new State<T>(newEditor);
    }

    public void Backup()
    {
        _history.Add(CreateState(_historable));
    }

    public void Undo()
    {
        if (_history.Count == 0) return;
        _history.RemoveAt(_history.Count - 1);
        if (_history.Count == 0) return;
        State<T> prevState = _history.Last();
        Restore(prevState);
    }

    public void ShowHistrory()
    {
        foreach (var state in _history) Console.WriteLine($"{state.CreatedAt} - {state.Historable.ToString()}");
    }

    private static T GetDeepCopy(T editor)
    {
        T newEditor = (T)Activator.CreateInstance(typeof(T));

        PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var property in properties)
        {
            if (property.CanWrite)
            {
                var value = property.GetValue(editor);
                if (value is ICloneable cloneableValue)
                {
                    value = cloneableValue.Clone();
                }
                property.SetValue(newEditor, value);
            }
        }

        return newEditor;
    }
}
