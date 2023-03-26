class TwelveDays {
    
    private static String[] days = new String[]{"first", "second", "third", "fourth", "fifth", "sixth", "seventh",
        "eighth", "ninth", "tenth", "eleventh", "twelfth"};
    
    private static String[] gifts = new String[]{
        "a Partridge in a Pear Tree.",
        "two Turtle Doves, ",
        "three French Hens, ",
        "four Calling Birds, ",
        "five Gold Rings, ",
        "six Geese-a-Laying, ",
        "seven Swans-a-Swimming, ",
        "eight Maids-a-Milking, ",
        "nine Ladies Dancing, ",
        "ten Lords-a-Leaping, ",
        "eleven Pipers Piping, ",
        "twelve Drummers Drumming, "
    };

    String verse(int verseNumber) {
        StringBuilder out = new StringBuilder("On the " + days[verseNumber - 1]
                + " day of Christmas my true love gave to me: ");
        
        for (int i = verseNumber; i > 0; i--) {
            if (verseNumber != 1 && i == 1)
                out.append("and ");
            
            out.append(gifts[i-1]);
        }

        out.append("\n");
        
        return out.toString();
    }

    String verses(int startVerse, int endVerse) {
        StringBuilder out = new StringBuilder(verse(startVerse));
        for (int i = startVerse + 1; i <= endVerse; i++) {
            out.append("\n");
            out.append(verse(i));
        }
        
        return out.toString();
    }
    
    String sing() {
        return verses(1, 12);
    }
}
