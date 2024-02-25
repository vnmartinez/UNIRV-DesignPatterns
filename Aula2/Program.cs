using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(float temperature);
}

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

public class SensorTemperatura : IObservable
{
    private List<IObserver> observers;
    private float temperature;

    public SensorTemperatura()
    {
        observers = new List<IObserver>();

        temperature = 25.0f;
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void UpdateTemperature(float newTemperature)
    {
        temperature = newTemperature;
        Console.WriteLine($"Nova temperatura: {temperature}°C");
        NotifyObservers();
    }
}

public class DisplayTemperatura : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Display de temperatura: {temperature}°C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SensorTemperatura sensor = new SensorTemperatura();

        DisplayTemperatura display1 = new DisplayTemperatura();
        DisplayTemperatura display2 = new DisplayTemperatura();

        sensor.AddObserver(display1);
        sensor.AddObserver(display2);

        sensor.UpdateTemperature(27.5f);
    }
}
