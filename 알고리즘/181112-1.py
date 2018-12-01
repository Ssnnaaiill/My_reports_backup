def hanoi(n, _from, _by, _to):
	if(n == 1):
		print("{} {}".format(_from, _to))
		return
	hanoi(n - 1, _from, _to, _by)
	print("{} {}".format(_from, _to))
	hanoi(n - 1, _by, _from, _to)
n = int(input())
if(n != 0):
	print(pow(2, n) - 1)
	hanoi(n, 1, 2, 3)