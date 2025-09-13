class SqueakyClean {
    static String clean(String identifier) {
        char[] chars = identifier.toCharArray();
        StringBuilder bld = new StringBuilder();
        for (int i = 0; i < chars.length; i++) {
            char aChar = chars[i];
            if (aChar == ' ')
                bld.append('_');
            else if (aChar == '-')
                bld.append(Character.toUpperCase(chars[++i]));
            else if (aChar == '0')
                bld.append('o');
            else if (aChar == '1')
                bld.append('l');
            else if (aChar == '3')
                bld.append('e');
            else if (aChar == '4')
                bld.append('a');
            else if (aChar == '7')
                bld.append('t');
            else if (aChar == '¡' || aChar == '!') { }
            else if (Character.isAlphabetic(aChar))
                bld.append(aChar);
        }
        return bld.toString();
    }
}
