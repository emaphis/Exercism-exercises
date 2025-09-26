import java.util.Random;

class CaptainsLog {

    private static final char[] PLANET_CLASSES = new char[]{'D', 'H', 'J', 'K', 'L', 'M', 'N', 'R', 'T', 'Y'};

    private Random random;

    CaptainsLog(Random random) {
        this.random = random;
    }

    char randomPlanetClass() {
        int leng =  PLANET_CLASSES.length;
        return PLANET_CLASSES[random.nextInt(leng)];
    }

    String randomShipRegistryNumber() {
        int start = 1000;
        int end = 10000;
        String regNum = String.valueOf(start + random.nextInt(end - start));

        return "NCC-" + regNum;
    }

    double randomStardate() {
        double start = 41000.0;
        double end = 42000.0;

        return start + random.nextDouble() * (end - start);
    }
}
