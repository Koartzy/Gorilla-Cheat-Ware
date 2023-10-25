using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Configuration;
using BepInEx;
using UnityEngine;
using Photon;
using PlayFab;
using Mono;
using MonoMod;
using Photon.Pun;
using HarmonyLib;
using System.ComponentModel;
using System.Reflection;

namespace GorillaCheatWare
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [Description("GorillaCheatWare")]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "org.GorillaCheatWare.GorillaCheatWare.GorillaCheatWare";
        private const string modName = "GorillaCheatWare";
        public const string modVersion = "0.0.0.01";

        public void Awake()
        {
            var harmony = new Harmony(modGUID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
        // UnlockComp Cheat (Maybe Working)
        private static void UnlockComp()
        {
            if (Input.LeftTrigger)
            {
                foreach (UnlockCompButton unlockCompButton in UnityEngine.GameObject.FindObjectsOfType<UnlockCompButton>())
                {
                    unlockCompButton.ButtonActivation();
                }
            }
        }
    }
}
