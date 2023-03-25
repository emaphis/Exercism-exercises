public class LogLevels {

    public static String message(String logLine) {
        int pos  = logLine.indexOf(":");
        return logLine.substring(pos + 1).trim();
    }

    public static String logLevel(String logLine) {
        int pos = logLine.indexOf("]");
        return logLine.substring(1, pos).toLowerCase();
    }

    public static String reformat(String logLine) {
        return message(logLine) + " (" + logLevel(logLine) + ")";
    }
}
