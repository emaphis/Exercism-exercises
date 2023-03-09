package parsinglogfiles

import "regexp"

func IsValidLine(text string) bool {
	reg, _ := regexp.Compile(`^\[(TRC|DBG|INF|WRN|ERR|FTL)\]`)
	return reg.MatchString(text)
}

func SplitLogLine(text string) []string {
	reg, _ := regexp.Compile(`<[*~=-]*>`)
	return reg.Split(text, -1)
}

func CountQuotedPasswords(lines []string) int {
	reg, _ := regexp.Compile(`(?i)".*password.*"`)
	count := 0
	for _, password := range lines {
		if reg.MatchString(password) {
			count++
		}
	}
	return count
}

func RemoveEndOfLineText(text string) string {
	reg, _ := regexp.Compile(`end-of-line\d+`)
	return reg.ReplaceAllString(text, "")
}

func TagWithUserName(lines []string) []string {
	var list []string
	reg, _ := regexp.Compile(`\sUser\s+(\S+)`)
	for _, line := range lines {
		name := reg.FindStringSubmatch(line)
		if len(name) > 1 {
			line = "[USR] " + name[1] + " " + line
		}
		list = append(list, line)
	}
	return list
}
