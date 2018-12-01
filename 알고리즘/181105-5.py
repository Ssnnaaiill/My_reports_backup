N, S = map(int, input().split())
cowsize = [int(input()) for i in range(N)]
cnt = 0
for i in range(0, N - 1):
	for j in range(i + 1, N):
		cnt = (cnt + 1 if cowsize[i] + cowsize[j] <= S else cnt + 0)
print(cnt)