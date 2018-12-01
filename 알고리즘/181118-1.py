a, b, c, d, e, f, g = map(int, input().split())
intora = []
intora.append(a)
intora.append(b)
intora.append(c)
intora.append(d)
intora.append(e)
intora.append(f)
intora.append(g)
A, B, amax, bmax = [], [], 0, 0
for i in range (0, len(intora)): 
	if(intora[i] % 2 != 0):
		A.append(intora[i])
		if(intora[i] > amax): amax = intora[i]
	else:
		B.append(intora[i])
		if(intora[i] > bmax): bmax = intora[i]
print(amax + bmax)