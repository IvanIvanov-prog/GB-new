# Напишиите программу котрая принимает на вход два числа и проверяет является ли одно число квадратом другого
a = int(input('Введите число 1: '))
b = int(input('Введите число 2: '))
if a**2 == b or b**2 == a:
    print(True)
else:
    print(False) 