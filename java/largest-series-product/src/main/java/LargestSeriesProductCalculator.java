
class LargestSeriesProductCalculator {

    private int[] number;

    LargestSeriesProductCalculator(String inputNumber) {
        this.number = new int[inputNumber.length()];

        for (int i = 0; i < inputNumber.length(); i++) {
            char chr = inputNumber.charAt(i);
            if (!Character.isDigit(chr)) {
                throw new IllegalArgumentException("String to search may only contain digits.");
            }

            this.number[i] = Character.getNumericValue(chr);
        }
    }

    /**
     * temp
     */
    public int[] getNumber() {
        return number;
    }

    long calculateLargestProductForSeriesLength(int numberOfDigits) {
        if (numberOfDigits < 0) {
            throw new IllegalArgumentException("Series length must be non-negative.");
        } else if (numberOfDigits == 0) {
            return 1;
        } else if (numberOfDigits > number.length) {
            throw new IllegalArgumentException("Series length must be less than or equal to the length of the string to search.");
        }

        long largest = 0l;
        //long result = 0;

        int numberOfSeriesToCheck = number.length - numberOfDigits + 1;

        for (int startIndex = 0; startIndex < numberOfSeriesToCheck; startIndex++) {
            /*
                 * Note: computing the product of each series fresh each time is not the most efficient solution, but
                 * it's the simplest to reason about.
             */
            largest = Math.max(largest, computeProductOfSeries(startIndex, numberOfDigits));
        }

        return largest;
    }

    private long computeProductOfSeries(final int startIndex, final int seriesLength) {
        // The multiplicative identity is 1.
        long result = 1;

        final int endIndex = startIndex + seriesLength - 1;

        for (int characterIndex = startIndex; characterIndex <= endIndex; characterIndex++) {
            result = result * Character.getNumericValue(number[characterIndex]);
        }

        return result;
    }
}
