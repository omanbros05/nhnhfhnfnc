using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class Question
    {
        public override string SearchColumn()
        {
            return QuestionInfo;
        }

        /// <summary>
        /// 更新问题记录
        /// </summary>
        /// <param name="lawyer">问题对象</param>
        internal void UpdateQuestion(Question question)
        {
            if (question.QuestionInfo == "")
                return;

            Question databaseQuestion = null;
            using (IDataReader reader = DB.Select(DataBases.Question).Where(DataBases.Question.QuestionInfo == question.QuestionInfo).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseQuestion = ReadRow(reader);
                }
            }

            if (databaseQuestion != null)
            {
                if (databaseQuestion.QuestionInfo != "")
                    databaseQuestion.QuestionInfo = question.QuestionInfo;

                databaseQuestion.SystemService = this.SystemService;
                databaseQuestion.SQLtransaction = this.SQLtransaction;
                databaseQuestion.Update();
            }
            else
            {
                databaseQuestion.SystemService = this.SystemService;
                databaseQuestion.SQLtransaction = this.SQLtransaction;
                databaseQuestion.Update();
            }
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<Question>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}
