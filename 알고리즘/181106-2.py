info = input().split('-')
y = 2000 if(int(info[1][0]) - 2 >= 0) else 1900
sex = 'M' if(int(info[1][0]) % 2 == 1) else 'F'
print(str(y + int(info[0][0:2])) + '/' + info[0][2:4] + '/' + info[0][4:6] + ' ' + sex)