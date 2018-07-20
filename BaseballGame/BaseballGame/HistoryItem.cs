using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class HistoryItem
    {
        public Guess Guess;

        public Result Result;

        public string ToText()
        {
            return Guess.ToText() + Result.ToText();
        }
    }
}
