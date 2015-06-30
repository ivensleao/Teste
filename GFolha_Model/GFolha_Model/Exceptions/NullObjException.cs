using System;
using System.Runtime.Serialization;

namespace GFolha_Model.Exceptions
{
    class NullObjException : Exception
    {
        public NullObjException()
            : base()
        {   
        }

        public NullObjException(string message)
            : base(message)
        {
        }

        public NullObjException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        public NullObjException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public NullObjException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

        protected NullObjException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
