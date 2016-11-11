using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeDemo
{
    /// <summary>
    /// Exception event args.
    /// </summary>
    public class ExceptionEventArgs: EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionEventArgs"/> class.
        /// </summary>
        /// <param name="ex">The exception.</param>
        public ExceptionEventArgs(Exception ex)
        {
            _exception = ex;
        }


        Exception _exception;
        /// <summary>
        /// Gets the exception.
        /// </summary>
        public Exception Exception
        {
            get
            {
                return _exception;
            }
        }
    }

}
