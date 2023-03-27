class Scrabble {
    private String word;
    
    private int[] letters = new int[] {
        1,  // a
        3,  // b
        3,  // c
        2,  // d
        1,  // e
        4,  // f
        2,  // g
        4,  // h
        1,  // i
        8,  // j
        5,  // k
        1,  // l
        3,  // m
        1,  // n
        1,  // o
        3,  // p
       10,  // q
        1,  // r
        1,  // s
        1,  // t
        1,  // u
        4,  // v
        4,  // w
        8,  // x
        4,  // y
       10   // z
    };
    
    Scrabble(String word) {
        this.word = word;
    }

    int getScore() {
        int sum = 0;
        for (int i = 0; i < word.length(); i++) {
            int idx = Character.toLowerCase(word.charAt(i)) - 97;
            sum += letters[idx];
        }
        return sum;
    }

}
