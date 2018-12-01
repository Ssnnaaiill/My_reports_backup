a, b = map(int, input().split()); cnt = 0
for i in range(a, b + 1): cnt = cnt + 1 if((i ** 0.5).is_integer() == False) else cnt + 0
print(cnt)