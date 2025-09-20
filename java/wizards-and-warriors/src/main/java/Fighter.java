class Fighter {

    boolean isVulnerable() {
        return true;
    }

    int getDamagePoints(Fighter fighter) {
        return 1;
    }
}

class Warrior extends Fighter {
    private final String name = "Warrior";

    @Override
    boolean isVulnerable() {
        return false;
    }

    @Override
    int getDamagePoints(Fighter fighter) {
        return fighter.isVulnerable() ? 10 : 6;
    }

    @Override
    public String toString() {
        return "Fighter is a " + name;
    }
}

class Wizard extends Fighter {
    private final String name = "Wizard";
    private boolean  isPreparedSpell = false;

    @Override
    boolean isVulnerable() {
        return !isPreparedSpell;
    }

    @Override
    int getDamagePoints(Fighter fighter) {
       return isPreparedSpell ? 12 : 3;
    }

    void prepareSpell() {
        isPreparedSpell = true;
    }

    @Override
    public String toString() {
        return "Fighter is a " + name;
    }
}
