from selenium import webdriver
from threading import Thread
from datetime import datetime
import signal, sys, time, base64, urllib3
import tornado.ioloop, tornado.web, tornado.options

SERVER_PORT=3030
BASE_URL='http://localhost:9999/?a='
PAYLOADS='payload.dat'
DALAY=3

def LOG(data):
	with open('logs.txt','a') as f:
		f.write(data + "\n")

LOG("Fuzzer Started at : " + str(datetime.now()))

fp = webdriver.FirefoxProfile()
fp.update_preferences()
DRIVER=webdriver.Firefox(firefox_profile=fp)

is_closing = False
def signal_handler(signum, frame):
	global is_closing
	print("Exiting...!")
	is_closing = True

def try_exit():
	global is_closing
	if is_closing:
		try: DRIVER.quit()
		except: pass
	tornado.ioloop.IOLoop.instance().stop()

def Ping(NO, PAYLOAD, BASE_URL):
	try:
		urllib.request.urlopen(BASE_URL)
	except urllib.HTTPError, e:
		print(e)
		pass
	except urllib.URLError, e:
		DAT = "\n\n[ERROR] Server is not Reachable, Last tried [PAYLOAD]: " + str(NO) + ", " + PAYLOAD + " [URL]:" + BASE_URL + " Error: " + str(e.args)

	print(DAT)
	LOG(DAT)
	sys.exit(0)

def DriverThread(DRIVER, BASE_URL, PAYLOADS, DELAY):
	with open(PAYLOADS, 'r') as f:
		payload_collection = f.readlines()
	print("Started fuzzing\nPress Ctrl + c to Quit")
	count = 0
	for payload in payload_collection:
		count += 1
		DAT = "No: " + str(count) + " Data: " + str(payload)
		LOG(DAT)
		try:
			DRIVER.get(BASE_URL + payload)
			Ping(count.payload, BASE_URL)
			time.sleep(DELAY)
		except Exception as e:
			pass
	print("Fuzzing Completed")
	Driver.quit()
	sys.exit(0)

thread = Thread(target = DriverThread, args = [DRIVER, BASE_URL, PAYLOADS, DELAY])
thread.setDeamon(True)
thread.start()