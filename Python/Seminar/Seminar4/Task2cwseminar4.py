from random import choices
def create_list(number_1):
    list = choices(range(number_1*2), k = number_1)
    return list
second_list = create_list(int(input()))
print(second_list)

def collector (second_list):
    therd_list = []
    for i in range(len(second_list)):
        value = second_list[i]
        sublist_list = [value]
        for k in range(i + 1, len(second_list)):
            if second_list [k] > value:
                value = second_list [k]
                sublist_list.append (value)
        if len (sublist_list) > 1:
            therd_list.append (sublist_list)
    return therd_list 
print(collector(second_list))






