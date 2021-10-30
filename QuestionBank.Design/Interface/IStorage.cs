using QuestionBank.Design.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionBank.Design.Interface
{
    interface IStorage
    {
                
        
        //Question 
        bool add(Question doc);
        bool update(Question doc);
        bool remove(String docId);
        bool commit();
        Question get(String questionId);        
        //


    }
}
