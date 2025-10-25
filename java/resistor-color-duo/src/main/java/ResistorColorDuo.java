
import java.util.Arrays;

class ResistorColorDuo {
    final String[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    int colorCode(String color) {
        return Arrays.asList(colors).indexOf(color);
    }
    
    int value(String[] colors) {
        return colorCode(colors[1]) + colorCode(colors[0]) * 10;
    }
}
