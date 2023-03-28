import java.math.BigInteger;

class Grains {

    BigInteger grainsOnSquare(final int square) {

        if (square < 1 || square > 64) {
            throw new IllegalArgumentException("square must be between 1 and 64");
        }

        BigInteger result = BigInteger.ONE;
        for (int i = 1; i < square; i++) {
            result = result.multiply(BigInteger.TWO);
        }
        return result;
    }

    BigInteger grainsOnBoard() {
        BigInteger result = BigInteger.ONE;
        BigInteger sum = BigInteger.ONE;
        for (int i = 1; i < 64; i++) {
            result = result.multiply(BigInteger.TWO);
            sum = sum.add(result);
        }
        return sum;
    }

}
