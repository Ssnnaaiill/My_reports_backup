from selenium import webdriver
from selenium.webdriver.common.keys import Keys

driver = webdriver.Chrome('chromedriver')

try:
	driver.get('http://www.naver.com')
	print(driver.title)
	elem = driver.find_element_by_id('query')
	elem.clear()
	#clear()를 해주는 이유는 간혹 포털마다 검색어가 이미 입력되어 있는 경우가 있기 때문
	elem.send_keys('대덕소프트웨어마이스터고등학교')
	elem.send_keys(Keys.RETURN)

	blogs = driver.find_element_by_class_name('_blogBase')
	blogs_list = blogs.find_elements_by_tag_name('li')
	#blogs_list의 자료형은 list가 된다.

	news = driver.find_element_by_class_name('news')
	news_list = news.find_elements_by_xpath('./ul/li')

	print("\n" + "======블로그 검색 결과======" + "\n")
	for post in blogs_list:
		#print(post.text)
		#print('-'*20)

		post_title = post.find_element_by_class_name('sh_blog_title')
		#print(post_title.text)
		print(post_title.get_attribute('title'))
		print(post_title.get_attribute('href') + "\n")

	print("\n" + "======뉴스 검색 결과======" + "\n")
	for page in news_list:
		news_title = page.find_element_by_class_name('_sp_each_title')
		print(news_title.text)
		print(news_title.get_attribute('href') + "\n")

except Exception as e:
	print(e)

finally:
	driver.close()