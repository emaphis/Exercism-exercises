/**
 * Main class to test my code
 * @author emaph
 */
public class Main {
    public static void main(String[] args) {
        TwelveDays twelveDays = new TwelveDays();
        //String out = days.verses(1, 12);
        System.out.println("********************");
        System.out.println(twelveDays.verses(1, 3));
        System.out.println("********************");
        String expectedVersesOneToThree = "On the first day of Christmas my true love gave to me: " +
                "a Partridge in a Pear Tree.\n\n" +
                "On the second day of Christmas my true love gave to me: two Turtle Doves, " +
                "and a Partridge in a Pear Tree.\n\n" +
                "On the third day of Christmas my true love gave to me: three French Hens, two Turtle Doves, " +
                "and a Partridge in a Pear Tree.\n";
        System.out.println(expectedVersesOneToThree);
        System.out.println("********************");
    }
}
