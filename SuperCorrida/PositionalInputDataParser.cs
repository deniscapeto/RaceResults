using System;
using System.Collections.Generic;
using System.IO;

namespace SuperCorrida
{
    public static class PositionalInputDataParser
    {

        /// <summary>
        /// Extract from file based on positions
        /// </summary>
        /// <returns>The .</returns>
        /// <param name="positions"> List of the positions in file that represents each field. For example: [0,5],[6,9] would result in a list of rows and each row has a list of values that represents the columns</param>
        public static List<List<string>> ParseFile(string filePath, List<(int begin,int end)> positions, bool fileHasHeader = false)
        {
            List<List<string>> result = new List<List<string>>();

            var lines = new List<string>(File.ReadAllLines(filePath));

            if (fileHasHeader)
                lines.RemoveAt(0);
            
            foreach (var line in lines)
            {
                var lineArray = new List<string>();
                foreach (var item in positions)
                {
                    string value = line.Substring(item.Item1, item.Item2 - item.Item1);
                    lineArray.Add(value);
                }
                result.Add(lineArray);
            }

            return result;
        }
    }
}
