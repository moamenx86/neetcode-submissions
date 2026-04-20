class Solution {
public:
    bool isAnagram(string s, string t) {
        map<char,int> map_s;
        map<char,int> map_t;
        for(int i =0; i<s.size(); i++)
        {
            map_s[s[i]] += 1;
        }
        for(int i =0; i<t.size(); i++)
        {
            map_t[t[i]] += 1;
        }
        if(map_s.size()!= map_t.size())
        return false;
        else
        for(int i =0; i<map_s.size(); i++)
        {
            if(map_t[t[i]]!=map_s[t[i]])
            return false;

        }

        return true;

    }
};
