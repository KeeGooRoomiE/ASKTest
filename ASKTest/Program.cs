using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace TestLib
{
    public class TestProj
    {
        public enum ErrType
        {
            Error = 0,
            System = 1,
            DataProcess = 2,
            Session = 3
        }
        

        public static List<LogModel> ExportMockLogList()
        {
            List<LogModel> mockLogs = new List<LogModel>();
            {
                mockLogs.Add(new LogModel() { Time = DateTime.UtcNow, AppType = "Service", Type = ErrType.Error, Count = "3" });

                return mockLogs;
            }
        }

    }

    //MODELS
    public class LogModel
    {
        public DateTime Time { get; set; }
        public string AppType { get; set; }
        public TestProj.ErrType Type { get; set; }
        public string? Count { get; set; }
    }
}