n = int(input())
cnt = 1
MAX = 0
MAXcnt = 0
while n != 1:
	if(n % 3 == 0): n = n / 3
	elif(n % 3 == 1): n = 5 * n - 2
	else: n = 5 * n - 1
	cnt = cnt + 1
	if(n >= MAX):
		MAX = n
		MAXcnt = cnt
print(cnt)
print(MAXcnt, int(MAX))