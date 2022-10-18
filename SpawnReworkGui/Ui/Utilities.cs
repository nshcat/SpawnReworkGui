using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnReworkGui.Ui
{
    public static class Utilities
    {
        public static string DictToString(Dictionary<string, int> dict)
        {
            var builder = new StringBuilder();
            bool isFirst = true;
            foreach (var kvp in dict)
            {
                if (isFirst)
                    isFirst = false;
                else
                    builder.Append(";");

                builder.Append($"{kvp.Key}:{kvp.Value}");
            }

            return builder.ToString();
        }

        public static Dictionary<string, int> StringToDict(string contents)
        {
            var result = new Dictionary<string, int>();

            var entries = contents.Split(new char[] { ';' });
            foreach (var entry in entries)
            {
                var components = entry.Split(new char[] { ':' });
                if (components.Length != 2)
                    throw new Exception($"Expected <string>:<number> in {entry}");

                int value;
                if (!int.TryParse(components[1], out value))
                    throw new Exception($"Expected <string>:<number> in {entry}");

                result.Add(components[0], value);
            }

            return result;
        }
    }
}
