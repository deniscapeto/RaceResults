using System;
using System.Collections.Generic;
using System.Globalization;

namespace SuperCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            var positions = new List<(int begin, int end)>
            {
                (0, 12),  //HORA
                (18, 21), //CODIGO PILOTO
                (24, 54), //NOME PILOTO
                (58, 64), //NUMERO VOLTA
                (67, 75), //TEMPO VOLTA
                (99, 105) //VELOCIDADE MEDIA
            };

            var inputData = PositionalInputDataParser.ParseFile(@"data/inputData.txt",positions, true);

            List<LapResult> lapsResult = new List<LapResult>();
            foreach(var line in inputData)
            {
                LapResult lap = new LapResult();

                lap.FinishTime = DateTime.Parse(line[0]);
                lap.PilotId = int.Parse(line[1]);
                lap.PilotName = line[2];
                lap.LapNumber = int.Parse(line[3]);
                var date = DateTime.ParseExact(line[4],"m:ss.fff", CultureInfo.InvariantCulture);
                lap.LapDuration = TimeSpan.FromTicks(date.Ticks);
                lap.AverageSpeed = decimal.Parse(line[5], NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("pt-BR"));
                lapsResult.Add(lap);
            }

        }
    }
}
