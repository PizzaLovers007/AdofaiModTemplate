using UnityModManagerNet;

// TODO: Rename this namespace to your mod's name.
namespace MyAdofaiMod
{
    /// <summary>
    /// Entry class for the mod.
    /// </summary>
    internal static class Startup
    {
        /// <summary>
        /// Entry point for the mod. This will be called by UnityModManager when
        /// the game is opened.
        /// </summary>
        /// <param name="modEntry">UMM's mod entry for the mod.</param>
        internal static void Load(UnityModManager.ModEntry modEntry) {
            MainClass.Setup(modEntry);
        }
    }
}
