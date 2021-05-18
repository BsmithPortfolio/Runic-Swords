// JotunnModStub
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnModStub.cs
// Project: JotunnModStub

using BepInEx;
using UnityEngine;
using Jotunn.Entities;
using Jotunn.Configs;
using Jotunn.Managers;
using Jotunn.Utils;
using BepInEx.Configuration;

namespace RuneSwords
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Major)]
    internal class RuneSwords : BaseUnityPlugin
    {
        public const string PluginGUID = "com.zarboz.runicswords";
        public const string PluginName = "RuneSwords";
        public const string PluginVersion = "0.0.6";
        private AssetBundle runeassets;

        public ConfigEntry<bool> LightEnable;
        public ConfigEntry<bool> FireEnable;
        public ConfigEntry<bool> FrostEnable;
        public ConfigEntry<bool> PoisonEnable;

        public ConfigEntry<int> ObsidianFrost;
        public ConfigEntry<int> ObsidianFire;
        public ConfigEntry<int> ObsidianLight;
        public ConfigEntry<int> ObsidianPoison;

        public ConfigEntry<int> IronFrost;
        public ConfigEntry<int> IronFire;
        public ConfigEntry<int> IronLight;
        public ConfigEntry<int> IronPoison;

        public ConfigEntry<int> IceFreezeGland;
        public ConfigEntry<int> DragonTear;

        public ConfigEntry<int> FireFlametal;
        public ConfigEntry<int> FireSurtling;

        public ConfigEntry<int> PoisonOoze;
        public ConfigEntry<int> PoisonGuck;

        public ConfigEntry<int> Trophy;
        public ConfigEntry<int> Antler;
        private ConfigEntry<int> damagefrost;
        private ConfigEntry<int> bluntfrost;
        private ConfigEntry<int> slashvalfrost;
        private ConfigEntry<int> piercefrost;
        private ConfigEntry<int> chopfrost;
        private ConfigEntry<int> pickaxefrost;
        private ConfigEntry<int> firefrost;
        private ConfigEntry<int> frostfrost;
        private ConfigEntry<int> lightningfrost;
        private ConfigEntry<int> poisonfrost;
        private ConfigEntry<int> spiritfrost;
        private ConfigEntry<int> damageperfrost;
        private ConfigEntry<int> bluntperfrost;
        private ConfigEntry<int> slashperfrost;
        private ConfigEntry<int> pierceperfrost;
        private ConfigEntry<int> chopperfrost;
        private ConfigEntry<int> pickaxeperfrost;
        private ConfigEntry<int> fireperfrost;
        private ConfigEntry<int> frostperfrost;
        private ConfigEntry<int> lightningperfrost;
        private ConfigEntry<int> poisonperfrost;
        private ConfigEntry<int> spiritperfrost;
        private ConfigEntry<int> tierfrost;
        private ConfigEntry<int> attackforcefrost;
        private ConfigEntry<int> damagefire;
        private ConfigEntry<int> bluntfire;
        private ConfigEntry<int> slashvalfire;
        private ConfigEntry<int> piercefire;
        private ConfigEntry<int> chopfire;
        private ConfigEntry<int> pickaxefire;
        private ConfigEntry<int> firefire;
        private ConfigEntry<int> frostfire;
        private ConfigEntry<int> lightningfire;
        private ConfigEntry<int> poisonfire;
        private ConfigEntry<int> spiritfire;
        private ConfigEntry<int> damageperfire;
        private ConfigEntry<int> bluntperfire;
        private ConfigEntry<int> slashperfire;
        private ConfigEntry<int> pierceperfire;
        private ConfigEntry<int> chopperfire;
        private ConfigEntry<int> pickaxeperfire;
        private ConfigEntry<int> fireperfire;
        private ConfigEntry<int> frostperfire;
        private ConfigEntry<int> lightningperfire;
        private ConfigEntry<int> poisonperfire;
        private ConfigEntry<int> spiritperfire;
        private ConfigEntry<int> tierfire;
        private ConfigEntry<int> attackforcefire;
        private ConfigEntry<int> damagelight;
        private ConfigEntry<int> bluntlight;
        private ConfigEntry<int> slashvallight;
        private ConfigEntry<int> piercelight;
        private ConfigEntry<int> slashvalposion;
        private ConfigEntry<int> pierceposion;
        private ConfigEntry<int> chopposion;
        private ConfigEntry<int> pickaxeposion;
        private ConfigEntry<int> fireposion;
        private ConfigEntry<int> frostposion;
        private ConfigEntry<int> lightningposion;
        private ConfigEntry<int> poisonposion;
        private ConfigEntry<int> spiritposion;
        private ConfigEntry<int> damageperposion;
        private ConfigEntry<int> bluntperposion;
        private ConfigEntry<int> slashperposion;
        private ConfigEntry<int> pierceperposion;
        private ConfigEntry<int> chopperposion;
        private ConfigEntry<int> pickaxeperposion;
        private ConfigEntry<int> fireperposion;
        private ConfigEntry<int> frostperposion;
        private ConfigEntry<int> lightningperposion;
        private ConfigEntry<int> poisonperposion;
        private ConfigEntry<int> spiritperposion;
        private ConfigEntry<int> tierposion;
        private ConfigEntry<int> attackforceposion;
        private ConfigEntry<int> slashperlight;
        private ConfigEntry<int> pierceperlight;
        private ConfigEntry<int> chopperlight;
        private ConfigEntry<int> pickaxeperlight;
        private ConfigEntry<int> fireperlight;
        private ConfigEntry<int> frostperlight;
        private ConfigEntry<int> lightningperlight;
        private ConfigEntry<int> poisonperlight;
        private ConfigEntry<int> spiritperlight;
        private ConfigEntry<int> tierlight;
        private ConfigEntry<int> attackforcelight;
        private ConfigEntry<int> damageposion;
        private ConfigEntry<int> bluntposion;
        private ConfigEntry<int> poisonlight;
        private ConfigEntry<int> spiritlight;
        private ConfigEntry<int> damageperlight;
        private ConfigEntry<int> bluntperlight;
        private ConfigEntry<int> choplight;
        private ConfigEntry<int> pickaxelight;
        private ConfigEntry<int> firelight;
        private ConfigEntry<int> frostlight;
        private ConfigEntry<int> lightninglight;

        private void Awake()
        {
            ConfigDeploy();
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

        public void LoadAssets()
        {
            runeassets = AssetUtils.LoadAssetBundleFromResources("runeswords", typeof(RuneSwords).Assembly);
        }

        public void IceSword()
        {
            var icefab = runeassets.LoadAsset<GameObject>("IceRuneSword");
            var icerune = new CustomItem(icefab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Ice Sword",
                    Enabled = FrostEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = ObsidianFrost.Value, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = IronFrost.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "FreezeGland", Amount = IceFreezeGland.Value, AmountPerLevel = 10},
                        new RequirementConfig {Item = "DragonTear", Amount = DragonTear.Value, AmountPerLevel = 5}
                    }
                });
            var itemDrop = icerune.ItemDrop;
            itemDrop.m_itemData.m_shared.m_damages.m_damage = damagefrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntfrost.Value;
            itemDrop.m_itemData.m_shared.m_toolTier = tierfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_pierce = piercefrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_chop = chopfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxefrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_fire = firefrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_frost = frostfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_poison = poisonfrost.Value;
            itemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperfrost.Value;
            itemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperfrost.Value;
            itemDrop.m_itemData.m_shared.m_attackForce = attackforcefrost.Value;
            ItemManager.Instance.AddItem(icerune);

        }

        public void FireSword()
        {
            var firefab = runeassets.LoadAsset<GameObject>("FireRuneSword");
            var firerune = new CustomItem(firefab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Fire Sword",
                    Enabled = FireEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Flametal", Amount = FireFlametal.Value, AmountPerLevel = 50},
                        new RequirementConfig {Item = "SurtlingCore", Amount = FireSurtling.Value, AmountPerLevel = 35},
                        new RequirementConfig {Item = "Iron", Amount = IronFire.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Obsidian", Amount = ObsidianFire.Value, AmountPerLevel = 5},
                    }
                });
            var itemthing = firerune.ItemDrop;
            itemthing.m_itemData.m_shared.m_damages.m_damage = damagefire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_blunt = bluntfire.Value;
            itemthing.m_itemData.m_shared.m_toolTier = tierfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_slash = slashvalfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_pierce = piercefire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_chop = chopfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_pickaxe = pickaxefire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_fire = firefire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_frost = frostfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_lightning = lightningfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_poison = poisonfire.Value;
            itemthing.m_itemData.m_shared.m_damages.m_spirit = spiritfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperfire.Value;
            itemthing.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperfire.Value;
            itemthing.m_itemData.m_shared.m_attackForce = attackforcefire.Value;
            ItemManager.Instance.AddItem(firerune);
        }

        public void PoisonSword()
        {
            var poisonfab = runeassets.LoadAsset<GameObject>("PoisonRuneSword");
            var poison = new CustomItem(poisonfab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Poison Sword",
                    Enabled = PoisonEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = ObsidianPoison.Value, AmountPerLevel = 10},
                        new RequirementConfig {Item = "Ooze", Amount = PoisonOoze.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Iron", Amount = IronPoison.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Guck", Amount = PoisonGuck.Value, AmountPerLevel = 10}
                    } 
                });
            var posiondrop = poison.ItemDrop;
            posiondrop.m_itemData.m_shared.m_damages.m_damage = damageposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_blunt = bluntposion.Value;
            posiondrop.m_itemData.m_shared.m_toolTier = tierposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_slash = slashvalposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_pierce = pierceposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_chop = chopposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxeposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_fire = fireposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_frost = frostposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_lightning = lightningposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_poison = poisonposion.Value;
            posiondrop.m_itemData.m_shared.m_damages.m_spirit = spiritposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperposion.Value;
            posiondrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperposion.Value;
            posiondrop.m_itemData.m_shared.m_attackForce = attackforceposion.Value;
            ItemManager.Instance.AddItem(poison);
        }

        public void LightningSword()
        {
            var lightningfab = runeassets.LoadAsset<GameObject>("LightningRuneSword");
            var llightrune = new CustomItem(lightningfab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Lightning Sword",
                    Enabled = LightEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = ObsidianLight.Value, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = IronLight.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "TrophyEikthyr", Amount = Trophy.Value, AmountPerLevel = 1},
                        new RequirementConfig {Item = "HardAntler", Amount = Antler.Value, AmountPerLevel = 10}
                    }
                });
            var lightningdrop = llightrune.ItemDrop;
            lightningdrop.m_itemData.m_shared.m_damages.m_damage = damagelight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_blunt = bluntlight.Value;
            lightningdrop.m_itemData.m_shared.m_toolTier = tierlight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_slash = slashvallight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_pierce = piercelight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_chop = choplight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxelight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_fire = firelight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_frost = frostlight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_lightning = lightninglight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_poison = poisonlight.Value;
            lightningdrop.m_itemData.m_shared.m_damages.m_spirit = spiritlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperlight.Value;
            lightningdrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperlight.Value;
            lightningdrop.m_itemData.m_shared.m_attackForce = attackforcelight.Value;
            ItemManager.Instance.AddItem(llightrune);
        }
         
        public void piece_exentension()
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
        public void piece_exentension1()
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
        public void piece_exentension2()
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

        private void ConfigDeploy()
        {
            Config.SaveOnConfigSet = true;

            LightEnable = Config.Bind("Lightning Sword", "Enable", true, new ConfigDescription("Lightning Sword Enable", null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            FireEnable = Config.Bind("Fire Sword", "Enable", true, new ConfigDescription("Fire Sword Enable", null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            FrostEnable = Config.Bind("Frost Sword", "Enable", true, new ConfigDescription("Frost Sword Enable", null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            PoisonEnable = Config.Bind("Poison Sword", "Enable", true, new ConfigDescription("Poison Sword Enable", null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            ObsidianFrost = Config.Bind("Frost Sword", "Obsidian Frost", 20, new ConfigDescription("Cost Of Obsidan for Frost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            ObsidianFire = Config.Bind("Fire Sword", "Obsidian Fire", 20, new ConfigDescription("Cost Of Obsidan for Fire", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            ObsidianLight = Config.Bind("Lightning Sword", "Obsidian Lightning", 20, new ConfigDescription("Cost Of Obsidan for Lightning", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            ObsidianPoison = Config.Bind("Poison Sword", "Obsidian Poison", 50, new ConfigDescription("Server side integer", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));

            IronFrost = Config.Bind("Frost Sword", "Iron Frost", 50, new ConfigDescription("Cost Of Iron For Frost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            IronFire = Config.Bind("Fire Sword", "Iron Fire", 50, new ConfigDescription("Cost Of Iron For Fire", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            IronLight = Config.Bind("Lightning Sword", "Iron Lightning", 50, new ConfigDescription("Cost Of Iron For Lightning", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            IronPoison = Config.Bind("Poison Sword", "Iron Poison", 50, new ConfigDescription("Cost Of Iron For Poison", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));

            IceFreezeGland = Config.Bind("Frost Sword", "Ice Glands", 25, new ConfigDescription("FreezeGland Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            DragonTear = Config.Bind("Frost Sword", "Dragon Tears", 10, new ConfigDescription("DragonTear Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));

            FireFlametal = Config.Bind("Fire Sword", "Flametal", 100, new ConfigDescription("Flametal Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            FireSurtling = Config.Bind("Fire Sword", "SurtlingCore", 75, new ConfigDescription("SurtlingCore Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));

            PoisonOoze = Config.Bind("Poison Sword", "Ooze", 50, new ConfigDescription("Ooze Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            PoisonGuck = Config.Bind("Poison Sword", "Guck", 50, new ConfigDescription("Guck Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));

            Trophy = Config.Bind("Lightning Sword", "Trophy", 5, new ConfigDescription("Trophy Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));
            Antler = Config.Bind("Lightning Sword", "Antler", 25, new ConfigDescription("Antler Cost", new AcceptableValueRange<int>(5, 250), new ConfigurationManagerAttributes { IsAdminOnly = true }));




            //Damage Values ice
            
            damagefrost = Config.Bind("Windlass Damage", "Overall Damage", 250, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntfrost = Config.Bind("Windlass Damage", "Blunt Damge", 50, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalfrost = Config.Bind("Windlass Damage", "Slash Damage", 500, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercefrost = Config.Bind("Windlass Damage", "Pierce Damge", 400, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopfrost = Config.Bind("Windlass Damage", "Chop Damage", 950, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxefrost = Config.Bind("Windlass Damage", "PickAxe Damage", 1500, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firefrost = Config.Bind("Windlass Damage", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostfrost = Config.Bind("Windlass Damage", "Frost Damage", 1500, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningfrost = Config.Bind("Windlass Damage", "Lightning Damage", 1500, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonfrost = Config.Bind("Windlass Damage", "Poison Damage", 500, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritfrost = Config.Bind("Windlass Damage", "Spirit Damage", 1500, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperfrost = Config.Bind("Per Level", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperfrost = Config.Bind("Per Level", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperfrost = Config.Bind("Per Level", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperfrost = Config.Bind("Per Level", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperfrost = Config.Bind("Per Level", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperfrost = Config.Bind("Per Level", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperfrost = Config.Bind("Per Level", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperfrost = Config.Bind("Per Level", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperfrost = Config.Bind("Per Level", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperfrost = Config.Bind("Per Level", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperfrost = Config.Bind("Per Level", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierfrost = Config.Bind("Windlass", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcefrost = Config.Bind("Windlass", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //damage values fire
            damagefire = Config.Bind("Windlass Damage", "Overall Damage", 250, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntfire = Config.Bind("Windlass Damage", "Blunt Damge", 50, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalfire = Config.Bind("Windlass Damage", "Slash Damage", 500, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercefire = Config.Bind("Windlass Damage", "Pierce Damge", 400, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopfire = Config.Bind("Windlass Damage", "Chop Damage", 950, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxefire = Config.Bind("Windlass Damage", "PickAxe Damage", 1500, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firefire = Config.Bind("Windlass Damage", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostfire = Config.Bind("Windlass Damage", "Frost Damage", 1500, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningfire = Config.Bind("Windlass Damage", "Lightning Damage", 1500, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonfire = Config.Bind("Windlass Damage", "Poison Damage", 500, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritfire = Config.Bind("Windlass Damage", "Spirit Damage", 1500, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperfire = Config.Bind("Per Level", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperfire = Config.Bind("Per Level", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperfire = Config.Bind("Per Level", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperfire = Config.Bind("Per Level", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperfire = Config.Bind("Per Level", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperfire = Config.Bind("Per Level", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperfire = Config.Bind("Per Level", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperfire = Config.Bind("Per Level", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperfire = Config.Bind("Per Level", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperfire = Config.Bind("Per Level", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperfire = Config.Bind("Per Level", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierfire = Config.Bind("Windlass", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcefire = Config.Bind("Windlass", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //damage values lightning
            damagelight = Config.Bind("Windlass Damage", "Overall Damage", 250, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntlight = Config.Bind("Windlass Damage", "Blunt Damge", 50, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvallight = Config.Bind("Windlass Damage", "Slash Damage", 500, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercelight = Config.Bind("Windlass Damage", "Pierce Damge", 400, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            choplight = Config.Bind("Windlass Damage", "Chop Damage", 950, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxelight = Config.Bind("Windlass Damage", "PickAxe Damage", 1500, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firelight = Config.Bind("Windlass Damage", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostlight = Config.Bind("Windlass Damage", "Frost Damage", 1500, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightninglight = Config.Bind("Windlass Damage", "Lightning Damage", 1500, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonlight = Config.Bind("Windlass Damage", "Poison Damage", 500, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritlight = Config.Bind("Windlass Damage", "Spirit Damage", 1500, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperlight = Config.Bind("Per Level", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperlight = Config.Bind("Per Level", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperlight = Config.Bind("Per Level", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperlight = Config.Bind("Per Level", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperlight = Config.Bind("Per Level", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperlight = Config.Bind("Per Level", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperlight = Config.Bind("Per Level", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperlight = Config.Bind("Per Level", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperlight = Config.Bind("Per Level", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperlight = Config.Bind("Per Level", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperlight = Config.Bind("Per Level", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierlight = Config.Bind("Windlass", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcelight = Config.Bind("Windlass", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            //damage for poison
            damageposion = Config.Bind("Windlass Damage", "Overall Damage", 250, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntposion = Config.Bind("Windlass Damage", "Blunt Damge", 50, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalposion = Config.Bind("Windlass Damage", "Slash Damage", 500, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceposion = Config.Bind("Windlass Damage", "Pierce Damge", 400, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopposion = Config.Bind("Windlass Damage", "Chop Damage", 950, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeposion = Config.Bind("Windlass Damage", "PickAxe Damage", 1500, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireposion = Config.Bind("Windlass Damage", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostposion = Config.Bind("Windlass Damage", "Frost Damage", 1500, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningposion = Config.Bind("Windlass Damage", "Lightning Damage", 1500, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonposion = Config.Bind("Windlass Damage", "Poison Damage", 500, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritposion = Config.Bind("Windlass Damage", "Spirit Damage", 1500, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperposion = Config.Bind("Per Level", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperposion = Config.Bind("Per Level", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperposion = Config.Bind("Per Level", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperposion = Config.Bind("Per Level", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperposion = Config.Bind("Per Level", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperposion = Config.Bind("Per Level", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperposion = Config.Bind("Per Level", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperposion = Config.Bind("Per Level", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperposion = Config.Bind("Per Level", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperposion = Config.Bind("Per Level", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperposion = Config.Bind("Per Level", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierposion = Config.Bind("Windlass", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforceposion = Config.Bind("Windlass", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

        }


    }
}