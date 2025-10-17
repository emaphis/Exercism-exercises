
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

class DnDCharacter {

    private final int numDie = 4;

    private final int strength;
    private final int dexterity;
    private final int constitution;
    private final int intelligence;
    private final int wisdom;
    private final int charisma;
    private final int hitpoints;

    public DnDCharacter() {
        this.strength = getAbility();
        this.dexterity = getAbility();
        this.constitution = getAbility();
        this.intelligence = getAbility();
        this.wisdom = getAbility();
        this.charisma = getAbility();
        this.hitpoints = getHPoints();
    }

    private int getAbility() {
        return ability(rollDice());
    }

    private int getHPoints() {
        return 10 + modifier(this.constitution);
    }

    int ability(List<Integer> scores) {
        int min = Collections.min(scores);
        int sum = 0;
        for (Integer score : scores) {
            sum += score;
        }
        return sum - min;  // slick!
    }

    List<Integer> rollDice() {
        List<Integer> rolls = new ArrayList<>(numDie);
        Random rand = new Random();
        for (int i = 0; i < numDie; i++) {
            rolls.add(rand.nextInt(6) + 1); // 1 .. 6
        }
        return rolls;
    }

    int modifier(int input) {
        return Math.floorDiv(input - 10, 2);
    }

    int getStrength() {
        return strength;
    }

    int getDexterity() {
        return dexterity;
    }

    int getConstitution() {
        return constitution;
    }

    int getIntelligence() {
        return intelligence;
    }

    int getWisdom() {
        return wisdom;
    }

    int getCharisma() {
        return charisma;
    }

    int getHitpoints() {
        return hitpoints;
    }
}
