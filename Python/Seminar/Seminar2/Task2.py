# Создайте список длины N значения формируются по формуле 3k+1
# где к принимает значения от 1 до N включительно
list_1 = []
l_num = int(input())
for k in range (1, l_num + 1):
    list_1.append(3 * k + 1)
    print(list_1)
