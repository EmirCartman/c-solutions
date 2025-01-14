using System;

public enum TrafficLightState
{
    Red,    
    Yellow, 
    Green   
}

public class TrafficLight
{
  
    public string DurumuAcikla(TrafficLightState state)
    {
        switch (state)
        {
            case TrafficLightState.Red:
                return "Dur! Işık kırmızı, bekle.";
            case TrafficLightState.Yellow:
                return "Dikkat! Işık sarı, hazırlık yap.";
            case TrafficLightState.Green:
                return "Geç! Işık yeşil, hareket et.";
            default:
                return "Geçersiz trafik ışığı durumu!";
        }
    }
}

class Program
{
    static void Main()
    {
        TrafficLight trafficLight = new TrafficLight();

        
        Console.WriteLine("Kırmızı ışık durumu: " + trafficLight.DurumuAcikla(TrafficLightState.Red));
        Console.WriteLine("Sarı ışık durumu: " + trafficLight.DurumuAcikla(TrafficLightState.Yellow));
        Console.WriteLine("Yeşil ışık durumu: " + trafficLight.DurumuAcikla(TrafficLightState.Green));
    }
}
