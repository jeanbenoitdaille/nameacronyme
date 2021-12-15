    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public Tuple<char,char> GetInitial(string name)
            {
                string[] n = name.Split(' ');
                return new Tuple<char, char>(n[0][0], n[1][0]);
            }
        }
    }