#_*_ coding:utf-8 _*_
"""age = input("나이를 입력하세요 : ")
if int(age) >= 20:	#괄호 써도되고 안 써도 됨
	print("Party tonight")
else:
	print("Study tonight")
 """


# python의 코드 구분은 들여쓰기로 수행된다.
# 함수, 조건, 반복 구조 등 내포가 필요한 구문은 콜론:으로 구분한다.

age = input("나이를 입력하세요 : ")
print ("party tonight" if int(age) >= 20 else "Study tonight")

# 삼항연산자
# format : 명령문 if 조건 else 거짓일때의 명령문