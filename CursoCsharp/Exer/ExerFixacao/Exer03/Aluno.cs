﻿namespace Exer03
{
    public class Aluno
    {
        public string Name;
        public double Grade1, Grade2, Grade3;
        
        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }
        
        public bool Approved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public double MissingPoints()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGrade();
            }
        }
    }
}