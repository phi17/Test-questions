using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Questions.Controllers
{
    public class QAController : Controller
    {
        // GET: QA
        [HttpGet]
        public ActionResult Index()
        {
            Models.VerifyIdentityViewModel model = new Models.VerifyIdentityViewModel();
            model.TransactionKey = "0001";
            model.InteractiveQueryId = "1234567890";


            Models.VerifyIdentityQuestionModel qa0 = new Models.VerifyIdentityQuestionModel();
            qa0.Question = "What your YoB?";
            qa0.QuestionId = "1";
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    qa0.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 1985), CorrectAnswer = true });
                }
                else
                {
                    qa0.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 1985), CorrectAnswer = false });
                }
            }
            model.Questions.Add(qa0);

            Models.VerifyIdentityQuestionModel qa1 = new Models.VerifyIdentityQuestionModel();
            qa1.Question = "What your MoB?";
            qa1.QuestionId = "2";

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    qa1.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 8), CorrectAnswer = true });
                }
                else
                {
                    qa1.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 8), CorrectAnswer = false });
                }
            }
            model.Questions.Add(qa1);

            Models.VerifyIdentityQuestionModel qa2 = new Models.VerifyIdentityQuestionModel();
            qa2.Question = "What your DoB?";
            qa2.QuestionId = "3";
            for (int i = 0; i < 5; i++)
            {
                if (i == 1)
                {
                    qa2.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 1), CorrectAnswer = true });
                }
                else
                {
                    qa2.Answers.Add(new Models.VerifyIdentityAnswerModel() { AnswerId = Convert.ToString(i + 1), Answer = Convert.ToString(i + 1), CorrectAnswer = false });
                }
            }
            model.Questions.Add(qa2);



            ViewBag.DevelopmentMode = "on";

            return View(model);
        }

        // Post: QA
        [HttpPost]
        public ActionResult Index(int a)
        {
            return View();
        }
    }
}