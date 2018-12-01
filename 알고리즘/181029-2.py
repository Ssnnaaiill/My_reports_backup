n = int(input())
Sum = 0
a = [] #양수리스트
b = [] #음수리스트
for i in range(0,n):
	tmp = int(input())
	if(tmp > 0): a.append(tmp)
	else: b.append(tmp)

a.sort(reverse=True)
if(len(a) % 2 == 0):
	for i in range(0,len(a),2):
		if(a[i] * a[i+1] > 1): Sum = a[i] * a[i+1] + Sum
		else: Sum = a[i] + a[i+1] + Sum
else:
	for i in range(0,len(a)-1,2):
		if(a[i] * a[i+1] >= 1): Sum = a[i] * a[i+1] + Sum
		else: Sum = a[i] + a[i+1] + Sum
	Sum = a[-1] + Sum

b.sort(reverse=False)
if(len(b) % 2 == 0):
	for i in range(0,len(b),2):
		Sum = b[i] * b[i+1] + Sum
else:
	for i in range(0,len(b)-1,2):
		if(b[i] * b[i+1] >= 0): Sum = b[i] * b[i+1] + Sum
		else: Sum = b[i] + b[i+1] + Sum
if(len(b) % 2 == 1):
	Sum = Sum + b[-1]
print(int(Sum))