
/**
 * Program to test my code
 * @author emaph
 */
public class Main {
    
    static void example(String stringToVerify) {
        
        String number = stringToVerify.replace("-", "");
        
        System.out.println("Number: " + number);
        int sum = 0;
        for (int i = 0; i < 9; i++) {
            int num = number.charAt(i) - 48;
            int factor = number.length() - i;
            int mult = num * factor;
            sum += mult;
            System.out.print(num + "*" + factor + ", ");
           
        }
        int num;
        if (number.charAt(9)  == 'X')
            num = 10;
        else
            num = number.charAt(9) - 48;
        sum += num;
        int ret = sum % 11;
        System.out.println(num + "*1 =" + sum + " -> " + ret);
    }

    public static void main(String[] args) {
        String isbnA = "3-598-21508-8"; // true
        String isbnB = "3-598-21507-X"; // true
        
        example(isbnA);
        System.out.println("********************");
        example(isbnB);
        System.out.println("********************");
        
        String isbnC = "3-598-21508-9";  // false
        example(isbnC);
        
        System.out.println("********************");
        String isbnD = "ABCDEFG3-598-21507-XQWERTYUI"; //false
        example(isbnD);
    }
}
