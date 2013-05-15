using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    public partial class EnquireQuestionItem
    {
        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            int count = Convert.ToInt32(DB.Select(DataBases.Question, DataBases.Question.ID.Count()).Where(DataBases.Question.QuestionInfo == Question).SetTransaction(trans).ToScalar());
            if (count == 0)
            {
                Question question = new Question { QuestionInfo = Question, SystemService = this.SystemService, SQLtransaction = this.SQLtransaction };
                question.Update();
            }
        }
    }
}
