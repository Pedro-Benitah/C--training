using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRegister.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LogRecord))
            {
                throw new ArgumentException("Object not is an Log Record");
            }
            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);
        }




    }
}
