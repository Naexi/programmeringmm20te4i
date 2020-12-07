using System;
using System.Collections.Generic;

namespace fragelista
{
    class Program
    {
        static List<QuestionCard> fragekort = new List<QuestionCard>();
        static void Main(string[] args)
        {
            string svar = "ok";
            List<string> testquestion = new List<string>();
            List<string> testanswer = new List<string>();
            testquestion.Add("sveriges huvud stad");
            testanswer.Add("stockholm");
            testquestion.Add("hundar hatar vadå?");
            testanswer.Add("katter");
            testquestion.Add("när(månad) är julafton?");
            testanswer.Add("december");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(testquestion[i]);
                svar = Console.ReadLine();
                if(testanswer[i].Equals(svar))
                {
                    Console.WriteLine("rätt");
                }
                if(!testanswer[i].Equals(svar))
                {
                    Console.WriteLine("fel");
                }
            }
            
            Addquestions();
            
             foreach (QuestionCard card in fragekort)
             {
                 Console.WriteLine(card.Getquestion());
                 svar = Console.ReadLine();
                 if (card.IsCorrect(svar))
                 {
                     Console.WriteLine("rätt");
                 }
                 if (!card.IsCorrect(svar))
                 {
                     Console.WriteLine("fel");
                 }
             }
             

        }
        static void Addquestions()
        {
            
            QuestionCard card;
             card = new QuestionCard("vad", "vad"); // skapar ett objekt av klassen
             
             fragekort.Add(card);
             card = new QuestionCard("a","a"); // skapar ett objekt av klassen
             
             fragekort.Add(card);
             card = new QuestionCard("b","b"); // skapar ett objekt av klassen
             fragekort.Add(card);
        }
    }
    class QuestionCard
    {
     private String question;
     private String answer;
     public QuestionCard(string q, string ans)
      {
          question = q;
          answer = ans;
      }

     public string Getquestion()
     {
         return question;
     }
     public bool IsCorrect(string guess)
      {
          return answer == guess;
      }
    }
}
