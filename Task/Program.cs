int lght = ReadInt("Enter the lenght of your array:\t");
string[] userArray = new string[lght];
string[] resultArray = new string[lght];
int searchStringLenght = 3;

for(int i=0; i<userArray.Length; i++)
{
    userArray[i] = ReadString($"Enter the {i+1}th element of the array:\t");
} 

for (int i=0,j=0; i<userArray.Length; i++)
{
    if (userArray[i].Length <= searchStringLenght)
    {
        resultArray[j] = userArray[i];
        j++;
    }
}

Console.Write($"[ '{string.Join("' '",userArray)}'] -> ");
WriteWithoutEmptyString(resultArray);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadString(string msg)
{
    Console.Write(msg);
    return Convert.ToString(Console.ReadLine())??String.Empty;
}

void WriteWithoutEmptyString(string[] array)
{
    Console.Write("[ ");
    for(int k=0; k<array.Length; k++)
    {
        if (string.IsNullOrEmpty(array[k]))
            continue;
        else
            Console.Write($"'{array[k]}' ");
    }
    Console.Write("]");
}