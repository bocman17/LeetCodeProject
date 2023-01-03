using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _010_RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            bool[][] sp = new bool[s.Length + 1][];
            for (int i = 0; i < s.Length + 1; i++)
            {
                sp[i] = new bool[p.Length + 1];
            }
            sp[0][0] = true;

            for (int i = 1; i < sp[0].Length; i++)
            {
                if (p[i - 1] == '*')
                {
                    sp[0][i] = sp[0][i - 2];
                }
            }

            for (int i = 1; i < sp.Length; i++)
            {
                for (int j = 1; j < sp[0].Length; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        sp[i][j] = sp[i - 1][j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        sp[i][j] = sp[i][j - 2];

                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        {
                            sp[i][j] = sp[i][j] || sp[i - 1][j];
                        }
                    }
                    else
                    {
                        sp[i][j] = false;
                    }
                }
            }

            return sp[s.Length][p.Length];
        }
    }
}
