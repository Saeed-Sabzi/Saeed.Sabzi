using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WordsRepository
    {
        string[] easyWords = {"water", "apple", "mobile", "canada", "iran","banana",
            "laptop","london","tehran","ship","car","tree" };

        string[] hardWords = {"subway", "funny", "luxury", "matrix", "wizard","bottle",
            "corner","hidden","health","branch","angel", "mouse" };

        public string EasyWords()
        {
            Random random = new Random();
            int rndNum = random.Next(0, easyWords.Length);
            string word = easyWords[rndNum];
            return word;
        }
        public string HardWords()
        {
            Random random = new Random();
            int rndNum = random.Next(0, hardWords.Length);
            string word = hardWords[rndNum];
            return word;
        }
    }
}
