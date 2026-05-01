public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary <int, int>();

        foreach(int num in nums){

            if(freq.ContainsKey(num)){
              freq[num] += 1;
               continue;
            }

            else{
              freq[num] = 1;
            }

        }


     int[] TopK = (from i in freq 
                        orderby i.Value descending 
                        select i.Key).Take(k).ToArray();


     return TopK;

        
        
    }

}