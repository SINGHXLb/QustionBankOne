using QuestionBank.Design.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionBank.Design.Interface
{
    interface ICRUDService
    {
         
        bool update(QuestionItem questionItem );
        bool remove(String questionItemID);

        QuestionItem get(String questionId);

        List<QuestionItem> GetQuestionItems(QuestionItemQuery query ); 
    }


    interface IQuestionItemService
    {
          
        List<QuestionItem> GetQuestionItems(QuestionItemQuery query); 
    }

}
