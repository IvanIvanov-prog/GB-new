#Напишите программу, которая будет преобразовывать десятичное число в двоичное.
#Без использования встроенной функции преобразования, без строк.
#Пример: in 88 out 1011000
s = ""
n = int(input("Введите число для преобразовывания десятичного числа в двоичное:\n"))
while n != 0:
    s = str(n%2) + s
    n //= 2
print(s)
