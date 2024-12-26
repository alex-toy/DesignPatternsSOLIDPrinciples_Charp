using ObserverDP.Obervers;
using ObserverDP.Structure;

namespace ObserverDP;

internal class Program
{
    static void Main(string[] args)
    {
        DataSource dataSource = new DataSource() { };

        dataSource.Observers = new List<Observer>() {
            new Sheet() { Publisher = dataSource },
            new BarChart() { Publisher = dataSource },
        };

        dataSource.Values = new List<int>() { 1, 2, 3 };
        dataSource.Values = new List<int>() { 4, 5, 6 };
        dataSource.Values = new List<int>() { 7, 8, 9 };
    }
}
