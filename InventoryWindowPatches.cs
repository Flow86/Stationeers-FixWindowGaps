using Assets.Scripts.UI;
using HarmonyLib;

namespace FixWindowGaps.Patches
{
    internal class InventoryWindowPatches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(InventoryWindow))]
        [HarmonyPatch(nameof(InventoryWindow.SetVisible))]
        public static void SetVisible_Prefix(InventoryWindow __instance, bool isVisble)
        {
            // This fixes the phantom window issue. The layout will render all items that are active.
            // If we mark this game object as inactive, it will no longer be rendered in the layout.
            // This results in no gaps between open windows.
            __instance.RectTransform.gameObject.SetActive(isVisble);
        }
    }
}