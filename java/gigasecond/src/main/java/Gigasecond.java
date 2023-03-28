import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.ZoneOffset;

public class Gigasecond {

    private LocalDateTime moment;
    private final int giga = 1_000_000_000;

    public Gigasecond(LocalDate moment) {
        this.moment = moment.atTime(0, 0);
    }

    public Gigasecond(LocalDateTime moment) {
        this.moment = moment;
    }

    public LocalDateTime getDateTime() {
        return moment.plusSeconds(giga);
    }
}
