using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using Comfort.Common;
using EFT.InventoryLogic;
using EFT.UI;
using EFT.UI.Screens;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScavsWithArmbands.Patches;

namespace ScavsWithArmbands
{
    [BepInPlugin("ScavsWithArmbands", "ScavsWithArmbands", "1.0.0")]
    [BepInDependency("com.SPT.core", "3.11.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new InventoryControllerPatch().Enable();
        }
    }
}
