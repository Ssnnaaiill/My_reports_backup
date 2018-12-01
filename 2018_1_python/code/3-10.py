#append
a = [1,2,3]
a.append(4)
print(a)
#append의 인자를 문자열 뒤에 추가한다.

#sort
res1=['e','a','h']
res2=[1,6,2]
res1.sort()
res2.sort(reverse = True)	# reverse = True : 내림차순 정렬
res3 = sorted(res1, reverse = True)
res4 = sorted(res1)			# 외부정렬
print(res1)
print(res2)
print(res3)
print(res4)
#sorted는 딕셔너리 정렬이 가능.
a={'2':'B','1':'A','3':'U'}
a1=sorted(a)
print(a1)


#insert
res=[100,123,523]
res.insert(1,2)
print(res)
#특정 인덱스의 값이 되도록 요소를 추가한다.

#remove
res=[10,20,30,40,10]
res.remove(10)
print(res)
#함수의 인자값을 찾아서 삭제한다.
#값이 여러개면 가장 첫번째 요소를 삭제한다.

#top
res = [10,20,30,40]
res.pop()					# 반환값이 있는 함수이다
print(res)
#마지막 요소를 삭제하는 함수
#반환값이 있으므로 변수에 pop한 값을 저장할 수 있음

#count
a = [10,10,101,102,10,'ab']
res = a.count(10)
print(res)
#함수의 인자값을 찾아서 개수를 센다.
#내부의 계산값을 넣어도 될까? res=a.count(5+5) ==> 가능

#==========================================================================================================================

#딕셔너리 함수

#keys
a = {'a':123,'b':456}
res = a.keys()
print(res)
#dictionary의 key들을 반환한다.

#values
res = a.values()
print(res)

res = a.items()
print(res)

#diction... 어쩌구 말을 없애려면 list활용

#get
a = {'q':123,'w':456}
res=a.get('q')
print(a['q'])
print(res)
# 둘의 차이는? 키가 없는 값을 반환한다면?
# get함수를 쓸때 키가 없는 값을 찾으면 none
# 그냥 딕셔너리에서 키 값으로 찾았을 때 없으면 오류
# get 함수는 키값이 있다면 그 vlaue를 반환하도
# 없다면 기본값을 저장하여 반환할 수 있다.

#in
a = {'q':123,'w':456}
print('q' in a)
# 키 값이 있는지 검사.
# 있으면 True, 없으면 False
# 이 결과를 가지고 if(~~ == True) << 와 같이 응용할 수 있음