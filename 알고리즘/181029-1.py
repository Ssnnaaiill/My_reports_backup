n = int(input())
k = int(input())
a = []
coin = 0
for i in range(0,n):
	a.append(int(input()))
a.reverse()
for i in range(0,len(a)):
	if(k >= a[i]):
		coin = k / a[i] + coin
		k = k % a[i]
print(int(coin))