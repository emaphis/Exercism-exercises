import java.util.ArrayList;
import java.util.List;
import java.util.Collections;

class HighScores {
    private final List<Integer> highScores;

    public HighScores(List<Integer> highScores) {
        this.highScores = highScores;
    }

    List<Integer> scores() {
        return List.copyOf(highScores);
    }

    Integer latest() {
        return highScores.getLast();
    }

    Integer personalBest() {
        return Collections.max(highScores);
    }

    List<Integer> personalTopThree() {
        List<Integer> scores = new ArrayList<>();
        scores.addAll(highScores);
        scores.sort(Collections.reverseOrder());
        int index = Math.min(3, scores.size());
        return scores.subList(0, index);
    }

}
