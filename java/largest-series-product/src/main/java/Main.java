
import java.util.Arrays;

/**
 * App for testing my code
 *
 * @author emaph
 */
public class Main {
    public static void main(String[] args) {
        LargestSeriesProductCalculator lp = new LargestSeriesProductCalculator("29");
        System.out.println("LP: " + Arrays.toString(lp.getNumber()));
        System.out.println("Largest " + lp.calculateLargestProductForSeriesLength(2));

        var lp3 = new LargestSeriesProductCalculator("73167176531330624919225119674426574742355349194934");
        System.out.println("lp3 = " + Arrays.toString(lp3.getNumber()));
        var out3 = lp3.calculateLargestProductForSeriesLength(6);
        System.out.println("out3 = " + out3);
    }
}
