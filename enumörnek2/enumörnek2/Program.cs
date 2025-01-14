using System;

public enum WeatherCondition
{
    Sunny,  
    Rainy, 
    Cloudy, 
    Stormy  
}

public class WeatherForecast
{
   
    public string TavsiyeVer(WeatherCondition condition)
    {
        switch (condition)
        {
            case WeatherCondition.Sunny:
                return "Bugün güneşli! Şapka takmayı unutma.";
            case WeatherCondition.Rainy:
                return "Yağmurlu hava! Şemsiye almayı unutma.";
            case WeatherCondition.Cloudy:
                return "Bulutlu hava! Hafif bir ceket giymek iyi olabilir.";
            case WeatherCondition.Stormy:
                return "Fırtına var! Dışarı çıkmamaya çalış.";
            default:
                return "Geçersiz hava durumu!";
        }
    }
}

class Program
{
    static void Main()
    {
        WeatherForecast forecast = new WeatherForecast();

        
        Console.WriteLine("Güneşli hava durumu: " + forecast.TavsiyeVer(WeatherCondition.Sunny));
        Console.WriteLine("Yağmurlu hava durumu: " + forecast.TavsiyeVer(WeatherCondition.Rainy));
        Console.WriteLine("Bulutlu hava durumu: " + forecast.TavsiyeVer(WeatherCondition.Cloudy));
        Console.WriteLine("Fırtınalı hava durumu: " + forecast.TavsiyeVer(WeatherCondition.Stormy));
    }
}
