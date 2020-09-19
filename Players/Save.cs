using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    class Save
    {
        public static void SaveToFile(string file, Player[] players)
        {
            using (StreamWriter stream = new StreamWriter(file))
            {
                foreach (var pl in players)
                {
                    stream.WriteLine(pl.ToFileFormat());
                }
                    
                stream.Close();
            }
        }

        public static Player[] GetFromFile(string file)
        {
            Player[] players = null;
            if (File.Exists(file))
            {
                var sPlayers = File.ReadAllLines(file);
                var n = sPlayers.Length;
                if (n > 0)
                {
                    players = new Player[n];
                    for (int i = 0; i < n; i++)
                        players[i] = Player.CreateFromString(sPlayers[i]);
                    return players;
                }

            }
            return players;
        }

    }
}
