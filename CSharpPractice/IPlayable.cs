/* Interface Implementation Challenge**
Define an interface `IPlayable` with a method `Play()`. Implement this interface in `MusicPlayer` 
and `VideoPlayer` classes with different implementations. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    interface IPlayable
    {
        public void Play();
    }
    class MusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Music player is used to listen songs");
        }
    }
    class VideoPlayer
    {
        public void Play()
        {
            Console.WriteLine("Video player is used to watch videos");
        }
    }
}
