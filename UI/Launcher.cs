using System;

namespace Maleos
{
    public class ApprovalCases : Interface.IApprovalCases
    {
        public void Insert(DevExpress.XtraRichEdit.API.Native.Document document, Model.ApprovalCasesInfo approvalCases) {
            document.BeginUpdate();
            //document.InsertText(document.Bookmarks["IF_TIME"].Range.Start, approvalCases.ApprovalTime);
            // ...
            
            document.EndUpdate();
        }
    }
}
