using System;
using System.IO;

namespace sensitive_word_finder
{
    class find
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择输入字符串或读取文件内容,输入string或file");
            Findandreplace finder = new Findandreplace("Hello world", "Hello Carl");
            string a=Console.ReadLine();
            if(a=="string")
            {
                String input = Console.ReadLine();
                String output = finder.Stringtype(input);
                Console.WriteLine(output);
            }
            if(a=="file")
            {
                string str = File.ReadAllText(@"test.txt");
                
                String output = finder.Stringtype(str);
                File.WriteAllText(@"test.txt",output);
                Console.WriteLine(output);
            }
    

        }

        class Findandreplace
        {
            String original,substitude;
            public Findandreplace(String ori, String sub)
            {
                substitude = sub;
                original = ori;
            }
            public String Stringtype(String input)
            {
                if (input.Contains(original))
                {
                    return input.Replace(original, substitude);
                }
                else
                    return input;
            }
          
        }

    }
}
