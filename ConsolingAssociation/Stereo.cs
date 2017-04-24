using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolingAssociation
{
    public class Stereo
    {
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                else if (value < 0)
                {
                    value = 0;
                }
                _volume = value;
            }
        }

        public Stereo Copy()
        {
            return (Stereo) MemberwiseClone();
        }

        public string TurnOn(bool on) => on ? "Jamming..." : "Quiet time...";
    }
}
