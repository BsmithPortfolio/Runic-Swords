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
        public const string PluginVersion = "0.0.5";
        private AssetBundle runeassets;
        private void Awake()
        {
            LoadAssets();
            IceSword();
            FireSword();
            PoisonSword();
            LightningSword();
            piece_exentension();
            piece_exentension1();
            piece_exentension2();
            piece_exentension3();
            piece_exentension4();
            piece_exentension5();
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
                    MinStationLevel = 2,
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
                    MinStationLevel = 2,
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
                    MinStationLevel = 2,
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
                    MinStationLevel = 2,
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
         
        private void piece_exentension()
        {
            var extension1 = runeassets.LoadAsset<GameObject>("piece_artisanice");
            var ext1 = new CustomPiece(extension1,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext1);
        }
        private void piece_exentension1()
        {
            var extension2 = runeassets.LoadAsset<GameObject>("piece_artisanpurp");
            var ext2 = new CustomPiece(extension2,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext2);
        }
        private void piece_exentension2()
        {
            var extension3 = runeassets.LoadAsset<GameObject>("piece_artisanpoison");
            var ext3 = new CustomPiece(extension3,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext3);
        }

        private void piece_exentension3()
        {
            var extension4 = runeassets.LoadAsset<GameObject>("piece_artisanlight");
            var ext4 = new CustomPiece(extension4,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext4);
        }
        private void piece_exentension4()
        {
            var extension5 = runeassets.LoadAsset<GameObject>("piece_artisanround1");
            var ext5 = new CustomPiece(extension5,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext5);
        } 
        private void piece_exentension5()
        {
            var extension6 = runeassets.LoadAsset<GameObject>("piece_artisanround2");
            var ext6 = new CustomPiece(extension6,
                new PieceConfig
                {
                    CraftingStation = "piece_artisanstation",
                    Description = "An Extension for the Artisan table",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "piece_artisanstation",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Obsidian", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext6);
        }
    }
}