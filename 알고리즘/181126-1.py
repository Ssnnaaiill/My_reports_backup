'''import math
fun, love, pen = list(map(str, input().split('-'))), [], 0
if(len(fun) > 1):
	for i in range(0, len(fun)): love.append(sum(list(map(int, fun[i].split('+')))))
	for i in range(len(love)): pen = pen + love[i] if i == 0 else pen - love[i]
print(pen)'''

a, *b = [sum(map(int, fun.split('+'))) for fun in input().split('-')]
print(a - sum(b))