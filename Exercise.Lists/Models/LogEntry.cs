using System;

namespace Exercise.Lists.Models
{
    public class LogEntry
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public DateTime timeOfEvent { get; set; }
    }
}
