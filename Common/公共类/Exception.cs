using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class CustomException : Exception
    {
        public CustomException(string message)
            : base(message)
        {

        }
    }


    public class NoExistsException : Exception
    {
        public NoExistsException(string message)
            : base(message)
        {

        }
    }

    public class PrimaryKeyDuplicateException : Exception
    {
        public PrimaryKeyDuplicateException(string message)
            : base(message)
        {

        }
    }
}
