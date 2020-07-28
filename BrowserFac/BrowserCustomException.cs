﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProgram.BrowserFac
{
   public class BrowserCustomException : Exception
    {
        public String message;
        public ExceptionType type;
        public enum ExceptionType
        {
           NULL_EXCEPTION, EMPTY_EXCEPTION
        }

        public BrowserCustomException(String message, ExceptionType type) : base(message)
        {
            this.message = message;
            this.type = type;
        }
    }
}

