using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Answers
{
    class AnswerGenerator
    {
        private static String[] answers = new String[]
        {
            "Ask any one.",
            "Dont want to say.",
            "No doubt.",
            "Really.",
            "Attention and ask again.",
            "Yes.",
            "Yes, Really.",
            "I dont think so.",
            "It is.",
            "Better not say.",
            "Really bad answer.",
            "Possible.",
            "Doubtfull.",
            "How i see,yes.",
            "My answer,no.",
            "100%.",
            "Maybe.",
            "Be reality.",
            "Good point.",
            "Low match."
        };

        // Метод случайной генерации ответа
        public static String GetRandomAnswer()
        {
            return answers[new Random().Next(answers.Length)];
        }
    }
}
