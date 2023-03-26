class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder cleaned = new StringBuilder();
        boolean isKebab = false;

        for (char chr : identifier.toCharArray()) {
            if (Character.isSpaceChar(chr)) {           // Task 1
                cleaned.append('_');
            } else if (Character.isISOControl(chr)) {   // Task 2
                cleaned.append("CTRL");
            } else if (chr == '-') {                    // Task 3 
               isKebab = true;
            } else if (Character.isLetter(chr) &&       // Task 4
                    !(chr >= '?' && chr <= '?')) {      // Task 5
                if (isKebab)                          
                    chr = Character.toUpperCase(chr);
                cleaned.append(chr);
                isKebab = false;
            }
        }

        return cleaned.toString();
    }
}
