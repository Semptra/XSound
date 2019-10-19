namespace XSound.Core.Windows.Enums
{
    using System;

    [Flags]
    internal enum SoundMode : uint
    {
        /// <summary>
        /// play synchronously
        /// </summary>
        SYNC = 0x0000,
        /// <summary>
        /// play asynchronously
        /// </summary>
        ASYNC = 0x0001,
        /// <summary>
        /// silence if sound not found
        /// </summary>
        NODEFAULT = 0x0002,
        /// <summary>
        /// pszSound points to a memory file
        /// </summary>
        MEMORY = 0x0004,
        /// <summary>
        /// loop the sound until next sndPlaySound
        /// </summary>
        LOOP = 0x0008,
        /// <summary>
        /// don't stop any currently playing sound
        /// </summary>
        NOSTOP = 0x0010,
        /// <summary>
        /// Stop Playing Wave
        /// </summary>
        PURGE = 0x40,
        /// <summary>
        /// The pszSound parameter is an application-specific alias in the registry.
        /// You can combine this flag with the ALIAS or ALIAS_ID flag to specify an application-defined sound alias.
        /// </summary>
        APPLICATION = 0x80,
        /// <summary>
        /// don't wait if the driver is busy
        /// </summary>
        NOWAIT = 0x00002000,
        /// <summary>
        /// name is a registry alias
        /// </summary>
        ALIAS = 0x00010000,
        /// <summary>
        /// alias is a predefined id
        /// </summary>
        ALIAS_ID = 0x00110000,
        /// <summary>
        /// name is file name
        /// </summary>
        FILENAME = 0x00020000,
        /// <summary>
        /// name is resource name or atom
        /// </summary>
        RESOURCE = 0x00040004
    }
}
