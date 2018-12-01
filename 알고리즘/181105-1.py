N, M, K = map(int, input().split())
if(N + M >= K + 3):
	for i in range(K):
		if(N - M >= M): N = N - 1
		else: M = M - 1
	print(int(M if M <= (N / 2) else N / 2))