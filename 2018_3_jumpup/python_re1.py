import re
p = re.compile("[a-z]{1}[A-Z]{3}[a-z]{1}[A-Z]{3}[a-z]{1}")
result = p.findall(open("./code1.txt", "r").read())
for i in range(0, len(result)): print(result[i][4], end = "")