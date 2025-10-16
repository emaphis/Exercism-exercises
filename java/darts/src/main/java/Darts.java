class Darts {
    int score(double xOfDart, double yOfDart) {
        double radius = Math.sqrt(xOfDart * xOfDart + yOfDart * yOfDart);
        int score;

        if     (radius > 10.0) score = 0;
        else if (radius > 5.0) score = 1;
        else if (radius > 1.0) score = 5;
        else score = 10;

        return score;
    }
}
