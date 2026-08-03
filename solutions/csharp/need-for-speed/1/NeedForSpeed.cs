class RemoteControlCar
{
    public int speed, batteryDrain, distanceDriven;
    public int currentBattery = 100;
    
    public RemoteControlCar(int speed, int batDrain) {
        this.speed = speed;
        this.batteryDrain = batDrain;
    }

    public bool BatteryDrained() => (currentBattery < batteryDrain) ? true : false;

    public int DistanceDriven() => distanceDriven;
        
    public void Drive()
    {
        if(currentBattery < batteryDrain) return;
        
        distanceDriven += speed;
        currentBattery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance) 
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int requiredDrives = (distance + car.speed - 1) / car.speed;
        return ((car.batteryDrain * requiredDrives) > car.currentBattery) ? false : true;
    }
}
