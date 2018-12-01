import re
p = re.compile("[a-c]{1}[0-9]{2}[A-Z]{1}")
result = p.findall(open("./code2.txt", "r").read())
for i in range(0, len(result)): print(result[i][3], end = "")