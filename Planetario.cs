using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pianeti
{
    internal class Planetario
    {
        public List<Pianeta> Pianeti { get; set; }

        public void StampaPlanetario(Graphics a)
        {
            for (int i = 0; i < Pianeti.Count; i++)
            {
                a.FillEllipse(new SolidBrush(Pianeti[i].Colore), new Rectangle((int)Pianeti[i].Posizione.X, (int)Pianeti[i].Posizione.Y, 10, 10));
            }
        }
    }
}
