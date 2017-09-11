using System;
using System.Collections.Generic;
using System.Linq;


class Solution {
    public int solution(int[] A) {
        int result = 1;
        
        Dictionary<int, int> dict = new Dictionary<int,int>();
        
        for(int i = 0; i<A.Length; i++){
        
            if(dict.ContainsKey(A[i])){        
                if(dict[A[i]] == 1){
                    dict[A[i]] = 0;
                }else if (dict[A[i]] == 0){
                    dict[A[i]] = 1;   
                }
            }else{         
            dict.Add(A[i], 1);             
            }         
        }
        
        try{
         
         int test = dict.First(r=>r.Value == 1).Key;
          result = test;
        
        }catch(Exception ex){
         Console.WriteLine(ex.Message);   
        }
        
        return result;
    }
}