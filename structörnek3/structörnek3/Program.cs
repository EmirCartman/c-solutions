using System;

public struct GPSLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }


    public GPSLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    
    public double MesafeHesapla(GPSLocation other)
    {
        const double R = 6371; 


        double lat1 = ToRadians(this.Latitude);
        double lon1 = ToRadians(this.Longitude);
        double lat2 = ToRadians(other.Latitude);
        double lon2 = ToRadians(other.Longitude);

       
        double dlat = lat2 - lat1;
        double dlon = lon2 - lon1;

        double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Sin(dlon / 2) * Math.Sin(dlon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

       
        double distance = R * c;

        return distance;
    }

   
    private double ToRadians(double degree)
    {
        return degree * (Math.PI / 180);
    }
}

class Program
{
    static void Main()
    {
       
        GPSLocation konum1 = new GPSLocation(41.0082, 28.9784); 
        GPSLocation konum2 = new GPSLocation(40.7128, -74.0060); 

        
        double mesafe = konum1.MesafeHesapla(konum2);

        Console.WriteLine($"İstanbul ve New York arasındaki mesafe: {mesafe:F2} kilometre");
    }
}
