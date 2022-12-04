#  Задайте список, состоящий из произвольных чисел, количество задаёт пользователь.
#  Напишите программу, которая определит, присутствует ли в заданном списке число,
#  полученное от пользователя.
#from random import sample
#def zet(a, b):
#    c = sample (range(1, a*2), k=a)
#    print(c)
 #   if b in c:
 #       return 'Yes'
 #   return 'No'
#print(zet(int(input()), int(input())))
#from random import sample
#def zet(a, b):
   # c = sample (range(1, a*2), k=a)
    #print(c)
    #return b in c
#print(zet(int(input()), int(input())))
from random import sample
def zet(a, b):
    c = sample (range(1, a*2), k=a)
    print(c)
    return  'Yes' if b in c else 'No'
print(zet(int(input()), int(input())))
