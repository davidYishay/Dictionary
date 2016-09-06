using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentence_translate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int amount;
            Console.WriteLine("please enter amount word of dictionary");
            input = Console.ReadLine();

            amount = int.Parse(input);

            string[] wordHeberuw;
            wordHeberuw = new string[amount];

            string[] wordTranslate;
            wordTranslate = new string[amount];

            int circle = 0;

            do
            {
                Console.WriteLine("write hebrew word ,or enough to stop");
                wordHeberuw[circle] = Console.ReadLine();

                if(wordHeberuw[circle]!="enough")
                {
                    Console.WriteLine("write translete to word");
                    wordTranslate[circle] = Console.ReadLine();
                    circle++;
                }
               
            } while (wordHeberuw[circle - 1] != "enough" && amount > circle);


            //////////////
            string text;
            do
            {

                Console.WriteLine("please enter sentence in hebrew");
                text = Console.ReadLine();


                for(int q = 0;q<text.Length && text!="enough" ; )
                {
                    string word = "";

                    while(q<text.Length && text[q]!=' ' )
                    {
                        word += text[q];
                        q++;
                    }


                    bool exist = false;
                    for (int i = 0; i < circle && exist == false; i++)
                    {
                        if (word == wordHeberuw[i])
                        {
                            Console.Write(wordTranslate[i]+" ");
                            exist = true;
                        }

                    }

                    if (exist == false )
                        Console.Write(word+"* ");//  המילה המקורית+* במקרה שאין תרגום  
                    q++;
                }
                
            } while (text != "enough");


        }
    }
}
