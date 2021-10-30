using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionBank.Design.Model
{
	public enum Format { Text, PNG,JPG, MP3}

    public enum QueryType { ID, TAG1  }
    public class QuestionItem
    {
        string ObjectID { get; set; }

        Element Question { get; set; } 
        List<Element> Answers { get; set; }
        Element CorrectAnswer { get; set; }
       
        bool IsDraft { get; set; }
        string DraftBy { get; set; }
        DateTime? DraftOn { get; set; }
        bool IsValidated { get; set; }
        string? ValidatedBy { get; set; }
        DateTime? ValidatedOn { get; set; }
        bool IsPublic { get; set; }
        string MadePublicBy { get; set; }
        DateTime? MadePublicOn { get; set; }
        int? NumberofTimesAnswrd { get; set; }
        int? NumberofTimesAnswrdCorrectly { get; set; }
    }

    public class Element
    {
        string ObjectID { get; set; }
        byte[] Content { get; set; }      
        Format Format { get; set; } 
    }


    public class QuestionItemQuery
    {
        QueryType Type { get; set; }
        string Value  { get; set; }

    }


}

