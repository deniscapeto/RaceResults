using System;
namespace SuperCorrida
{
    public class RaceResult
    {
        public int FinishPosition { get; set; }
        public int PilotId { get; set; }
        public string PilotName { get; set; }
        public int CompletedLaps { get; set; }
        public TimeSpan TotalRaceTime { get; set; }

    }
}
