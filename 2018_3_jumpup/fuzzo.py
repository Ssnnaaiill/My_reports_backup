from selenium import webdriver
from threading import Thread
from datetime import datetime
import signal, sys, time, base64, urllib3
import tornado.ioloop, tornado.web, tornado.options

SERVER_PORT=3030
BASE_URL='http://yeali.me/index.php?mode='
PAYLOADS='payload.dat'
DALAY=3

def LOG(data):
	with open('logs.txt','a') as f:
		f.write(data + "\n")

LOG("Fuzzer Started at : " + str(datetime.now()))

fp = webdriver.FirefoxProfile()
fp.update_preferences()
DRIVER=webdriver.Firefox(firefox_profile=fp)