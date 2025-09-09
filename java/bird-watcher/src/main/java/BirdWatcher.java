
class BirdWatcher {
    private final int[] birdsPerDay;


    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        return birdsPerDay;
    }

    public int getToday() {
        return birdsPerDay[birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() {
        birdsPerDay[birdsPerDay.length - 1]++;
    }

    public boolean hasDayWithoutBirds() {
        boolean zeroDay = false;
        for (int dayNum : birdsPerDay) {
            if (dayNum == 0)
                zeroDay = true;
        }

        return zeroDay;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int sum = 0;
        if (numberOfDays > birdsPerDay.length)
            numberOfDays = birdsPerDay.length;

        for (int i = 0; i < numberOfDays; i++) {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int getBusyDays() {
        int total = 0;

        for (int day : birdsPerDay) {
            if (day >= 5) {
                total++;
            }
        }
        return total;
    }
}
