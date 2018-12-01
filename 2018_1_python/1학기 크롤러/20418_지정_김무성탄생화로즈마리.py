from openpyxl import Workbook
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

wb = Workbook()
sheet = wb.active
driver = webdriver.Chrome('chromedriver')

try:
	driver.get('http://www.11st.co.kr')
	elem = driver.find_element_by_id('AKCKwd')
	elem.clear()
	elem.send_keys('라즈베리파이')
	elem.send_keys(Keys.RETURN)

	hot = driver.find_element_by_class_name('hotClick_wrap')
	hot_list = hot.find_elements_by_tag_name('li')

	for item in hot_list:
		hot_title = item.find_element_by_class_name('info_tit')
		print(hot_title.text)
		sheet.append([hot_title.text])
	wb.save('20418_지정.xlsx')

except Exception as e:
	print(e)

finally:
	driver.close()