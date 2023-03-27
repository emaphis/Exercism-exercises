import java.util.ArrayList;
import java.util.List;

class ProteinTranslator {

    private String translateCoden(String codon) {
        switch (codon) {
            case "AUG":	return "Methionine";
            
            case "UUU":
            case "UUC": return "Phenylalanine";
            
            case "UUA":
            case "UUG":	return "Leucine";

            case "UCU":
            case "UCC":
            case "UCA":
            case "UCG": return "Serine";
            
            case "UAU":
            case "UAC": return "Tyrosine";
            
            case "UGU":
            case "UGC": return "Cysteine";
            
            case "UGG": return "Tryptophan";

            case "UAA":
            case "UAG":
            case "UGA": return "STOP";
            
            default:
                throw new IllegalArgumentException();
        }
    }
    
    List<String> translate(String rnaSequence) {
         List<String> proteinList = new ArrayList<>();
         
         String protean;
         int index = 0;
         while (index < rnaSequence.length()) {
             String codon = rnaSequence.substring(index, index + 3);
             protean = translateCoden(codon);
             if (protean.equals("STOP"))
                 break;
             proteinList.add(protean);
             index += 3;  // chunk by three
         }
         
         return proteinList;
    }
}
