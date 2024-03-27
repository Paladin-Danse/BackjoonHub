using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++)
        {
            if(!dict.ContainsKey(players[i])) dict.Add(players[i], i);
        }
        
        foreach(string calling in callings)
        {
            int rank = dict[calling];
            string afterPlayer = players[rank - 1];
            
            players[rank - 1] = calling;
            players[rank] = afterPlayer;
            
            dict[calling] = rank - 1;
            dict[afterPlayer] = rank;
        }
        
        /*
        for(int i = 0; i < callings.Length; i++)
        {
            int idx = Array.IndexOf(players, callings[i]);
            if(idx > -1)
            {
                string temp = players[idx - 1];
                players[idx - 1] = players[idx];
                players[idx] = temp;
            }
        }
        */
        return players;
    }
}