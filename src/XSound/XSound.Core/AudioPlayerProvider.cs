namespace XSound.Core
{
    using System;
    using XSound.Core.Windows;

    public static class AudioPlayerProvider
    {
        public static IAudioPlayer GetAudioPlayer()
        {
            return Environment.OSVersion.Platform switch
            {
                PlatformID.Win32NT => new WindowsAudioPlayer(),
                _                  => throw new NotSupportedException()
            };
        }
    }
}
