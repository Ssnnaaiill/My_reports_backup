def quick_sort(ARRAY): return ARRAY if(len(ARRAY) <= 1) else quick_sort([element for element in ARRAY[1:] if element <= ARRAY[0]]) + [ARRAY[0]] + quick_sort([element for element in ARRAY[1:] if element > ARRAY[0]])
nowtime, ans, S = 0, 0, []
for i in range(int(input())): start, end = map(int, input().split()); S.append([start, end])
for i in range(len(S), 0):
	for j in range(n - 1, 1):
		if(S[j][1] != S[j][1]): break
	if(S[j][0] < S[j - 1][0]): S[j - 1], S[i] = S[i], S[j - 1]
for i in range(len(S)):
	if(S[i][0] >= nowtime): nowtime, ans = S[i][1], ans + 1
print(ans)