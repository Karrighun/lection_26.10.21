int[] array = {41,22,32,43,120,64,7,8,9,120};

int n = array.Length;;
int find = 120;

int index = 0;

while(index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}