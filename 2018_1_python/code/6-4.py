def send_main(from_mail,to_mail,subject,contents):
	print("from : \t" + from_mail)
	print("to : \t" + to_mail)
	print("Subject : " + subject)
	print("-"*20)
	print(contents)
	print("-"*20)

my_email="newdk3025@gmail.com"

users=[]
users.append({'name':'kinew','email':'newdk3025@gmail.com'})
users.append({'name':'someone','email':'hmm.com'})

contents='''
A young man stands in his bedroom.
It just so happens that today, the 13th of April, 2009, is this young man's birthday.
Though it was thirteen years ago he was given life, it is only today he will be given a name! 

What will the name of this young man be?
'''

for user in users:
	title='HOMESTUCK_'+user['name']
	send_main(my_email,user['email'],title,contents)