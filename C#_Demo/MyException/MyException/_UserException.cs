using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    class _UserException : Exception
    {
        public string ex_message = string.Empty;
        public _UserException(): base()
        {
        }
        public _UserException(string message)
            : base(message)
        {
            this.ex_message = "用户自定义异常：" + message;
        }

        public _UserException(string message,Exception ex):base(message,ex)
        {

        }
    }
}
