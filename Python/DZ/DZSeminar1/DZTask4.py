# Напишите программу, которая по заданному номеру четверти, 
# показывает диапазон возможных координат точек в этой четверти (x и y).
# Пример: - 1 -> x > 0, y > 0; - 8 -> нет такой четверти
a = int(input('Введите число соответствующее номеру четверти: '))
if a == 1:
    print('В превой четверти возможен диапазон значений: х>0, y>0')
elif a == 2:
    print('Во второй четверти возможен диапазон значений: х<0, y>0')  
elif a == 3:
    print('В третьей четверти возможен диапазон значений: х<0, y<0')
elif a == 4:
    print('В четвертой четверти возможен диапазон значений: х<0, y>0')
else:
    print('Четверти с введенным значением:{},не существует.'.format(a))
