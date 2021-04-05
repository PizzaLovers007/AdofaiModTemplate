using HarmonyLib;

// TODO: Rename this namespace to your mod's name.
namespace MyAdofaiMod
{
    /// <summary>
    /// Add all of your <see cref="HarmonyPatch"/> classes here. If you find
    /// this file getting too large, you may want to consider separating the
    /// patches into several different classes.
    /// </summary>
    internal static class Patches
    {
        /// <summary>
        /// Example patch that logs anytime the user presses a key.
        /// </summary>
        [HarmonyPatch(typeof(scrController), "CountValidKeysPressed")]
        private static class ExamplePatch
        {
            public static void Postfix(int __result) {
                MainClass.Logger.Log($"User pressed {__result} key(s).");
            }
        }
    }
}
