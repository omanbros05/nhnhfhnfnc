using System;
using System.Collections.Generic;
using System.Text;

namespace NBearLite
{
    public sealed class NoRecordUpdatedException : ApplicationException
    {
        public NoRecordUpdatedException(string message) : base(message) { }
    }

    public sealed class NoRecordDeletedException : ApplicationException
    {
        public NoRecordDeletedException(string message) : base(message) { }
    }


}
