// Massiv
// Тип данных[] Имя = {знач1, знач2, .....}
// int[] array = {9,34,45,67,23,1123}
// int[] array = {0,0,0,0,0}
//  int[] array = new int[5];
//  int[] array = new int[]{0,0,0,0,0};
//  int[] array = new int[5]{1,0,3,0,2};
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} //           0  1   2  3  4  5  6  7  8
int[] array = {11,21,34,41,55,66,71,84,96}; 
// array [0] = 12;
// Console.WriteLine(array[4]);
int result = Max(
    Max(array[0],array[1], array[2]),
    Max(array[3],array[4], array[5]),
    Max(array[6],array[7], array[8])
);
Console.WriteLine(result);