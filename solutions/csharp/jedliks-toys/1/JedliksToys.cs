class RemoteControlCar
{
    public int distance = 0;
    public int battery = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {this.distance} meters";

    public string BatteryDisplay() {
        if(this.battery <= 0) {
            return "Battery empty";
        }
        else {
            return $"Battery at {this.battery}%";
        }
        
    }

    public void Drive()
    {
        if(this.battery <= 0) {
            return;
        }
        
        this.distance += 20;
        this.battery--;
    }
}
