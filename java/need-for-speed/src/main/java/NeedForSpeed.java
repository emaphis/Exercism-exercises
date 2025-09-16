class NeedForSpeed {
    private int speed;
    private int batteryDrain;
    private int batteryCharge = 100;
    private int distanceDriven = 0;

    NeedForSpeed(int speed, int batteryDrain) {
       this.speed = speed;
       this.batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() {
        return batteryCharge < batteryDrain;
    }

    public int distanceDriven() {
        return distanceDriven;
    }

    public void drive() {
       if (!batteryDrained()) {
           batteryCharge -= batteryDrain;
           distanceDriven += speed;
       }
    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50, 4);
    }
}

class RaceTrack {
    private final int distance;

    RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean canFinishRace(NeedForSpeed car) {
        // Pretend drive the car around the track.
        while (distance > car.distanceDriven()) {
            if (car.batteryDrained())
                return false;
            car.drive();
        }
        return true;
    }
}
