#lstrip, rstrip
a='     programming'
b='programming   '
c='   programming    '
res=a.lstrip()
print(res, 1)	# 왼쪽 공백만 제거되었는지 확인
res=b.rstrip()
print(res, 1)	# 오른쪽 공백만 제거되었는지 확인
res=c.strip()
print(1, res, 1)

a='programming'
res=type(a)
print(res)
#res에 type함수의 반환값을 넣을 수 있을까?