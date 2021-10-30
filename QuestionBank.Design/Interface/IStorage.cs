using QuestionBank.Design.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionBank.Design.Interface
{
    interface IStorage
    {
                
        
        //Question 
        bool add(QuestionItem doc);
        bool update(QuestionItem doc);
        bool remove(String docId);
       
        QuestionItem get(String questionId);        
        //


    }
}
