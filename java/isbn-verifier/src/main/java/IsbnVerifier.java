class IsbnVerifier {
    
    boolean isValid(String stringToVerify) {
        String number = stringToVerify.replace("-", "");
        
        if (number.length() != 10) return false;
        
        int sum = 0;
        for (int i = 0; i < 9; i++) {
            int num = number.charAt(i) - 48;
            int factor = number.length() - i;
            sum += num * factor;
        }
        
        if (number.charAt(9)  == 'X')
            sum += 10;
        else
            sum += number.charAt(9) - 48;        
       
        return (sum % 11) == 0;
    }

}
