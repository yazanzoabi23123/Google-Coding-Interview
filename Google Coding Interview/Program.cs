using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Coding_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "3662277";
            string[] words = { "foo", "bar", "baz", "foobar", "emo", "cap", "car", "cat" };
            string[] A = { "a", "b", "c" };
            string[] D = { "d", "e", "f" };
            string[] G = { "g", "h", "i" };
            string[] J = { "j", "k", "l" };
            string[] M = { "m", "n", "o" };
            string[] P = { "p", "q", "r", "s" };
            string[] T = { "t", "u", "v" };
            string[] W = { "w", "x", "y", "z" };
            string newWords = string.Empty;
            string[] s = new string[8];
            string str2 = string.Empty;
            string digit2;
            int cuont = 0;
            int starntindex =0;
            int cuont2 = 0;
            int k = 0;
           

            for (int j1 = 0; j1 < words.Length; j1++)
            {

                for (int i = 0; i < phoneNumber.Length; i++)
                {
                    if ((i-1) + words[j1].Length > phoneNumber.Length)
                    {
                        i = 0;
                    }

                    if (Char.IsDigit(phoneNumber[i]))
                    {
                        str2 = null;
                        str2 += phoneNumber[i];
                        int digit = Convert.ToInt32(str2);
                        
                        
                            if (words[j1].Length == cuont2)
                            {
                                j1++;
                                cuont2 = 0;
                                for (int ss = 0; ss < s.Length; ss++)
                                {
                                    ss = k;
                                    s[ss] += newWords;
                                    ss = s.Length;
                                    
                                }
                                k++;
                                newWords = null;

                            }
                        

                        cuont = 0;
                        digit2 = null;
                        starntindex = 0;
                        if (digit == 2)
                         {

                            for (int y2 = 0; y2 < words[j1].Length; y2++)
                            {
                                if (cuont2 > 0)
                                {
                                    digit2 = words[j1].Substring(cuont2, 1);
                                }
                                else
                                {
                                    digit2 = words[j1].Substring(starntindex, 1);
                                }

                                for (int j = 0; j < A.Length; j++)
                                {
                                    
                                    if (A[j] == digit2)
                                    {
                                        newWords += A[j];
                                        j = A.Length;
                                        y2 = words.Length;
                                        cuont2++;
                                    }
                                    
                                }
                                starntindex++;
                                digit2 = null;




                            }
                         }
                           cuont =0;
                           digit2 = null;
                           starntindex = 0;
                          if(digit == 3)
                          {
                            for (int y = 0; y < words[j1].Length; y++)
                            {

                                if (cuont2 > 0)
                                {
                                    digit2 = words[j1].Substring(cuont2, 1);
                                }
                                else
                                {
                                    digit2 = words[j1].Substring(starntindex, 1);
                                }

                                for (int i2 = 0; i2 < D.Length; i2++)
                                {


                                    if (D[i2] == digit2)
                                    {
                                        newWords += D[i2];
                                        cuont2++;
                                        y = words[j1].Length;
                                        i2 = D.Length;
                                         
                                    }
                                    
                                }
                                starntindex++;
                                digit2 = null;
                                
                            }

                          }
                          cuont = 0;
                          digit2 = null;
                          starntindex = 0;
                        if (digit == 6)
                        {
                            for (int y3 = 0; y3 < words[j1].Length; y3++)
                            {
                                if (cuont2 > 0)
                                {
                                    digit2 = words[j1].Substring(cuont2, 1);
                                }
                                else
                                {
                                    digit2 = words[j1].Substring(starntindex, 1);
                                }

                                for (int i3 = 0; i3 < M.Length; i3++)
                                {
                                

                                    if (M[i3] == digit2)
                                    {
                                        newWords += M[i3];
                                        i3 = M.Length;
                                        y3 = words.Length;
                                        cuont2++;
                                    }
                                   
                                }
                                starntindex++;
                                
                                digit2 = null;

                            }
                        }


                        cuont = 0;
                        digit2 = null;
                        starntindex = 0;
                        if (digit == 7)
                        {
                            for (int y4 = 0; y4 < words[j1].Length; y4++)
                            {

                                if (cuont2 > 0)
                                {
                                    digit2 = words[j1].Substring(cuont2, 1);
                                }
                                else
                                {
                                    digit2 = words[j1].Substring(starntindex, 1);
                                }

                                for (int i4 = 0; i4 < P.Length; i4++)
                              {
                                

                                    if (P[i4] == digit2)
                                    {
                                        newWords += P[i4];
                                        i4 = M.Length;
                                        y4 = words.Length;
                                        cuont2++;
                                    }
                                    
                              }
                                starntindex++;
                                digit2 = null;
                            }
                        }

                        











                    }
                    
                }
                
                
            }
        }



   }
}


