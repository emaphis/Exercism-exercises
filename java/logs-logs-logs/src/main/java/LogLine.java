public class LogLine {
    private final LogLevel logLevel;
    private final String logMsg;

    public LogLine(String logLine) {
        this.logLevel = parseLogLevel(logLine);
        this.logMsg = logLine.substring(7);
    }

    private LogLevel parseLogLevel(String logLine) {
        String token = logLine.substring(1, 4);
        LogLevel level = switch (token) {
            case "TRC" -> LogLevel.TRACE;
            case "DBG" -> LogLevel.DEBUG;
            case "INF" -> LogLevel.INFO;
            case "WRN" -> LogLevel.WARNING;
            case "ERR" -> LogLevel.ERROR;
            case "FTL" -> LogLevel.FATAL;
            default -> LogLevel.UNKNOWN;
        };
        return level;
    }

    public LogLevel getLogLevel() {
        return logLevel;
    }

    public String getOutputForShortLog() {
        return String.valueOf(logLevel.getCode() + ":" + logMsg);
    }
}
