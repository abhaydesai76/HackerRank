class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        // Hourglass components are going to be 1,2,3 from 1st row
        // 2nd from 2nd row and 1,2,3 from 3rd row
        
        int sum = 0;
        List<int> result = new List<int>();
        
        for (int i = 0; i < 4; i++) // rows, limit upper limit to 4 to avoid index out of range exception
        {
            List<int> value = arr[i];
            
            for(int j = 0; j < 4; j++) // columns, limit upper limit to 4 to avoid index out of range exception
            {                
                sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] 
                         + arr[i+1][j+1] + arr[i+2][j] 
                         + arr[i+2][j+1] + arr[i+2][j+2];
                         
                Console.WriteLine(string.Format("Value of sum : {0}", sum)); 
                result.Add(sum);
            }            
        }
        
        return result.Max();   
    }

}
