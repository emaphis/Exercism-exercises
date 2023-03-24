package binarysearch

func SearchInts(list []int, key int) int {
	var mid = 0
	for lo, hi := 0, len(list)-1; lo <= hi; {
		mid = (lo + hi) / 2
		if list[mid] < key {
			lo = mid + 1
		} else if list[mid] > key {
			hi = mid - 1
		} else {
			return mid
		}
	}

	return -1
}
