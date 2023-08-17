using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class QuestionStruct
    {
        public QuestionStruct()
        {
        
        }
       
        public QuestionStruct(string question, string answerOne, string answerTwo, string answerThree, string answerFour, int correctAnswer, int id)
        {
            this.Question = question;
            this.answerOne = answerOne;
            this.answerTwo = answerTwo;
            this.answerThree = answerThree;
            this.answerFour = answerFour; 
            this.correctAnswer = correctAnswer;
            this.Id = id;
        }

        public string Question { get; set; }
        public string answerOne { get; set; }
        public string answerTwo { get; set; }
        public string answerThree { get; set; }
        public string answerFour { get; set; }



       
        public int correctAnswer { get; set; }
        public int Id { get; set; }

    }
}

/*
 
 array = askedQuestions[*Id's of question that have been already asked*] ;

 

func askTheQuestion(*questionID*) {

if askedQuestions.contains(questionID) {
askTheQuestion()
}


}
 
 
 
 
 
 
 
 */