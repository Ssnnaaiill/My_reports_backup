'''cnt = 0
def hanoi(num, A, B, C):
	if num == 1:
		print(A, '->', C)
		cnt += 1
	else:
		hanoi(num - 1, A, C, B)
		hanoi(1, A, B, C)
		hanoi(num - 1, B, A, C)

num = int(input())
hanoi(num, 'A', 'B', 'C', cnt)'''

'''def hanoi(n):
	if(n == 1): return 1
	else: return hanoi(n - 1) + 1 + hanoi(n - 1)'''

print(2**int(input("input hanoi column's number : "))-1)