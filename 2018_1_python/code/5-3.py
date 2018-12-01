'''
#1

a = str(input())
b = str(input())
i = 0
while(i < len(b)):
	if b[i] != " ":
		print(a.find(b[i]), end="")
	else:
		print(b[i], end="")
	i = i + 1
'''

'''
#2

a = str(input())
b = str(input())
i = 0
while(i < b[i]):
	print(a.find(b[i]) if b[i] != " " else b[i], end="")
	i = i + 1
'''

a = str(input())
b = str(input())
i = 0
for i in b:
	print(a.find(i) if i != " " else i, end="")