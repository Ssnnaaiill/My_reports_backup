from openpyxl import Workbook

wb = Workbook()
sheet = wb.active

sheet['A1'] = 'Number'
sheet['B1'] = 'Name'
sheet['A2'] = 1
sheet['B2'] = 'AAA'
sheet['A2'] = 2
sheet['B2'] = 'BBB'

#Sheet2.xlsx라는 파일이 있으면 덮어쓰기 됨
#없으면 새로운 엑셀파일 생성
wb.save('Sheet2.xlsx')