using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pondus
{
    class Funzioni
    {
        public static List<string> PrendiTuttiIPercorsiDeiFileDaCartella(string cartellaPrimaria)
        {
            if (!Directory.Exists(cartellaPrimaria)) { return null; }
            var percorsi = new List<string>() { cartellaPrimaria };
            var files = new List<string>();

            while (percorsi.Count > 0)
            {
                files.AddRange(Directory.GetFiles(percorsi[0]));
                percorsi.AddRange(Directory.GetDirectories(percorsi[0]));
                percorsi.RemoveAt(0);
            }

            return files;
        }
    }
}
