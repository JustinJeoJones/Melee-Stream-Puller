using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeleeStreamInfo
{
    class Match
    {
        public string player1 { get; set; }
        public string player2 { get; set; }
        public bool complete { get; set; }
        public string round { get; set; }

        public override string ToString() {
            return player1 + " vs " + player2 +" || " + round;
        }
    }
}
