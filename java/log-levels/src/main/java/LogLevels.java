public class LogLevels {

    public static String message(String logLine) {
        return logLine.split("]:")[1].strip();
    }

    public static String logLevel(String logLine) {
        int beg = logLine.indexOf("[") + 1;
        int end = logLine.indexOf("]");
        return logLine.substring(beg, end).toLowerCase();
    }

    public static String reformat(String logLine) {
        String mess = message(logLine);
        String levl = logLevel(logLine);
        return mess + " (" + levl + ")";
    }
}
