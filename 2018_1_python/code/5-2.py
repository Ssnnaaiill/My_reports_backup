#n개의 계단을 오를 때 한 번에 1계단 또는 2계단으로 오를 수 있는 방법의 수 구하기
def fib(n):
	if n == 1: return 1
	elif n == 2: return 2
	else: return fib(n - 1) + fib(n - 2)

print(fib(int(input("input the number of stairs : "))))