
/**
 * Main class to test my code.
 * @author emaph
 */
public class Main {
    public static void main(String[] args) {
        String[] words  = new String[]{"nail", "shoe", "horse", "rider", "message", "battle", "kingdom"};
        Proverb proverb = new Proverb(words);
        System.out.println(proverb.recite());
    }
}
