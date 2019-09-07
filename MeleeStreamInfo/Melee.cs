using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeleeStreamInfo
{
    class Melee
    {
        public static string[] characters = Directory.GetFiles("assests/icons", "*.png").Select(Path.GetFileName).ToArray();
        public static string[] getCharacters()
        {
            for(int i = 0; i < characters.Count(); i++)
            {
                characters[i] = characters[i].Replace(".png","");
            }
            return characters;
        }
        public static string findMatch(string character)
        {

            if (characters.Contains(character))
            {
                return character+ ".png";
            }
            else
            {
                return "Fox.png";
            }
        }
    }
}
