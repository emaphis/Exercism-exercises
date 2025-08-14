module LogLevels

let message (logLine: string): string = (logLine.Split(':')[1]).Trim()

let logLevel(logLine: string): string =
    let idx = logLine.IndexOf(':')
    logLine.Substring(1, idx - 2).ToLower()

let reformat(logLine: string): string =
    let msg = message logLine
    let loglvl = logLevel logLine
    sprintf "%s (%s)" msg loglvl
