using System;

static class AssemblyLine
{
    const double carProduction = 221;
    
    public static double SuccessRate(int speed)
    {
        
        if (speed == 0)
        {
            return 0;
        }
        else if (speed >=1 && speed <= 4)
        {
            return 1;
        }
        else if (speed >=5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
      if (speed == 0)
        {
            return carProduction * speed;
        }
        else if (speed >=1 && speed <= 4)
        {
            return carProduction * speed;
        }
        else if (speed >=5 && speed <= 8)
        {
            return carProduction * speed * 0.9;
        }
       else if (speed == 9)
       {
           return carProduction * speed * 0.8;
       }
       else
       {
           return carProduction * speed * 0.77;
       }
      
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workPerMinutes = ProductionRatePerHour(speed);
        double itemPerMinute  = workPerMinutes / 60;
        return (int)itemPerMinute;
    }
}
