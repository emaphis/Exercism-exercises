
import java.util.Objects;

class MicroBlog {
    public String truncate(String input) {
        if (Objects.isNull(input)) {
            return null;
        }
        final int LIMIT = 5;
        int count = input.codePointCount(0, input.length());

        if (count > LIMIT)
            return input.substring(0, input.offsetByCodePoints(0, LIMIT));
        else
            return input;
    }
}
