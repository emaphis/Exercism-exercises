public class Lasagna {

    // Return expeted minutes in the oven.
    public int expectedMinutesInOven() {
        return 40;
    }

    // return the remainint time in oven given actual time in oven
    public int remainingMinutesInOven(int actualMinutesInOven) {
        return expectedMinutesInOven() - actualMinutesInOven;
    }

    // Return proparation time given the number of layers.
    public int preparationTimeInMinutes(int numberOfLayers) {
        return numberOfLayers * 2;
    }

    // Return the total cooking time in minutes given the number of layers and the actual time in the overn
    public int totalTimeInMinutes(int numberOfLayers, int actualMinutesInOven) {
        return preparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
    }
}
