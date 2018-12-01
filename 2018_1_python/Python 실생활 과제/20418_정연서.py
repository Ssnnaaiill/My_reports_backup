print("********** Distance of the Star **********\n")
vm = float(input("Input Visual Magnitude\t\t: "))		# 별의 겉보기 등급 입력
am = float(input("Input Absolute Magnitude\t: "))		# 별의 절대 등급 입력
if(vm + am < 1 or vm + am > 12): print("Magnitudes should have values between 1 and 6 inclusive.")	# 별의 밝기 등급은 1~6 사이여야 함
else:
	if(vm < am):	# 겉보기 등급 < 절대 등급 : 10pc보다 가까운 별
		par = -1
		while(par < 0):
			par = float(input("Input Stellar Parallax\t\t: "))	# 연주시차 입력
			if(par < 0): print("You can't divide to 0.\n")	# 0으로 나눌 수 없음
			elif((1.0 / par) >= 10): print("Cannot Calculate. No possible results found.")	# 10pc보다 결과값이 커지지 않도록 한다
			else: print("\nDistance\t\t\t: ", 1.0 / par, "pc\n")	# 별의 거리 = 1.0 / 연주시차 (pc)
	elif(vm == am): print("\nDistance\t\t\t: 10pc\n")	# 겉보기 등급 = 절대 등급 : 10pc 거리에 있는 별
	else: print("\nDistance\t\t\t: further than 10pc.\n")	# 겉보기 등급 > 절대 등급 : 10pc보다 먼 별