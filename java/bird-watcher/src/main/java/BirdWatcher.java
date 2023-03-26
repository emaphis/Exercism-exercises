
class BirdWatcher {
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        return birdsPerDay.clone();
    }

    public int getToday() {
        return birdsPerDay[birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() {
        birdsPerDay[birdsPerDay.length - 1]++;
    }

    public boolean hasDayWithoutBirds() {
        boolean hasZeroDay = false;
        for (int num : birdsPerDay) {
            if (num == 0)
                hasZeroDay = true;
        }
        return hasZeroDay;
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
        int BUSY = 5;
        int count = 0;
        for (int num : birdsPerDay) {
            if (num >= BUSY)
                count++;
        }
        return count;
    }
}
