// JotunnModStub
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnModStub.cs
// Project: JotunnModStub

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Entities;
using Jotunn.Configs;
using Jotunn.Managers;
using System.Reflection;
using System;
using Jotunn.Utils;

namespace RuneSwords
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Major)]
    internal class RuneSwords : BaseUnityPlugin
    {
        public const string PluginGUID = "com.zarboz.runicswords";
        public const string PluginName = "RuneSwords";
        public const string PluginVersion = "0.0.1";
        private AssetBundle runeassets;
        private void Awake()
        {
            LoadAssets();
            IceSword();
            FireSword();
            PoisonSword();
            LightningSword();

        }

        private void LoadAssets()
        {
            runeassets = AssetUtils.LoadAssetBundleFromResources("runeswords", typeof(RuneSwords).Assembly);
        }

        private void IceSword()
        {
            var icefab = runeassets.LoadAsset<GameObject>("IceRuneSword");
            var icerune = new CustomItem(icefab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Ice Sword",
                    Enabled = true,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 4,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = 20, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = 50, AmountPerLevel = 25},
                        new RequirementConfig {Item = "FreezeGland", Amount = 25, AmountPerLevel = 10},
                        new RequirementConfig {Item = "DragonTear", Amount = 10, AmountPerLevel = 5}
                    }
                });
            ItemManager.Instance.AddItem(icerune);

        }

        private void FireSword()
        {
            var firefab = runeassets.LoadAsset<GameObject>("FireRuneSword");
            var firerune = new CustomItem(firefab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Fire Sword",
                    Enabled = true,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 4,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Flametal", Amount = 100, AmountPerLevel = 50},
                        new RequirementConfig {Item = "SurtlingCore", Amount = 75, AmountPerLevel = 35},
                        new RequirementConfig {Item = "Iron", Amount = 50, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Obsidian", Amount = 20, AmountPerLevel = 5},
                    }
                });
            ItemManager.Instance.AddItem(firerune);
        }

        private void PoisonSword()
        {
            var poisonfab = runeassets.LoadAsset<GameObject>("PoisonRuneSword");
            var poison = new CustomItem(poisonfab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Poison Sword",
                    Enabled = true,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 4,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = 50, AmountPerLevel = 10},
                        new RequirementConfig {Item = "Ooze", Amount = 50, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Iron", Amount = 50, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Guck", Amount = 25, AmountPerLevel = 10}
                    }
                });
            ItemManager.Instance.AddItem(poison);
        }

        private void LightningSword()
        {
            var lightningfab = runeassets.LoadAsset<GameObject>("LightningRuneSword");
            var llightrune = new CustomItem(lightningfab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Lightning Sword",
                    Enabled = true,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 4,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = 20, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = 50, AmountPerLevel = 25},
                        new RequirementConfig {Item = "TrophyEikthyr", Amount = 5, AmountPerLevel = 1},
                        new RequirementConfig {Item = "HardAntler", Amount = 25, AmountPerLevel = 10}
                    }
                });
            ItemManager.Instance.AddItem(llightrune);
        }
    }
}