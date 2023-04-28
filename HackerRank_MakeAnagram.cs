class Result
{

    /*
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

    public static int makeAnagram(string a, string b)
    {
        int numOperations = 0;
        int runningCount = 0;
        char[] alphabets = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    
        Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        Dictionary<char, int> charCount2 = new Dictionary<char, int>();
        
        foreach (char c in a)
        {
            if (charCount1.ContainsKey(c) == true)
            {
                charCount1.TryGetValue(c, out int existingValue);
                charCount1.Remove(c);                
                charCount1.Add(c, existingValue + 1);                
            }
            else
            {
                charCount1.Add(c, 1);
            }
        }
        
        foreach (char c in b)
        {
            if (charCount2.ContainsKey(c) == true)
            {
                charCount2.TryGetValue(c, out int existingValue);
                charCount2.Remove(c);                
                charCount2.Add(c, existingValue + 1);                
            }
            else
            {
                charCount2.Add(c, 1);
            }
        }
        
        foreach(KeyValuePair<char, int> charCount in charCount1)
        {            
            Console.WriteLine($"charCount1 : {charCount.Key}: {charCount.Value}");
        }
        
        foreach(KeyValuePair<char, int> charCount in charCount2)
        {            
            Console.WriteLine($"charCount2 : {charCount.Key}: {charCount.Value}");
        }
        
        foreach(var value in alphabets)
        {
            if (charCount1.ContainsKey(value) && charCount2.ContainsKey(value))
            {
                Console.WriteLine(string.Format("{0} present in both", value));
                runningCount = runningCount + Math.Abs(charCount1[value] - charCount2[value]);
            }
            else if (charCount1.ContainsKey(value))
            {
                runningCount = runningCount + charCount1[value];
            }   
            else  if (charCount2.ContainsKey(value))
            {
                runningCount = runningCount + charCount2[value];
            }
        }
        
        return runningCount;
    }

}
