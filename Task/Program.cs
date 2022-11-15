// See https://aka.ms/new-console-template for more information


 string[] CreateNewArrayByRule (string[] array) 
{
  // string[]  res_arr = new string [array.Length];
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    
      if (array[i].Length <= 3) Console.Write($"{array[i]} ");        
    }
    Console.Write("]");
      return array;
 }


void PrintArray (string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");  
  }
  Console.Write("]");
}


string[] input_arr = {"grad", "wasya", "tr=", "sez3"};
PrintArray(input_arr);
Console.WriteLine();
string[] out_res = CreateNewArrayByRule(input_arr);
