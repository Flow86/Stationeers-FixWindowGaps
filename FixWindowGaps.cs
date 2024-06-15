using HarmonyLib;
using StationeersMods.Interface;

using FixWindowGaps.Patches;

namespace FixWindowGaps
{
    class FixWindowGaps : ModBehaviour
    {
        public override void OnLoaded(ContentHandler contentHandler)
        {
            UnityEngine.Debug.Log("FixWindowGaps: Hello!");

            Harmony harmony = new Harmony("FixWindowGapsPatches");
            harmony.PatchAll(typeof(InventoryWindowPatches));

            UnityEngine.Debug.Log("FixWindowGaps: Done!");
        }
    }
}