using System;
using System.IO;


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                bool firstWord = true;

                while ((line = reader.ReadLine()) != null)
                {
                    
                    line = line.Trim();

                    if (!string.IsNullOrEmpty(line))
                    {
                        
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length > 0)
                        {
                            
                            string lastWord = words[words.Length - 1];

                            
                            if (!firstWord)
                            {
                                result += " ";
                            }

                            result += lastWord;
                            firstWord = false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
