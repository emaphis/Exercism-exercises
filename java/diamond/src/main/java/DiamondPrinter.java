import java.util.ArrayList;
import java.util.List;

class DiamondPrinter {

    List<String> printToList(char a) {
        List<String> rows = new ArrayList<>();
        
        for (char ch = 'A'; ch < a; ch++) {
            rows.add(getRow(ch, a));
        }
        
        for (char ch = a; ch >= 'A'; ch--) {
            rows.add(getRow(ch, a));
        }
        
        return rows;
    }
    
    private String getRow(char ch, char end) {
        int length = (end - 'A') * 2 + 1;
        char[] row = new char[length];
        
        for (int i = 0; i < length; i++) {
            row[i] = ' ';
        }
        
        row[end - ch] = ch;
        row[end + ch - 2 * 'A'] = ch;
        
        return String.valueOf(row);
    }

}
