
import java.util.List;


/**
 * App to test code.
 * @author emaph
 */
public class Main {
    public static void main(String[] args) {
        var diamond = new DiamondPrinter();
        List<String> rows = diamond.printToList('F');
        
        for (String row : rows) {
            System.out.println(row);
        }
    }
}
