m = [int(input()) for i in range(int(input()))]
for i in range(2, len(m) - 1):
tmp = len(m)
if(m[i] >= m[0] + m[-1]): m.pop(i)
if(len(m) == tmp):
	for i in range(2, len(m) - 1):
	m.pop(i)
print(round(sum(m) / len(m), 3))