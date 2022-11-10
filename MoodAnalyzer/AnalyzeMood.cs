using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)
        {
            this.message = message;
        }

        public string Mood()
        {
            message=message.ToLower();
            if (message.Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    }
}
