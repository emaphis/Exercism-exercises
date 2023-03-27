class RotationalCipher {
    private int shiftKey;
    private final String alphabet = "abcdefghijklmnopqrstuvwxyz"; 
    
    RotationalCipher(int shiftKey) {
        this.shiftKey = shiftKey;
    }

    String rotate(String data) {
        StringBuilder encripted = new StringBuilder();
        
        for (char chr : data.toCharArray()) {
            
            if (Character.isLetter(chr)) {
                if (Character.isLowerCase(chr)) {
                    chr = (char) ('a' + ((chr - 'a') + shiftKey) % 26);
                } else {
                    chr = (char) ('A' + ((chr - 'A') + shiftKey) % 26);
                }
            }
            
            encripted.append(chr);
        }
        
        return encripted.toString();
   }

}
