#str
a=123
print(a*10)
res=str(a)
print(res*10)

#int
a='123'
res=int(a)
print(res*10.0)
#문자로 표현된 숫자를 정수형으로 바꿈
#순수 문자는 정수로 못바꿈
#당연히 계산도 가능함

#ord
a = 'A'
res = ord(a)
print(res)
#문자를 아스키코드(정수)로 바꾼다

#chr
a = 68
res = chr(a//2)
print(res)
#정수에 해당하는 아스키코드 문자를 반환한다.
#n=34, chr(n*2) >> 가능
#68/2는 안됨 > 자료형이 float로 된다
# // 로 하면 나누기도 됨