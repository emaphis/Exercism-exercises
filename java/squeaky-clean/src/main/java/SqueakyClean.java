class SqueakyClean {

    static char leetCode (char aChar) {
        if (aChar == '0')
            return 'o';
        else if (aChar == '1')
            return 'l';
        else if (aChar == '3')
            return 'e';
        else if (aChar == '4')
           return 'a';
        else if (aChar == '7')
            return 't';
        return ' ';
    }

    static String clean(String identifier) {
        char[] chars = identifier.toCharArray();
        StringBuilder bld = new StringBuilder();

        for (int i = 0; i < chars.length; i++) {
            char aChar = chars[i];

            if (aChar == ' ')
                bld.append('_');
            else if (aChar == '-')
                bld.append(Character.toUpperCase(chars[++i]));
            else if (Character.isDigit(aChar))
                bld.append(leetCode(aChar));
            else if (Character.isAlphabetic(aChar))
                bld.append(aChar);
        }

        return bld.toString();
    }
}
