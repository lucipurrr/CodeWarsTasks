public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int arr_size = arr.Length;
    int sum = 0;
    int leftsum = 0;
    for (int i =0; i < arr_size; i++) {
      sum += arr[i]; // sum of the whole array
    }
    
    for (int i = 0; i < arr_size; i++){
      sum -= arr[i];
      
      if (leftsum == sum)
        return i;
      leftsum += arr[i];
    }
    return -1;
  }
}
