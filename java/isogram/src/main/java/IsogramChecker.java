class IsogramChecker {

    boolean isIsogram(String phrase) {
        int[] list = new int[26];
        
        for (int i = 0; i < phrase.length(); i++) {
            char chr = phrase.charAt(i);
            if (Character.isLetter(chr)) {
                int idx = Character.toLowerCase(chr) - 97;
                list[idx]++;
            }
        }
        
        boolean iso = true;
        for (int i = 0; i < list.length; i++) {
            if (list[i] > 1) {
                iso = false;
            }
        }
        
        return iso;
    }

}
