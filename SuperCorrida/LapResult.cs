using System;
namespace SuperCorrida
{
    public class LapResult
    {
        public DateTime FinishTime { get; set; }
        public int PilotId { get; set; }
        public string PilotName { get; set; }
        public int LapNumber { get; set; }
        public TimeSpan LapDuration { get; set; }
        public decimal AverageSpeed { get; set; }
    }
}
