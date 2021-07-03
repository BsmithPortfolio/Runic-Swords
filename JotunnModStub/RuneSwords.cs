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
using System;

namespace RuneSwords
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class RuneSwords : BaseUnityPlugin
    {
        public const string PluginGUID = "com.zarboz.runicswords";
        public const string PluginName = "RuneSwords";
        public const string PluginVersion = "0.0.9";
        private AssetBundle runeassets;
        #region ConfigEntries
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
        private ConfigEntry<int> greatdamagefrost;
        private ConfigEntry<int> greatbluntfrost;
        private ConfigEntry<int> greatslashvalfrost;
        private ConfigEntry<int> greatpiercefrost;
        private ConfigEntry<int> greatchopfrost;
        private ConfigEntry<int> greatpickaxefrost;
        private ConfigEntry<int> greatfirefrost;
        private ConfigEntry<int> greatfrostfrost;
        private ConfigEntry<int> greatlightningfrost;
        private ConfigEntry<int> greatpoisonfrost;
        private ConfigEntry<int> greatspiritfrost;
        private ConfigEntry<int> greatdamageperfrost;
        private ConfigEntry<int> greatbluntperfrost;
        private ConfigEntry<int> greatslashperfrost;
        private ConfigEntry<int> greatpierceperfrost;
        private ConfigEntry<int> greatchopperfrost;
        private ConfigEntry<int> greatpickaxeperfrost;
        private ConfigEntry<int> greatfireperfrost;
        private ConfigEntry<int> greatfrostperfrost;
        private ConfigEntry<int> greatlightningperfrost;
        private ConfigEntry<int> greatpoisonperfrost;
        private ConfigEntry<int> greatspiritperfrost;
        private ConfigEntry<int> greattierfrost;
        private ConfigEntry<int> greatattackforcefrost;
        private ConfigEntry<int> daggerdamagefrost;
        private ConfigEntry<int> daggerbluntfrost;
        private ConfigEntry<int> daggerslashvalfrost;
        private ConfigEntry<int> daggerpiercefrost;
        private ConfigEntry<int> daggerchopfrost;
        private ConfigEntry<int> daggerpickaxefrost;
        private ConfigEntry<int> daggerfirefrost;
        private ConfigEntry<int> daggerfrostfrost;
        private ConfigEntry<int> daggerlightningfrost;
        private ConfigEntry<int> daggerpoisonfrost;
        private ConfigEntry<int> daggerspiritfrost;
        private ConfigEntry<int> daggerdamageperfrost;
        private ConfigEntry<int> daggerbluntperfrost;
        private ConfigEntry<int> daggerslashperfrost;
        private ConfigEntry<int> daggerpierceperfrost;
        private ConfigEntry<int> daggerchopperfrost;
        private ConfigEntry<int> daggerpickaxeperfrost;
        private ConfigEntry<int> daggerfireperfrost;
        private ConfigEntry<int> daggerfrostperfrost;
        private ConfigEntry<int> daggerlightningperfrost;
        private ConfigEntry<int> daggerpoisonperfrost;
        private ConfigEntry<int> daggerspiritperfrost;
        private ConfigEntry<int> daggertierfrost;
        private ConfigEntry<int> daggerattackforcefrost;
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
        private ConfigEntry<int> greatdamagefire;
        private ConfigEntry<int> greatbluntfire;
        private ConfigEntry<int> greatslashvalfire;
        private ConfigEntry<int> greatpiercefire;
        private ConfigEntry<int> greatchopfire;
        private ConfigEntry<int> greatpickaxefire;

        public ConfigEntry<int> greatfirefire;

        private ConfigEntry<int> greatfrostfire;
        private ConfigEntry<int> greatlightningfire;
        private ConfigEntry<int> greatpoisonfire;
        private ConfigEntry<int> greatspiritfire;
        private ConfigEntry<int> greatdamageperfire;
        private ConfigEntry<int> greatbluntperfire;
        private ConfigEntry<int> greatslashperfire;
        private ConfigEntry<int> greatpierceperfire;
        private ConfigEntry<int> greatchopperfire;
        private ConfigEntry<int> greatpickaxeperfire;
        private ConfigEntry<int> greatfireperfire;
        private ConfigEntry<int> greatfrostperfire;
        private ConfigEntry<int> greatlightningperfire;
        private ConfigEntry<int> greatpoisonperfire;
        private ConfigEntry<int> greatspiritperfire;
        private ConfigEntry<int> greattierfire;
        private ConfigEntry<int> greatattackforcefire;
        private ConfigEntry<int> daggerdamagefire;
        private ConfigEntry<int> daggerbluntfire;
        private ConfigEntry<int> daggerslashvalfire;
        private ConfigEntry<int> daggerpiercefire;
        private ConfigEntry<int> daggerchopfire;
        private ConfigEntry<int> daggerpickaxefire;
        private ConfigEntry<int> daggerfirefire;
        private ConfigEntry<int> daggerfrostfire;
        private ConfigEntry<int> daggerlightningfire;
        private ConfigEntry<int> daggerpoisonfire;
        private ConfigEntry<int> daggerspiritfire;
        private ConfigEntry<int> daggerdamageperfire;
        private ConfigEntry<int> daggerbluntperfire;
        private ConfigEntry<int> daggerslashperfire;
        private ConfigEntry<int> daggerpierceperfire;
        private ConfigEntry<int> daggerchopperfire;
        private ConfigEntry<int> daggerpickaxeperfire;
        private ConfigEntry<int> daggerfireperfire;
        private ConfigEntry<int> daggerfrostperfire;
        private ConfigEntry<int> daggerlightningperfire;
        private ConfigEntry<int> daggerpoisonperfire;
        private ConfigEntry<int> daggerspiritperfire;
        private ConfigEntry<int> daggertierfire;
        private ConfigEntry<int> daggerattackforcefire;
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
        private ConfigEntry<int> greatdamageposion;
        private ConfigEntry<int> greatbluntposion;
        private ConfigEntry<int> greatslashvalposion;
        private ConfigEntry<int> greatpierceposion;
        private ConfigEntry<int> greatchopposion;
        private ConfigEntry<int> greatpickaxeposion;
        private ConfigEntry<int> greatfireposion;
        private ConfigEntry<int> greatfrostposion;
        private ConfigEntry<int> greatlightningposion;
        private ConfigEntry<int> greatpoisonposion;
        private ConfigEntry<int> greatspiritposion;
        private ConfigEntry<int> greatdamageperposion;
        private ConfigEntry<int> greatbluntperposion;
        private ConfigEntry<int> greatslashperposion;
        private ConfigEntry<int> greatpierceperposion;
        private ConfigEntry<int> greatchopperposion;
        private ConfigEntry<int> greatpickaxeperposion;
        private ConfigEntry<int> greatfireperposion;
        private ConfigEntry<int> greatfrostperposion;
        private ConfigEntry<int> greatlightningperposion;
        private ConfigEntry<int> greatpoisonperposion;
        private ConfigEntry<int> greatspiritperposion;
        private ConfigEntry<int> greattierposion;
        private ConfigEntry<int> greatattackforceposion;
        private ConfigEntry<int> daggerdamageposion;
        private ConfigEntry<int> daggerbluntposion;
        private ConfigEntry<int> daggerslashvalposion;
        private ConfigEntry<int> daggerpierceposion;
        private ConfigEntry<int> daggerchopposion;
        private ConfigEntry<int> daggerpickaxeposion;
        private ConfigEntry<int> daggerfireposion;
        private ConfigEntry<int> daggerfrostposion;
        private ConfigEntry<int> daggerlightningposion;
        private ConfigEntry<int> daggerpoisonposion;
        private ConfigEntry<int> daggerspiritposion;
        private ConfigEntry<int> daggerdamageperposion;
        private ConfigEntry<int> daggerbluntperposion;
        private ConfigEntry<int> daggerslashperposion;
        private ConfigEntry<int> daggerpierceperposion;
        private ConfigEntry<int> daggerchopperposion;
        private ConfigEntry<int> daggerpickaxeperposion;
        private ConfigEntry<int> daggerfireperposion;
        private ConfigEntry<int> daggerfrostperposion;
        private ConfigEntry<int> daggerlightningperposion;
        private ConfigEntry<int> daggerpoisonperposion;
        private ConfigEntry<int> daggerspiritperposion;
        private ConfigEntry<int> daggertierposion;
        private ConfigEntry<int> daggerattackforceposion;
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
        private ConfigEntry<int> greatdamagelight;
        private ConfigEntry<int> greatbluntlight;
        private ConfigEntry<int> greatslashvallight;
        private ConfigEntry<int> greatpiercelight;
        private ConfigEntry<int> greatchoplight;
        private ConfigEntry<int> greatpickaxelight;
        private ConfigEntry<int> greatfirelight;
        private ConfigEntry<int> greatfrostlight;
        private ConfigEntry<int> greatlightninglight;
        private ConfigEntry<int> greatpoisonlight;
        private ConfigEntry<int> greatspiritlight;
        private ConfigEntry<int> greatdamageperlight;
        private ConfigEntry<int> greatbluntperlight;
        private ConfigEntry<int> greatslashperlight;
        private ConfigEntry<int> greatpierceperlight;
        private ConfigEntry<int> greatchopperlight;
        private ConfigEntry<int> greatpickaxeperlight;
        private ConfigEntry<int> greatfireperlight;
        private ConfigEntry<int> greatfrostperlight;
        private ConfigEntry<int> greatlightningperlight;
        private ConfigEntry<int> greatpoisonperlight;
        private ConfigEntry<int> greatspiritperlight;
        private ConfigEntry<int> greattierlight;
        private ConfigEntry<int> greatattackforcelight;
        private ConfigEntry<int> daggerdamagelight;
        private ConfigEntry<int> daggerbluntlight;
        private ConfigEntry<int> daggerslashvallight;
        private ConfigEntry<int> daggerpiercelight;
        private ConfigEntry<int> daggerchoplight;
        private ConfigEntry<int> daggerpickaxelight;
        private ConfigEntry<int> daggerfirelight;
        private ConfigEntry<int> daggerfrostlight;
        private ConfigEntry<int> daggerlightninglight;
        private ConfigEntry<int> daggerpoisonlight;
        private ConfigEntry<int> daggerspiritlight;
        private ConfigEntry<int> daggerdamageperlight;
        private ConfigEntry<int> daggerbluntperlight;
        private ConfigEntry<int> daggerslashperlight;
        private ConfigEntry<int> daggerpierceperlight;
        private ConfigEntry<int> daggerchopperlight;
        private ConfigEntry<int> daggerpickaxeperlight;
        private ConfigEntry<int> daggerfireperlight;
        private ConfigEntry<int> daggerfrostperlight;
        private ConfigEntry<int> daggerlightningperlight;
        private ConfigEntry<int> daggerpoisonperlight;
        private ConfigEntry<int> daggerspiritperlight;
        private ConfigEntry<int> daggertierlight;
        private ConfigEntry<int> daggerattackforcelight;
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
        #endregion
        private EffectList effecthit;
        private EffectList effectblocked;
        private EffectList trigger;
        private EffectList trailfx;
        private EffectList buildsounds;

        private GameObject FrostSword;
        private CustomItem Frost_Sword;
        private GameObject Ice_GreatSword;
        private CustomItem IceGreat_Sword;
        private GameObject Fire_GreatSword;
        private CustomItem FireGreat_Sword;
        private GameObject Poison_GreatSword;
        private CustomItem PoisonGreat_Sword;
        private GameObject Lgntng_GreatSword;
        private CustomItem YlwGreatSwrd;
        private GameObject firefab;
        private CustomItem firerune;
        private GameObject poisonfab;
        private CustomItem poison;
        private GameObject lightningfab;
        private CustomItem llightrune;
        private GameObject FrostDagger;
        private CustomItem Frost_Dagger;
        private GameObject firedagger;
        private CustomItem fire_dagger;
        private GameObject poisondagger;
        private CustomItem poison_dagger;
        private GameObject lightningdagger;
        private CustomItem lightning_dagger;

        private void Awake()
        {
            LoadAssets();
            ConfigDeploy();
            
            SynchronizationManager.OnConfigurationSynchronized += (obj, attr) =>
            {
                if (attr.InitialSynchronization)
                {
                    Jotunn.Logger.LogMessage("Initial Config sync event received");
                    LoadSwords();
                }
                else
                {
                    Jotunn.Logger.LogMessage("Config sync event received");
                    LoadSwords();
                }
            };
            ItemManager.OnVanillaItemsAvailable += LoadgameFabs; 


        }

        public void LoadAssets()
        {
            runeassets = AssetUtils.LoadAssetBundleFromResources("runeswords", typeof(RuneSwords).Assembly);
        }

        private void LoadSwords()
        {
            var db = ObjectDB.instance.m_items;
            #region Ice Sword Config
            //Apply Ice Sword CFG
            db.Remove(FrostSword);
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)damagefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = (int)bluntfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)slashvalfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)piercefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)chopfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)pickaxefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)firefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)frostfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)lightningfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)poisonfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)spiritfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)damageperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)bluntperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)slashperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)pierceperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)chopperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)pickaxeperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)fireperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)frostperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)lightningperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)poisonperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)spiritperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = (int)attackforcefrost.Value;
            db.Add(FrostSword);
            #endregion
            #region Fire Sword Config
            //fire sword config
            db.Remove(firefab);
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damagefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_toolTier = tierfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = piercefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_chop = chopfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_fire = firefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_attackForce = attackforcefire.Value;
            db.Add(firefab);
            #endregion
            #region Poison Sword Config
            //poison sword config
            db.Remove(poisonfab);
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damageposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_toolTier = tierposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = pierceposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_chop = chopposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxeposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_fire = fireposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperposion.Value;
            db.Add(poisonfab);
            #endregion
            #region Lightning Sword Config
            //lightning sword config
            db.Remove(lightningfab);
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damagelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_toolTier = tierlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvallight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = piercelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_chop = choplight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_fire = firelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightninglight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_attackForce = attackforcelight.Value;
            db.Add(lightningfab);
            #endregion
            #region Frost Great Sword Config
            db.Remove(Ice_GreatSword);
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)greatdamagefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = (int)greatbluntfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = (int)greattierfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)greatslashvalfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)greatpiercefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)greatchopfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)greatpickaxefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)greatfirefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)greatfrostfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)greatlightningfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)greatpoisonfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)greatspiritfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)greatdamageperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)greatbluntperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)greatslashperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)greatpierceperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)greatchopperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)greatpickaxeperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)greatfireperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)greatfrostperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)greatlightningperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)greatpoisonperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)greatspiritperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = (int)greatattackforcefrost.Value;
            db.Add(Ice_GreatSword);
            #endregion
            #region Fire Great Sword Config
            db.Remove(Fire_GreatSword);
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = greatdamagefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = greatbluntfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = greattierfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = greatslashvalfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = greatpiercefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = greatchopfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = greatpickaxefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = greatfirefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = greatfrostfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = greatlightningfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = greatpoisonfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = greatspiritfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = greatdamageperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = greatbluntperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = greatslashperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = greatpierceperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = greatchopperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = greatpickaxeperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = greatfireperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = greatfrostperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = greatlightningperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = greatpoisonperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = greatspiritperfire.Value;
            db.Add(Fire_GreatSword);
            #endregion
            #region Poison Great Sword Config
            db.Add(Poison_GreatSword);
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = greatdamageposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = greatbluntposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = greattierposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = greatslashvalposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = greatpierceposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = greatchopposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = greatpickaxeposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = greatfireposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = greatfrostposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = greatlightningposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = greatpoisonposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = greatspiritposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = greatdamageperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = greatbluntperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = greatslashperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = greatpierceperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = greatchopperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = greatpickaxeperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = greatfireperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = greatfrostperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = greatlightningperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = greatpoisonperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = greatspiritperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = greatattackforceposion.Value;
            db.Remove(Poison_GreatSword);
            #endregion
            #region Great Lightning Sword Config
            db.Remove(Lgntng_GreatSword);
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_damage = greatdamagelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = greatbluntlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_toolTier = greattierlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_slash = greatslashvallight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = greatpiercelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_chop = greatchoplight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = greatpickaxelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_fire = greatfirelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_frost = greatfrostlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = greatlightninglight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_poison = greatpoisonlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = greatspiritlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = greatdamageperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = greatbluntperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = greatslashperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = greatpierceperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = greatchopperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = greatpickaxeperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = greatfireperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = greatfrostperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = greatlightningperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = greatpoisonperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = greatspiritperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_attackForce = greatattackforcelight.Value;
            db.Add(Lgntng_GreatSword);
            #endregion
            #region Ice Dagger Config
            db.Remove(FrostDagger);
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)daggerdamagefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_toolTier = (int)daggerbluntfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)daggerslashvalfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)daggerpiercefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)daggerchopfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)daggerpickaxefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)daggerfirefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)daggerfrostfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)daggerlightningfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)daggerpoisonfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)daggerspiritfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)daggerdamageperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)daggerbluntperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)daggerslashperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)daggerpierceperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)daggerchopperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)daggerpickaxeperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)daggerfireperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)daggerfrostperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)daggerlightningperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)daggerpoisonperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)daggerspiritperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_attackForce = (int)daggerattackforcefrost.Value;
            db.Add(FrostDagger);
            #endregion
            #region Fire Dagger Config
            db.Remove(firedagger);
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamagefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvalfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpiercefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchopfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfirefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightningfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforcefire.Value;
            db.Add(firedagger);
            #endregion
            #region Poison Dagger Config
            db.Remove(poisondagger);
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamageposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvalposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpierceposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchopposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxeposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfireposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightningposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforceposion.Value;
            db.Add(poisondagger);
            #endregion
            #region Lightning Dagger Config
            db.Remove(lightningdagger);
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamagelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvallight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpiercelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchoplight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfirelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightninglight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforcelight.Value;
            db.Add(lightningdagger);

            #endregion
        }
        public void LoadgameFabs()
        {
            try
            {
                var hitsparks = PrefabManager.Cache.GetPrefab<GameObject>("vfx_HitSparks");
                var sfxhitsword = PrefabManager.Cache.GetPrefab<GameObject>("sfx_sword_hit");
                var camshake = PrefabManager.Cache.GetPrefab<GameObject>("fx_hit_camshake");
                var sfxblocked = PrefabManager.Cache.GetPrefab<GameObject>("sfx_metal_blocked");
                var vfxblock = PrefabManager.Cache.GetPrefab<GameObject>("vfx_blocked");
                var sfxswing = PrefabManager.Cache.GetPrefab<GameObject>("sfx_sword_swing");
                var camshakeblock = PrefabManager.Cache.GetPrefab<GameObject>("fx_block_camshake");

                var sfxhammer = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
                var vfx_Place_wood_pole = PrefabManager.Cache.GetPrefab<GameObject>("vfx_Place_wood_pole");


                buildsounds = new EffectList { m_effectPrefabs = new EffectList.EffectData[2] { new EffectList.EffectData { m_prefab = sfxhammer }, new EffectList.EffectData { m_prefab = vfx_Place_wood_pole } } };

                effecthit = new EffectList { m_effectPrefabs = new EffectList.EffectData[3] { new EffectList.EffectData { m_prefab = hitsparks, m_enabled = true }, new EffectList.EffectData { m_prefab = sfxhitsword, m_enabled = true }, new EffectList.EffectData { m_prefab = camshake, m_enabled = true } } };
                effectblocked = new EffectList { m_effectPrefabs = new EffectList.EffectData[3] { new EffectList.EffectData { m_prefab = sfxblocked }, new EffectList.EffectData { m_prefab = vfxblock, m_enabled = true }, new EffectList.EffectData { m_prefab = camshakeblock, m_enabled = true } } };
                trigger = new EffectList { m_effectPrefabs = new EffectList.EffectData[1] { new EffectList.EffectData { m_prefab = camshake, m_enabled = true } } };
                trailfx = new EffectList { m_effectPrefabs = new EffectList.EffectData[1] { new EffectList.EffectData { m_prefab = sfxswing, m_enabled = true } } };

                Jotunn.Logger.LogMessage("Loaded Game VFX and SFX");

                Jotunn.Logger.LogMessage("Loading Runestones");
                piece_exentension();
                piece_exentension1();
                piece_exentension2();
                piece_exentension3();
                piece_exentension4();
                piece_exentension5();
                Jotunn.Logger.LogMessage("Loading Swords");
                IceSword();
                FireSword();
                PoisonSword();
                LightningSword();
                Jotunn.Logger.LogMessage("Loading Great Swords");
                IceGreatSword();
                FireGreatSword();
                PoisonGreatSword();
                LightningGreatSword();
                Jotunn.Logger.LogMessage("Loading Knives");
                IceDagger();
                FireDagger();
                PoisonDagger();
                LightningDagger();

            }
            catch (Exception ex)
            {
                Jotunn.Logger.LogError($"Error while adding cloned item: {ex.Message}");
            }
            finally
            {
                ItemManager.OnVanillaItemsAvailable -= LoadgameFabs;
            }
        }
        public void IceSword()
        {
            FrostSword = runeassets.LoadAsset<GameObject>("IceRuneSword");
            Frost_Sword = new CustomItem(FrostSword, fixReference: true,
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
                        new RequirementConfig {Item = "Obsidian", Amount = (int)ObsidianFrost.Value, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = (int)IronFrost.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "FreezeGland", Amount = (int)IceFreezeGland.Value, AmountPerLevel = 10},
                        new RequirementConfig {Item = "DragonTear", Amount = (int)DragonTear.Value, AmountPerLevel = 5}
                    }
                });
            
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)damagefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = (int)bluntfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = (int)tierfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)slashvalfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)piercefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)chopfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)pickaxefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)firefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)frostfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)lightningfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)poisonfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)spiritfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)damageperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)bluntperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)slashperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)pierceperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)chopperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)pickaxeperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)fireperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)frostperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)lightningperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)poisonperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)spiritperfrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = (int)attackforcefrost.Value;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            Frost_Sword.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;

            ItemManager.Instance.AddItem(Frost_Sword);

        }

        public void FireSword()
        {
            firefab = runeassets.LoadAsset<GameObject>("FireRuneSword");
            firerune = new CustomItem(firefab, fixReference: true,
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
            firerune.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damagefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_toolTier = tierfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = piercefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_chop = chopfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_fire = firefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperfire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_attackForce = attackforcefire.Value;
            firerune.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            firerune.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            firerune.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            firerune.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(firerune);
        }

        public void PoisonSword()
        {
             poisonfab = runeassets.LoadAsset<GameObject>("PoisonRuneSword");
             poison = new CustomItem(poisonfab, fixReference: true,
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
            poison.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damageposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_toolTier = tierposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = pierceposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_chop = chopposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxeposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_fire = fireposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_attackForce = attackforceposion.Value;
            poison.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            poison.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            poison.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            poison.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(poison);
        }

        public void LightningSword()
        {
            lightningfab = runeassets.LoadAsset<GameObject>("LightningRuneSword");
            llightrune = new CustomItem(lightningfab, fixReference: true,
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
            llightrune.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damagelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_toolTier = tierlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvallight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = piercelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_chop = choplight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_fire = firelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightninglight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperlight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_attackForce = attackforcelight.Value;
            llightrune.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            llightrune.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            llightrune.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            llightrune.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;

            ItemManager.Instance.AddItem(llightrune);
        }
         
        public void IceGreatSword()
        {
            Ice_GreatSword = runeassets.LoadAsset<GameObject>("GreatIceRuneSword");
            IceGreat_Sword = new CustomItem(Ice_GreatSword, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Great Runic Ice Sword",
                    Enabled = FrostEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {//todo fix recipe config sync for great weapon
                        new RequirementConfig {Item = "Obsidian", Amount = (int)ObsidianFrost.Value, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = (int)IronFrost.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "FreezeGland", Amount = (int)IceFreezeGland.Value, AmountPerLevel = 10},
                        new RequirementConfig {Item = "DragonTear", Amount = (int)DragonTear.Value, AmountPerLevel = 5}
                    }
                });
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)greatdamagefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = (int)greatbluntfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = (int)greattierfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)greatslashvalfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)greatpiercefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)greatchopfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)greatpickaxefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)greatfirefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)greatfrostfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)greatlightningfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)greatpoisonfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)greatspiritfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)greatdamageperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)greatbluntperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)greatslashperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)greatpierceperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)greatchopperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)greatpickaxeperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)greatfireperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)greatfrostperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)greatlightningperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)greatpoisonperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)greatspiritperfrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = (int)greatattackforcefrost.Value;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            IceGreat_Sword.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(IceGreat_Sword);
        }
        public void FireGreatSword()
        {
            Fire_GreatSword = runeassets.LoadAsset<GameObject>("GreatFireRuneSword");
            FireGreat_Sword = new CustomItem(Fire_GreatSword, fixReference: true,
            new ItemConfig
            {
                Amount = 1,
                     Name = "Great Runic Fire Sword",
                     Enabled = FireEnable.Value,
                     CraftingStation = "piece_artisanstation",
                     RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        //todo fix recipe config sync for great weapon
                        new RequirementConfig {Item = "Flametal", Amount = FireFlametal.Value, AmountPerLevel = 50},
                        new RequirementConfig {Item = "SurtlingCore", Amount = FireSurtling.Value, AmountPerLevel = 35},
                        new RequirementConfig {Item = "Iron", Amount = IronFire.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "Obsidian", Amount = ObsidianFire.Value, AmountPerLevel = 5},
                    }
            });
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = greatdamagefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = greatbluntfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = greattierfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = greatslashvalfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = greatpiercefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = greatchopfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = greatpickaxefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = greatfirefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = greatfrostfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = greatlightningfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = greatpoisonfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = greatspiritfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = greatdamageperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = greatbluntperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = greatslashperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = greatpierceperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = greatchopperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = greatpickaxeperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = greatfireperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = greatfrostperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = greatlightningperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = greatpoisonperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = greatspiritperfire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = greatattackforcefire.Value;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            FireGreat_Sword.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(FireGreat_Sword);
        }
        public void PoisonGreatSword()
        {
            Poison_GreatSword = runeassets.LoadAsset<GameObject>("GreatPoisonRuneSword");
            PoisonGreat_Sword = new CustomItem(Poison_GreatSword, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Great Runic Poison Sword",
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
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_damage = damageposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = bluntposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_toolTier = tierposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_slash = slashvalposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = pierceposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_chop = chopposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = pickaxeposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_fire = fireposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_frost = frostposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = lightningposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_poison = poisonposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = spiritposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = damageperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = bluntperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = slashperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = pierceperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = chopperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = pickaxeperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = fireperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = frostperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = lightningperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = poisonperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = spiritperposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_attackForce = attackforceposion.Value;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            PoisonGreat_Sword.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(PoisonGreat_Sword);
        }
        public void LightningGreatSword()
        {
            Lgntng_GreatSword = runeassets.LoadAsset<GameObject>("GreatLightningRuneSword");
            YlwGreatSwrd = new CustomItem(Lgntng_GreatSword, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Great Runic Lightning Sword",
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
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_damage = greatdamagelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = greatbluntlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_toolTier = greattierlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_slash = greatslashvallight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = greatpiercelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_chop = greatchoplight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = greatpickaxelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_fire = greatfirelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_frost = greatfrostlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = greatlightninglight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_poison = greatpoisonlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = greatspiritlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = greatdamageperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = greatbluntperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = greatslashperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = greatpierceperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = greatchopperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = greatpickaxeperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = greatfireperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = greatfrostperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = greatlightningperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = greatpoisonperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = greatspiritperlight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_attackForce = greatattackforcelight.Value;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            YlwGreatSwrd.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(YlwGreatSwrd);
        }

        public void IceDagger()
        {
            FrostDagger = runeassets.LoadAsset<GameObject>("IceRuneDagger");
            Frost_Dagger = new CustomItem(FrostDagger, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Ice Dagger",
                    Enabled = FrostEnable.Value,
                    CraftingStation = "piece_artisanstation",
                    RepairStation = "piece_artisanstation",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Obsidian", Amount = (int)ObsidianFrost.Value, AmountPerLevel = 5},
                        new RequirementConfig {Item = "Iron", Amount = (int)IronFrost.Value, AmountPerLevel = 25},
                        new RequirementConfig {Item = "FreezeGland", Amount = (int)IceFreezeGland.Value, AmountPerLevel = 10},
                        new RequirementConfig {Item = "DragonTear", Amount = (int)DragonTear.Value, AmountPerLevel = 5}
                    }
                });

            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = (int)daggerdamagefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = (int)daggerbluntfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_toolTier = (int)daggertierfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = (int)daggerslashvalfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = (int)daggerpiercefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = (int)daggerchopfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = (int)daggerpickaxefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = (int)daggerfirefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = (int)daggerfrostfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = (int)daggerlightningfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = (int)daggerpoisonfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = (int)daggerspiritfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = (int)daggerdamageperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = (int)daggerbluntperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = (int)daggerslashperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = (int)daggerpierceperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = (int)daggerchopperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = (int)daggerpickaxeperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = (int)daggerfireperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = (int)daggerfrostperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = (int)daggerlightningperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = (int)daggerpoisonperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = (int)daggerspiritperfrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_attackForce = (int)daggerattackforcefrost.Value;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            Frost_Dagger.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;

            ItemManager.Instance.AddItem(Frost_Dagger);

        }

        public void FireDagger()
        {
            firedagger = runeassets.LoadAsset<GameObject>("FireRuneDagger");
            fire_dagger = new CustomItem(firedagger, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Fire Dagger",
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
            fire_dagger.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamagefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvalfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpiercefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchopfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfirefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightningfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperfire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforcefire.Value;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            fire_dagger.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(fire_dagger);
        }

        public void PoisonDagger()
        {
            poisondagger = runeassets.LoadAsset<GameObject>("PoisonRuneDagger");
            poison_dagger = new CustomItem(poisondagger, fixReference: true,
               new ItemConfig
               {
                   Amount = 1,
                   Name = "Runic Poison Dagger",
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
            poison_dagger.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamageposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvalposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpierceposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchopposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxeposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfireposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightningposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforceposion.Value;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            poison_dagger.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;
            ItemManager.Instance.AddItem(poison_dagger);
        }

        public void LightningDagger()
        {
            lightningdagger = runeassets.LoadAsset<GameObject>("LightningRuneDagger");
            lightning_dagger = new CustomItem(lightningdagger, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Runic Lightning Dagger",
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
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_maxQuality = 10;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_damage = daggerdamagelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_blunt = daggerbluntlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_toolTier = daggertierlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_slash = daggerslashvallight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pierce = daggerpiercelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_chop = daggerchoplight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_pickaxe = daggerpickaxelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_fire = daggerfirelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_frost = daggerfrostlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_lightning = daggerlightninglight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_poison = daggerpoisonlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damages.m_spirit = daggerspiritlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_damage = daggerdamageperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_blunt = daggerbluntperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_slash = daggerslashperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pierce = daggerpierceperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_chop = daggerchopperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_pickaxe = daggerpickaxeperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_fire = daggerfireperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_frost = daggerfrostperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_lightning = daggerlightningperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_poison = daggerpoisonperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_damagesPerLevel.m_spirit = daggerspiritperlight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_attackForce = daggerattackforcelight.Value;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_hitEffect = effecthit;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_blockEffect = effectblocked;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_triggerEffect = trigger;
            lightning_dagger.ItemDrop.m_itemData.m_shared.m_trailStartEffect = trailfx;

            ItemManager.Instance.AddItem(lightning_dagger);
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
            var piece = ext1.Piece;
            piece.m_placeEffect = buildsounds;
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
            var piece1 = ext2.Piece;
            piece1.m_placeEffect = buildsounds; 
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
            var sfx = ext3.Piece;
            sfx.m_placeEffect = buildsounds;
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
            var ext4thing = ext4.Piece;
            ext4thing.m_placeEffect = buildsounds;
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
            var ext5thing = ext5.Piece;
            ext5thing.m_placeEffect = buildsounds;
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
            var ext6thing = ext6.Piece;
            ext6thing.m_placeEffect = buildsounds;
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
            
            damagefrost = Config.Bind("Frost Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntfrost = Config.Bind("Frost Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalfrost = Config.Bind("Frost Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercefrost = Config.Bind("Frost Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopfrost = Config.Bind("Frost Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxefrost = Config.Bind("Frost Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firefrost = Config.Bind("Frost Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostfrost = Config.Bind("Frost Sword", "Frost Damage", 250, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningfrost = Config.Bind("Frost Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonfrost = Config.Bind("Frost Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritfrost = Config.Bind("Frost Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperfrost = Config.Bind("Frost Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperfrost = Config.Bind("Frost Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperfrost = Config.Bind("Frost Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperfrost = Config.Bind("Frost Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperfrost = Config.Bind("Frost Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperfrost = Config.Bind("Frost Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperfrost = Config.Bind("Frost Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperfrost = Config.Bind("Frost Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperfrost = Config.Bind("Frost Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperfrost = Config.Bind("Frost Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperfrost = Config.Bind("Frost Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierfrost = Config.Bind("Frost Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcefrost = Config.Bind("Frost Sword", "Attack Force", 30, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
          
            
            greatdamagefrost = Config.Bind("Great Frost Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntfrost = Config.Bind("Great Frost Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashvalfrost = Config.Bind("Great Frost Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpiercefrost = Config.Bind("Great Frost Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopfrost = Config.Bind("Great Frost Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxefrost = Config.Bind("Great Frost Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfirefrost = Config.Bind("Great Frost Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostfrost = Config.Bind("Great Frost Sword", "Frost Damage", 250, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningfrost = Config.Bind("Great Frost Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonfrost = Config.Bind("Great Frost Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritfrost = Config.Bind("Great Frost Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greatdamageperfrost = Config.Bind("Great Frost Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntperfrost = Config.Bind("Great Frost Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashperfrost = Config.Bind("Great Frost Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpierceperfrost = Config.Bind("Great Frost Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopperfrost = Config.Bind("Great Frost Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxeperfrost = Config.Bind("Great Frost Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfireperfrost = Config.Bind("Great Frost Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostperfrost = Config.Bind("Great Frost Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningperfrost = Config.Bind("Great Frost Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonperfrost = Config.Bind("Great Frost Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritperfrost = Config.Bind("Great Frost Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greattierfrost = Config.Bind("Great Frost Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatattackforcefrost = Config.Bind("Great Frost Sword", "Attack Force", 30, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            
            // Frost Dagger
            daggerdamagefrost = Config.Bind("Runic Frost Dagger", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntfrost = Config.Bind("Runic Frost Dagger", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashvalfrost = Config.Bind("Runic Frost Dagger", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpiercefrost = Config.Bind("Runic Frost Dagger", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopfrost = Config.Bind("Runic Frost Dagger", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxefrost = Config.Bind("Runic Frost Dagger", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfirefrost = Config.Bind("Runic Frost Dagger", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostfrost = Config.Bind("Runic Frost Dagger", "Frost Damage", 250, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningfrost = Config.Bind("Runic Frost Dagger", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonfrost = Config.Bind("Runic Frost Dagger", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritfrost = Config.Bind("Runic Frost Dagger", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggerdamageperfrost = Config.Bind("Runic Frost Dagger", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntperfrost = Config.Bind("Runic Frost Dagger", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashperfrost = Config.Bind("Runic Frost Dagger", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpierceperfrost = Config.Bind("Runic Frost Dagger", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopperfrost = Config.Bind("Runic Frost Dagger", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxeperfrost = Config.Bind("Runic Frost Dagger", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfireperfrost = Config.Bind("Runic Frost Dagger", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostperfrost = Config.Bind("Runic Frost Dagger", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningperfrost = Config.Bind("Runic Frost Dagger", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonperfrost = Config.Bind("Runic Frost Dagger", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritperfrost = Config.Bind("Runic Frost Dagger", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggertierfrost = Config.Bind("Runic Frost Dagger", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerattackforcefrost = Config.Bind("Runic Frost Dagger", "Attack Force", 30, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //damage values fire
            damagefire = Config.Bind("Fire Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntfire = Config.Bind("Fire Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalfire = Config.Bind("Fire Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercefire = Config.Bind("Fire Sword", "Pierce Damge", 235, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopfire = Config.Bind("Fire Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxefire = Config.Bind("Fire Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firefire = Config.Bind("Fire Sword", "Fire Damage", 200, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostfire = Config.Bind("Fire Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningfire = Config.Bind("Fire Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonfire = Config.Bind("Fire Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritfire = Config.Bind("Fire Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperfire = Config.Bind("Fire Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperfire = Config.Bind("Fire Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperfire = Config.Bind("Fire Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperfire = Config.Bind("Fire Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperfire = Config.Bind("Fire Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperfire = Config.Bind("Fire Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperfire = Config.Bind("Fire Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperfire = Config.Bind("Fire Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperfire = Config.Bind("Fire Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperfire = Config.Bind("Fire Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperfire = Config.Bind("Fire Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierfire = Config.Bind("Fire Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcefire = Config.Bind("Fire Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //great fire
            greatdamagefire = Config.Bind("Great Fire Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntfire = Config.Bind("Great Fire Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashvalfire = Config.Bind("Great Fire Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpiercefire = Config.Bind("Great Fire Sword", "Pierce Damge", 235, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopfire = Config.Bind("Great Fire Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxefire = Config.Bind("Great Fire Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfirefire = Config.Bind("Great Fire Sword", "Fire Damage", 200, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostfire = Config.Bind("Great Fire Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningfire = Config.Bind("Great Fire Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonfire = Config.Bind("Great Fire Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritfire = Config.Bind("Great Fire Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greatdamageperfire = Config.Bind("Great Fire Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntperfire = Config.Bind("Great Fire Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashperfire = Config.Bind("Great Fire Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpierceperfire = Config.Bind("Great Fire Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopperfire = Config.Bind("Great Fire Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxeperfire = Config.Bind("Great Fire Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfireperfire = Config.Bind("Great Fire Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostperfire = Config.Bind("Great Fire Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningperfire = Config.Bind("Great Fire Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonperfire = Config.Bind("Great Fire Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritperfire = Config.Bind("Great Fire Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greattierfire = Config.Bind("Great Fire Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatattackforcefire = Config.Bind("Great Fire Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            //dagger fire
            daggerdamagefire = Config.Bind("Fire Dagger", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntfire = Config.Bind("Fire Dagger", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashvalfire = Config.Bind("Fire Dagger", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpiercefire = Config.Bind("Fire Dagger", "Pierce Damge", 235, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopfire = Config.Bind("Fire Dagger", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxefire = Config.Bind("Fire Dagger", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfirefire = Config.Bind("Fire Dagger", "Fire Damage", 200, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostfire = Config.Bind("Fire Dagger", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningfire = Config.Bind("Fire Dagger", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonfire = Config.Bind("Fire Dagger", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritfire = Config.Bind("Fire Dagger", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggerdamageperfire = Config.Bind("Fire Dagger", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntperfire = Config.Bind("Fire Dagger", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashperfire = Config.Bind("Fire Dagger", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpierceperfire = Config.Bind("Fire Dagger", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopperfire = Config.Bind("Fire Dagger", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxeperfire = Config.Bind("Fire Dagger", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfireperfire = Config.Bind("Fire Dagger", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostperfire = Config.Bind("Fire Dagger", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningperfire = Config.Bind("Fire Dagger", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonperfire = Config.Bind("Fire Dagger", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritperfire = Config.Bind("Fire Dagger", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggertierfire = Config.Bind("Fire Dagger", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerattackforcefire = Config.Bind("Fire Dagger", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //damage values lightning
            damagelight = Config.Bind("Lightning Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntlight = Config.Bind("Lightning Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvallight = Config.Bind("Lightning Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            piercelight = Config.Bind("Lightning Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            choplight = Config.Bind("Lightning Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxelight = Config.Bind("Lightning Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            firelight = Config.Bind("Lightning Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostlight = Config.Bind("Lightning Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightninglight = Config.Bind("Lightning Sword", "Lightning Damage", 250, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonlight = Config.Bind("Lightning Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritlight = Config.Bind("Lightning Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperlight = Config.Bind("Lightning Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperlight = Config.Bind("Lightning Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperlight = Config.Bind("Lightning Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperlight = Config.Bind("Lightning Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperlight = Config.Bind("Lightning Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperlight = Config.Bind("Lightning Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperlight = Config.Bind("Lightning Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperlight = Config.Bind("Lightning Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperlight = Config.Bind("Lightning Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperlight = Config.Bind("Lightning Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperlight = Config.Bind("Lightning Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierlight = Config.Bind("Lightning Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforcelight = Config.Bind("Lightning Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            
            //great Lightning
            greatdamagelight = Config.Bind("Great Lightning Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntlight = Config.Bind("Great Lightning Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashvallight = Config.Bind("Great Lightning Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpiercelight = Config.Bind("Great Lightning Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchoplight = Config.Bind("Great Lightning Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxelight = Config.Bind("Great Lightning Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfirelight = Config.Bind("Great Lightning Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostlight = Config.Bind("Great Lightning Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightninglight = Config.Bind("Great Lightning Sword", "Lightning Damage", 250, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonlight = Config.Bind("Great Lightning Sword", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritlight = Config.Bind("Great Lightning Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            greatdamageperlight = Config.Bind("Great Lightning Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntperlight = Config.Bind("Great Lightning Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashperlight = Config.Bind("Great Lightning Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpierceperlight = Config.Bind("Great Lightning Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopperlight = Config.Bind("Great Lightning Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxeperlight = Config.Bind("Great Lightning Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfireperlight = Config.Bind("Great Lightning Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostperlight = Config.Bind("Great Lightning Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningperlight = Config.Bind("Great Lightning Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonperlight = Config.Bind("Great Lightning Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritperlight = Config.Bind("Great Lightning Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greattierlight = Config.Bind("Great Lightning Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatattackforcelight = Config.Bind("Great Lightning Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            
            //dagger Lightning
            daggerdamagelight = Config.Bind("Lightning Dagger", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntlight = Config.Bind("Lightning Dagger", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashvallight = Config.Bind("Lightning Dagger", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpiercelight = Config.Bind("Lightning Dagger", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchoplight = Config.Bind("Lightning Dagger", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxelight = Config.Bind("Lightning Dagger", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfirelight = Config.Bind("Lightning Dagger", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostlight = Config.Bind("Lightning Dagger", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightninglight = Config.Bind("Lightning Dagger", "Lightning Damage", 250, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonlight = Config.Bind("Lightning Dagger", "Poison Damage", 0, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritlight = Config.Bind("Lightning Dagger", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            daggerdamageperlight = Config.Bind("Lightning Dagger", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntperlight = Config.Bind("Lightning Dagger", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashperlight = Config.Bind("Lightning Dagger", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpierceperlight = Config.Bind("Lightning Dagger", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopperlight = Config.Bind("Lightning Dagger", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxeperlight = Config.Bind("Lightning Dagger", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfireperlight = Config.Bind("Lightning Dagger", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostperlight = Config.Bind("Lightning Dagger", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningperlight = Config.Bind("Lightning Dagger", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonperlight = Config.Bind("Lightning Dagger", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritperlight = Config.Bind("Lightning Dagger", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggertierlight = Config.Bind("Lightning Dagger", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerattackforcelight = Config.Bind("Lightning Dagger", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            //damage for poison
            damageposion = Config.Bind("Poison Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntposion = Config.Bind("Poison Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashvalposion = Config.Bind("Poison Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceposion = Config.Bind("Poison Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopposion = Config.Bind("Poison Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeposion = Config.Bind("Poison Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireposion = Config.Bind("Poison Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostposion = Config.Bind("Poison Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningposion = Config.Bind("Poison Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonposion = Config.Bind("Poison Sword", "Poison Damage", 250, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritposion = Config.Bind("Poison Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            damageperposion = Config.Bind("Poison Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            bluntperposion = Config.Bind("Poison Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            slashperposion = Config.Bind("Poison Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pierceperposion = Config.Bind("Poison Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            chopperposion = Config.Bind("Poison Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            pickaxeperposion = Config.Bind("Poison Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            fireperposion = Config.Bind("Poison Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            frostperposion = Config.Bind("Poison Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            lightningperposion = Config.Bind("Poison Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            poisonperposion = Config.Bind("Poison Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            spiritperposion = Config.Bind("Poison Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            tierposion = Config.Bind("Poison Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            attackforceposion = Config.Bind("Poison Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            //great poison (lelz any my spelling btw)
            greatdamageposion = Config.Bind("Great Poison Sword", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntposion = Config.Bind("Great Poison Sword", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashvalposion = Config.Bind("Great Poison Sword", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpierceposion = Config.Bind("Great Poison Sword", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopposion = Config.Bind("Great Poison Sword", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxeposion = Config.Bind("Great Poison Sword", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfireposion = Config.Bind("Great Poison Sword", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostposion = Config.Bind("Great Poison Sword", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningposion = Config.Bind("Great Poison Sword", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonposion = Config.Bind("Great Poison Sword", "Poison Damage", 250, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritposion = Config.Bind("Great Poison Sword", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greatdamageperposion = Config.Bind("Great Poison Sword", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatbluntperposion = Config.Bind("Great Poison Sword", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatslashperposion = Config.Bind("Great Poison Sword", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpierceperposion = Config.Bind("Great Poison Sword", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatchopperposion = Config.Bind("Great Poison Sword", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpickaxeperposion = Config.Bind("Great Poison Sword", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfireperposion = Config.Bind("Great Poison Sword", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatfrostperposion = Config.Bind("Great Poison Sword", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatlightningperposion = Config.Bind("Great Poison Sword", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatpoisonperposion = Config.Bind("Great Poison Sword", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatspiritperposion = Config.Bind("Great Poison Sword", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            greattierposion = Config.Bind("Great Poison Sword", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            greatattackforceposion = Config.Bind("Great Poison Sword", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

            //dagger poison (lelz any my spelling btw)
            daggerdamageposion = Config.Bind("Poison Dagger", "Overall Damage", 0, new ConfigDescription("Overall Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntposion = Config.Bind("Poison Dagger", "Blunt Damge", 0, new ConfigDescription("Blunt Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashvalposion = Config.Bind("Poison Dagger", "Slash Damage", 300, new ConfigDescription("Slash Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpierceposion = Config.Bind("Poison Dagger", "Pierce Damge", 135, new ConfigDescription("Pierce Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopposion = Config.Bind("Poison Dagger", "Chop Damage", 0, new ConfigDescription("Chop Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxeposion = Config.Bind("Poison Dagger", "PickAxe Damage", 0, new ConfigDescription("Pickaxe Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfireposion = Config.Bind("Poison Dagger", "Fire Damage", 0, new ConfigDescription("Fire Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostposion = Config.Bind("Poison Dagger", "Frost Damage", 0, new ConfigDescription("Frost Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningposion = Config.Bind("Poison Dagger", "Lightning Damage", 0, new ConfigDescription("Lightning Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonposion = Config.Bind("Poison Dagger", "Poison Damage", 250, new ConfigDescription("Poison Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritposion = Config.Bind("Poison Dagger", "Spirit Damage", 100, new ConfigDescription("Spirit Damage", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggerdamageperposion = Config.Bind("Poison Dagger", "Overall Damage Per Level", 50, new ConfigDescription("Overall Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerbluntperposion = Config.Bind("Poison Dagger", "Blunt Damage Per Level", 50, new ConfigDescription("Blunt Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerslashperposion = Config.Bind("Poison Dagger", "Slash Damage Per Level", 50, new ConfigDescription("Slash Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpierceperposion = Config.Bind("Poison Dagger", "Pierce Damage Per Level", 50, new ConfigDescription("Pierce Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerchopperposion = Config.Bind("Poison Dagger", "Chop Damage Per Level", 50, new ConfigDescription("Chop Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpickaxeperposion = Config.Bind("Poison Dagger", "PickAxe Damage Per Level", 50, new ConfigDescription("PickAxe Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfireperposion = Config.Bind("Poison Dagger", "Fire Damage Per Level", 50, new ConfigDescription("Fire Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerfrostperposion = Config.Bind("Poison Dagger", "Frost Damage Per Level", 50, new ConfigDescription("Frost Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerlightningperposion = Config.Bind("Poison Dagger", "Lightning Damage Per Level", 50, new ConfigDescription("Lightning Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerpoisonperposion = Config.Bind("Poison Dagger", "Poison Damage Per Level", 50, new ConfigDescription("Poison Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerspiritperposion = Config.Bind("Poison Dagger", "Spirit Damage Per Level", 50, new ConfigDescription("Spirit Damage per level", new AcceptableValueRange<int>(0, 2500), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));


            daggertierposion = Config.Bind("Poison Dagger", "Tool Tier", 5, new ConfigDescription("Tool Tier", new AcceptableValueRange<int>(0, 10), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));
            daggerattackforceposion = Config.Bind("Poison Dagger", "Attack Force", 90, new ConfigDescription("Attack Force", new AcceptableValueRange<int>(0, 100), null, new ConfigurationManagerAttributes { IsAdminOnly = true }));

        }


    }
}