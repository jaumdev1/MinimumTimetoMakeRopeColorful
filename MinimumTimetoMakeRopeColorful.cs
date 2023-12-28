public class Solution {
    public int MinCost(string colors, int[] neededTime) {
      int i = 0;
      int j = 0;
      int total = 0;

      while(i< neededTime.Length && j < neededTime.Length){
          int currT = 0;
          int currMax = 0;
        while(j< neededTime.Length && colors[i] == colors[j]){
            currT += neededTime[j];
            if(neededTime[j] > currMax){
                currMax = neededTime[j];
            }

            j++;
 
        }

        total += currT - currMax;
        i=j;
        }
        return total;
    }
}