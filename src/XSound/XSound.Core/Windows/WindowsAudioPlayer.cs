namespace XSound.Core.Windows
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using XSound.Core.Windows.Enums;

    public class WindowsAudioPlayer : IAudioPlayer
    {
        public void Play(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Input file not found", fileName);
            }

            PlaySound(fileName, IntPtr.Zero, SoundMode.SYNC | SoundMode.FILENAME);
        }

        [DllImport("Winmm.dll")]
        private static extern bool PlaySound(string fileName, IntPtr module, SoundMode mode);
    }
}
