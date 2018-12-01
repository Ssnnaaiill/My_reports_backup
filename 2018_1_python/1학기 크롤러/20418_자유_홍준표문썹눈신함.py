'''
20418 정연서

크롤링하고자 하는 요소 : 네이버 웹툰 베스트도전 <오늘의 베스트> 항목의 작품 제목과 작가명
목적 : 정식 웹툰 이외에도 감상할 만한 베스트도전 작품을 추천받기 위한 목적

동작 과정 : 
	1. 크롬 브라우저 실행
	2. 네이버 웹툰 베스트도전 페이지 접속
	3. '오늘의 베스트' 영역에 있는 작품들의 제목과 작가명 크롤링
	4. 작품명, 작가명을 CMD창에 출력
	5. 제목과 작가명을 엑셀 파일에 삽입한 파일을 만들어 저장

기대 효과 : 웹툰 페이지 이용자에게 인기 있는 베스트도전 웹툰을 추천하여 아마추어 웹툰 시장을 더욱 활성화
'''

from openpyxl import Workbook
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

wb = Workbook()
sheet = wb.active
sheet.append(['웹툰 제목', '작가'])
	
driver = webdriver.Chrome('chromedriver')

try:
	driver.get('http://comic.naver.com/genre/bestChallenge.nhn')	# 네이버웹툰 베스트도전 페이지 접속

	comic = driver.find_element_by_class_name('mainTodayList')
	comic_list = comic.find_elements_by_xpath('./li')

	for item in comic_list:
		best_title = item.find_element_by_class_name('mainTodaySubtlt')
		best_author = item.find_element_by_class_name('person')

		print('제목 : ' + best_title.text)
		print('작가 : ' + best_author.text + '\n')

		sheet.append([best_title.text, best_author.text])
	wb.save('20418_자유.xlsx')

except Exception as e:
	print(e)

finally:
	driver.close()