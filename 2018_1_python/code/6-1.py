#function with no return value
def func(*a):
	print(a*3)

print('start')
func('y','s','w')

#함수는 선언하고 호출하는 위치가 중요하다
#C언어처럼 앞에서 프로토타입을 선언할 수 없을까? -> X