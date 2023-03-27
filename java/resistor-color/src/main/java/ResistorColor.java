class ResistorColor {
    
    final String[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    int colorCode(String color) {
        int index = 0;
        
        while (!colors[index].equals(color))
            index++;
        
        return index;
    }

    String[] colors() {
        return colors;
    }
}
