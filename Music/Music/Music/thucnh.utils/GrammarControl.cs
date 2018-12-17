using Music.thucnh.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Music.thucnh.utils
{
    class GrammarControl
    {
        public Grammar getSimpleGrammar()
        {
            string[] simpleCommads = { "sasha one", "play song", "next song", "previous song", "volume up", "volume down", "pause", "download it", "mute" };
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Culture = new System.Globalization.CultureInfo("en-US");
            Choices commands = new Choices();
            commands.Add(simpleCommads);
            grammarBuilder.Append(commands);
            Grammar grammar = new Grammar(grammarBuilder);
            return grammar;
        }
        public Grammar searchLyricsGrammar()
        {
            SongDAO dao = new SongDAO();
            List<String> lyricsList = dao.getaAllLyrics();

            string[] lines = { };
            for (int i = 0; i < lyricsList.Count; i++)
            {
                lines = Regex.Split(lyricsList[i], " ");
            }
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Culture = new System.Globalization.CultureInfo("en-US");
            Choices commands = new Choices();
            commands.Add(lines);
            grammarBuilder.Append(commands);
            Grammar grammar = new Grammar(grammarBuilder);
            return grammar;
        }
    }
}
