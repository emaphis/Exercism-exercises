public class CarsAssemble {

    private final int BASE_RATE = 221;

    public double productionRatePerHour(int speed) {
        int rate = BASE_RATE * speed;
        return rate * successRate(speed);
    }

    public int workingItemsPerMinute(int speed) {
        return (int) productionRatePerHour(speed) / 60;
    }


    private double successRate(double speed) {
        if (speed <= 4)
            return 1.0;
        else if (speed <= 8)
            return .90;
        else if (speed == 9)
            return 0.80;
        else
            return 0.77;
    }
}
