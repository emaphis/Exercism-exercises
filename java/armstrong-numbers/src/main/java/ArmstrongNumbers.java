class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {
        int rest = numberToCheck;
        int accum = 0;
        int expon = String.valueOf(numberToCheck).length();

        while (rest > 0) {
            accum += Math.pow((rest % 10), expon);
            rest = rest / 10;
        }

        return accum == numberToCheck;
    }

}
