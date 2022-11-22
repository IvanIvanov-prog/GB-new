# Напишите программу которая на вход принимает 5 чисел и находит максимальное из них
num_max = 0
for i in range(5):
    a = int(input('Введите число: '))
    if a > num_max:
        num_max = a
print("max=", num_max)   

