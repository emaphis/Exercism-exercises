public class ExperimentalRemoteControlCar implements RemoteControlCar  {
    private int distance = 0;

    @Override
    public void drive() {
        distance += 20;
    }

    @Override
    public int getDistanceTravelled() {
        return distance;
    }
}
