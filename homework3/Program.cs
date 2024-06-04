int [] arr = {1,2,5,0,10,34};
void RecursForArray(int [] array1, int i = 0)
{
    if (i == array1.Length) return;
    {
       
        RecursForArray(array1,i + 1);
        Console.Write($"{array1[i]} ");
        
    }
    

}

RecursForArray(arr, 0);