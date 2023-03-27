class ResistorColorDuo {
    
    final String[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    // from previous example
    int colorCode(String color) {
        int index = 0;
        
        while (!colors[index].equals(color))
            index++;
        
        return index;
    }
    
    int value(String[] colors) {
        return (colorCode(colors[0]) * 10) + colorCode(colors[1]);
    }
}
