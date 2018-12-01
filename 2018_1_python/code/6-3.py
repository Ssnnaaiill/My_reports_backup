def read(line):
	if 'skip' in line:
		print('rejected')
		return
	else:
		print(line)
	print('-'*10)

user_input=' '
while(user_input != 'quit'):
	user_input=input()
	read(user_input)