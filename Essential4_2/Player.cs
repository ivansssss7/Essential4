using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4_2
{
    class Player:IPlayable,IRecodable
    {
        // IPlayable методи
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pausing playback...");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stopping playback.");
        }

        // IRecodable методи
        public void Record()
        {
            Console.WriteLine("Recording...");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pausing recording...");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stopping recording.");
        }
    }
}
