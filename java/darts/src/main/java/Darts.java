class Darts {
    int score(double xOfDart, double yOfDart) {
        double radius = getRadius(xOfDart, yOfDart);

        if (radius <= 1.0) {
            return 10;
        } else if (radius <= 5.0) {
            return 5;
        } else if (radius <= 10.0) {
            return 1;
        }

        return 0;
    }

    private double getRadius(double x, double y) {
        return Math.sqrt(x*x + y*y);
    }
}
