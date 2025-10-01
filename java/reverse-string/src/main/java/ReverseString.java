class ReverseString {

    String reverse(String inputString) {
        StringBuilder build = new StringBuilder(inputString);
        return build.reverse().toString();
    }

}
