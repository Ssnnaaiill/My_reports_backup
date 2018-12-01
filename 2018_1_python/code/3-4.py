# join
a = '_m-_-m_'
res = a.join('ABC')
print(res)

# join 함수가 메소드로 지정된 변수의 문자를 find함수의 인자(문자) 사이에 삽입한다.
# 숫자 안됨, 굳이 하고 싶다면 따옴표 쓰기.
# 한 줄씩 띄우게 하고 싶을땐?
# -> \n, \t와 같은 escape 문자 넣기.

ab = [1,'asdf',123, 'ssfa']
print(ab[2:4])

print(str(ab)[1:1]) #대괄호 없애기