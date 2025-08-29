public class CarsAssemble {

    private double successRate(int speed) {
        double successRate;

        if (speed < 5)
            successRate = 1.00;
        else if (speed < 9)
            successRate = 0.90;
        else if (speed < 10)
            successRate = 0.80;
        else
            successRate = 0.77;

        return successRate;
    }

    public double productionRatePerHour(int speed) {
        final double BASE_RATE = 221.0;

        return speed * BASE_RATE * successRate(speed);
    }

    public int workingItemsPerMinute(int speed) {
        final int MINUTSPERHOUR = 60;

        return (int) productionRatePerHour(speed) / MINUTSPERHOUR;
    }
}
