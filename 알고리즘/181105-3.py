n = list(input())
N = []
for i in range(0, len(n)): N.append(int(n[i]))
N.sort(reverse = False)
num = 0
for i in range(0, len(N)): num = num + (N[i] * pow(10, i))
print(-1 if num % 30 != 0 else num)