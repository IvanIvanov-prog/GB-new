# Напишите программу для проверки ложности утверждения
# (W ⋀ Z) ⋁ ¬Y ⋁ (¬X ≡ ¬W) для всех значений предикат.
# Переменные: W, Z, Y, X. Проверяемых состояний 2: Range(2) (истина=числу, ложь=ноль)

for w in range(2):
    for z in range(2):
        for x in range(2):
            for y in range(2):
                if not ((w and z) or -y or (-x == -w)):
                    print(w, z, x, y)
# 1 запуск без not
#0 0 0 0
#0 0 0 1
#0 0 1 1
#0 1 0 0
#0 1 0 1
#0 1 1 1
#1 0 0 1
#1 0 1 0
#1 0 1 1
#1 1 0 0
#1 1 0 1
#1 1 1 0
#1 1 1 1

#2 Запуск с проверкой отрицания
# 0 0 1 0
# 0 1 1 0
# 1 0 0 0