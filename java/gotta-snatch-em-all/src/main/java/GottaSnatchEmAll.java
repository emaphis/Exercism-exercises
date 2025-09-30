import java.util.HashSet;
import java.util.List;
import java.util.Set;

class GottaSnatchEmAll {

    static Set<String> newCollection(List<String> cards) {
        return new HashSet<>(cards);
    }

    static boolean addCard(String card, Set<String> collection) {
        return collection.add(card);
    }

    static boolean canTrade(Set<String> myCollection, Set<String> theirCollection) {
       boolean iCanTrade = !myCollection.containsAll(theirCollection);
       boolean youCanTrade = !theirCollection.containsAll(myCollection);
       return iCanTrade && youCanTrade;
    }

    static Set<String> commonCards(List<Set<String>> collections) {
        if (collections.isEmpty())
            return Set.of();

        Set<String> intersection = new HashSet<>(collections.getFirst());
        for (int i = 1; i < collections.size(); i++) {
            intersection.retainAll(collections.get(i));
        }
        return intersection;
    }

    static Set<String> allCards(List<Set<String>> collections) {
        Set<String> union = new HashSet<>();

        for (Set<String> cards : collections) {
            union.addAll(cards);
        }

        return union;
    }
}
