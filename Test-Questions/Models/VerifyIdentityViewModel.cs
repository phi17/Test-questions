using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_Questions.Models
{
    [Serializable]
    public class VerifyIdentityViewModel
    {

        public VerifyIdentityViewModel()
        {
            this.Questions = new List<VerifyIdentityQuestionModel>();
        }

        public string TransactionKey { get; set; }
        public string InteractiveQueryId { get; set; }
        public List<VerifyIdentityQuestionModel> Questions { get; set; }
    }

    [Serializable]
    public class VerifyIdentityQuestionModel
    {

        public VerifyIdentityQuestionModel()
        {
            this.Answers = new List<VerifyIdentityAnswerModel>();
        }

        public string QuestionId { get; set; }
        public string Question { get; set; }
        [Required(ErrorMessage = "Please choose an answer.")]
        public string AnswerId { get; set; }
        public List<VerifyIdentityAnswerModel> Answers { get; set; }
    }

    [Serializable]
    public class VerifyIdentityAnswerModel
    {
        public string AnswerId { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }
    }
}