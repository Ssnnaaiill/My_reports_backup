# -*- coding:utf-8 -*-
#automailing

from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart
import smtplib

SMTP_SERVER = 'smtp.gmail.com'
SMTP_PORT = 465

class Email():


SMTP_USER = 'newdk3025@gmail.com'
SMTP_PASSWORD = 'Ekfrlalfzn'

def send_mail(self, name, addr):
	msg = MIMEMultipart()

 	# 메일 전송을 위한 양식 작성 
	msg['From'] = SMTP_USER
	msg['To'] = addr
	msg['Subject'] = 'A mail for' + name

	contents = name + 'Test mail'

	# msg['text'] = contents

	text = MIMEText(_text = contents, _charset = 'utf-8')
	msg.attach(text)

	# SMTP로 접속할 서버 정보를 가진 클래스 변수를 생성한다.
	smtp = smtplib.SMTP_SSL(SMTP_SERVER, SMTP_PORT)
	
	# 계정 정보로 로그인 
	smtp.login(SMTP_USER, SMTP_PASSWORD)

	# 메일 발송
	smtp.sendmail(SMTP_USER, addr, msg.as_string())

	print("\n 메일이 전송되었습니다 \n")

	smtp.close()