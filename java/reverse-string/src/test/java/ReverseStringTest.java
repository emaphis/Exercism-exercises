import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class ReverseStringTest {

    @Test
    @DisplayName("an empty string")
    public void testAnEmptyString() {
        assertThat(new ReverseString().reverse("")).isEqualTo("");
    }

    @Test
    @DisplayName("a word")
    public void testAWord() {
        assertThat(new ReverseString().reverse("robot")).isEqualTo("tobor");
    }

    @Test
    @DisplayName("a capitalized word")
    public void testACapitalizedWord() {
        assertThat(new ReverseString().reverse("Ramen")).isEqualTo("nemaR");
    }

    @Test
    @DisplayName("a sentence with punctuation")
    public void testASentenceWithPunctuation() {
        assertThat(new ReverseString().reverse("I'm hungry!")).isEqualTo("!yrgnuh m'I");
    }

    @Test
    @DisplayName("a palindrome")
    public void testAPalindrome() {
        assertThat(new ReverseString().reverse("racecar")).isEqualTo("racecar");
    }

    @Test
    @DisplayName("an even-sized word")
    public void testAnEvenSizedWord() {
        assertThat(new ReverseString().reverse("drawer")).isEqualTo("reward");
    }
}
