using System;

namespace ProjectQuiz
{
    class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool CheckAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En iyi programlama dili hangisidir?",new string[]{"Python","C#","Java","C++"},"C#");
            var q2 = new Question("En populer programlama dili hangisidir?",new string[]{"C#","Python","Java","C++"},"C#");
            var q3 = new Question("En cok kazandiran programlama dili hangisidir?",new string[]{"C#","Java","Python","C++"},"C#");
            
            var questions = new Question[]{q1,q2,q3};

            int index=1;
            foreach (var question in questions)
            {
                Console.WriteLine($"{index}. {question.Text}");
                index++;
                foreach (var choice in question.Choices)
                {
                    Console.WriteLine($"{choice}");
                }
                Console.Write("Cevap: ");
                var cevap = Console.ReadLine();
                Console.WriteLine(question.CheckAnswer(cevap));
                
            }

            Console.WriteLine(q1.CheckAnswer("C#"));
            Console.WriteLine(q2.CheckAnswer("Java"));
            Console.WriteLine(q3.CheckAnswer("C++"));
        }
    }
}
