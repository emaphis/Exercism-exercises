import java.util.HashMap;
import java.util.Map;

public class DialingCodes {
    private final Map<Integer, String> dialingCodes = new HashMap<>();

    public Map<Integer, String> getCodes() {
        // should return copy
        return Map.copyOf(dialingCodes);
    }

    public void setDialingCode(Integer code, String country) {
        dialingCodes.put(code, country);
    }

    public String getCountry(Integer code) {
        return dialingCodes.get(code);
    }

    public void addNewDialingCode(Integer code, String country) {
        if (!dialingCodes.containsValue(country))  // if it doesn't already exist
            dialingCodes.putIfAbsent(code, country);
    }

    public Integer findDialingCode(String country) {
        // have to search the whole map by pairs
        for (Map.Entry<Integer, String> entry : dialingCodes.entrySet()) {
            if (entry.getValue().equals(country))
                return entry.getKey();
        }

        return null;
    }

    public void updateCountryDialingCode(Integer code, String country) {
        // Check if code preexists.
        Integer existing = findDialingCode(country);
        if (existing != null) {
            dialingCodes.remove(existing);
            dialingCodes.put(code, country);
        }
    }
}
