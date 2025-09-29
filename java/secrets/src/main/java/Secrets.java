public class Secrets {
    public static int shiftBack(int value, int amount) {
        return value >>> amount;
    }

    public static int setBits(int value, int mask) {
        return value | mask;  // or the bit mask.
    }

    public static int flipBits(int value, int mask) {
        return value ^ mask;   // xor the bit mask.
    }

    public static int clearBits(int value, int mask) {
        return (value & ~mask);  // and the reverse of the bit mask.
    }
}