﻿using System.Reflection;

namespace UpdateFieldCodeGenerator.Structures
{
    [HasChangesMask]
    public class CGActivePlayerData
    {
        public static readonly ObjectType ObjectType = ObjectType.ActivePlayer;

        public static readonly UpdateField invSlots = new UpdateField(typeof(WowGuid[]), UpdateFieldFlag.None, 227);
        public static readonly UpdateField farsightObject = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField summonedBattlePetGUID = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField knownTitles = new UpdateField(typeof(DynamicUpdateField<ulong>), UpdateFieldFlag.None);
        public static readonly UpdateField coinage = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField XP = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField nextLevelXP = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField trialXP = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField skill = new UpdateField(typeof(JamMirrorSkillInfo_C), UpdateFieldFlag.None);
        public static readonly UpdateField characterPoints = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField maxTalentTiers = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField trackCreatureMask = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField mainhandExpertise = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField offhandExpertise = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField rangedExpertise = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField combatRatingExpertise = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField blockPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField dodgePercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField dodgePercentageFromAttribute = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField parryPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField parryPercentageFromAttribute = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField critPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField rangedCritPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField offhandCritPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField spellCritPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField shieldBlock = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField shieldBlockCritPercentage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField mastery = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField speed = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField avoidance = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField sturdiness = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField versatility = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField versatilityBonus = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField pvpPowerDamage = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField pvpPowerHealing = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField exploredZones = new UpdateField(typeof(ulong[]), UpdateFieldFlag.None, 240);
        public static readonly UpdateField restInfo = new UpdateField(typeof(JamMirrorRestInfo_C[]), UpdateFieldFlag.None, 2);
        public static readonly UpdateField modDamageDonePos = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 7);
        public static readonly UpdateField modDamageDoneNeg = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 7);
        public static readonly UpdateField modDamageDonePercent = new UpdateField(typeof(float[]), UpdateFieldFlag.None, 7);
        public static readonly UpdateField modHealingDonePercent = new UpdateField(typeof(float[]), UpdateFieldFlag.None, 7);
        public static readonly UpdateField modHealingDonePos = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField modHealingPercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modPeriodicHealingDonePercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField weaponDmgMultipliers = new UpdateField(typeof(float[]), UpdateFieldFlag.None, 3);
        public static readonly UpdateField weaponAtkSpeedMultipliers = new UpdateField(typeof(float[]), UpdateFieldFlag.None, 3);
        public static readonly UpdateField modSpellPowerPercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modResiliencePercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField overrideSpellPowerByAPPercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField overrideAPBySpellPowerPercent = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modTargetResistance = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField modTargetPhysicalResistance = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField localFlags = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField grantableLevels = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField multiActionBars = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField lifetimeMaxRank = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField numRespecs = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField pvpMedals = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField buybackPrice = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 12);
        public static readonly UpdateField buybackTimestamp = new UpdateField(typeof(long[]), UpdateFieldFlag.None, 12);
        public static readonly UpdateField todayHonorableKills = new UpdateField(typeof(ushort), UpdateFieldFlag.None);
        public static readonly UpdateField yesterdayHonorableKills = new UpdateField(typeof(ushort), UpdateFieldFlag.None);
        public static readonly UpdateField lifetimeHonorableKills = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField watchedFactionIndex = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField combatRatings = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 32);
        public static readonly UpdateField pvpInfo = new UpdateField(typeof(DynamicUpdateField<JamMirrorPVPInfo_C>), UpdateFieldFlag.None);
        public static readonly UpdateField maxLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField scalingPlayerLevelDelta = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField maxCreatureScalingLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField noReagentCostMask = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 4);
        public static readonly UpdateField petSpellPower = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField professionSkillLine = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 2);
        public static readonly UpdateField uiHitModifier = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField uiSpellHitModifier = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField homeRealmTimeOffset = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField modPetHaste = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField jailersTowerLevelMax = new UpdateField(typeof(sbyte), UpdateFieldFlag.None);
        public static readonly UpdateField jailersTowerLevel = new UpdateField(typeof(sbyte), UpdateFieldFlag.None);
        public static readonly UpdateField localRegenFlags = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField auraVision = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField numBackpackSlots = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField overrideSpellsID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField lootSpecID = new UpdateField(typeof(ushort), UpdateFieldFlag.None);
        public static readonly UpdateField overrideZonePVPType = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField bnetAccount = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField guildClubMemberID = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField bagSlotFlags = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 5);
        public static readonly UpdateField bankBagSlotFlags = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 7);
        public static readonly UpdateField questCompleted = new UpdateField(typeof(ulong[]), UpdateFieldFlag.None, 875);
        public static readonly UpdateField honor = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField honorNextLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField perksProgramCurrency = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField numBankSlots = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField dailyQuestsCompleted = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField availableQuestLineXQuestIDs = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField heirlooms = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField heirloomFlags = new UpdateField(typeof(DynamicUpdateField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField toys = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField toyFlags = new UpdateField(typeof(DynamicUpdateField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField transmog = new UpdateField(typeof(DynamicUpdateField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField conditionalTransmog = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField selfResSpells = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField runeforgePowers = new UpdateField(typeof(DynamicUpdateField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField transmogIllusions = new UpdateField(typeof(DynamicUpdateField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField characterRestrictions = new UpdateField(typeof(DynamicUpdateField<JamMirrorCharacterRestriction_C>), UpdateFieldFlag.None);
        public static readonly UpdateField spellPctModByLabel = new UpdateField(typeof(DynamicUpdateField<JamMirrorSpellPctModByLabel_C>), UpdateFieldFlag.None);
        public static readonly UpdateField spellFlatModByLabel = new UpdateField(typeof(DynamicUpdateField<JamMirrorSpellFlatModByLabel_C>), UpdateFieldFlag.None);
        public static readonly UpdateField researchHistory = new UpdateField(typeof(JamMirrorResearchHistory_C), UpdateFieldFlag.None);
        public static readonly UpdateField mawPowers = new UpdateField(typeof(DynamicUpdateField<JamMirrorMawPower_C>), UpdateFieldFlag.None);
        public static readonly UpdateField multiFloorExploration = new UpdateField(typeof(DynamicUpdateField<JamMirrorMultiFloorExplore_C>), UpdateFieldFlag.None);
        public static readonly UpdateField recipeProgression = new UpdateField(typeof(DynamicUpdateField<JamMirrorRecipeProgressionInfo_C>), UpdateFieldFlag.None);
        public static readonly UpdateField frozenPerksVendorItem = new UpdateField(typeof(PerksVendorItem), UpdateFieldFlag.None);
        public static readonly UpdateField questSessionExists = new UpdateField(typeof(BlzOptionalField<JamMirrorQuestSession_C>), UpdateFieldFlag.None, typeof(CGActivePlayerData).GetField("questSession", BindingFlags.Static | BindingFlags.Public), bitSize: 1);
        public static readonly UpdateField field_1410 = new UpdateField(typeof(JamMirrorActivePlayerUnk901_C), UpdateFieldFlag.None);
        public static readonly UpdateField questSession = new UpdateField(typeof(BlzOptionalField<JamMirrorQuestSession_C>), UpdateFieldFlag.None);
        public static readonly UpdateField replayedQuests = new UpdateField(typeof(DynamicUpdateField<JamMirrorReplayedQuest_C>), UpdateFieldFlag.None);
        public static readonly UpdateField taskQuests = new UpdateField(typeof(DynamicUpdateField<JamMirrorQuestLog_C>), UpdateFieldFlag.None);
        public static readonly UpdateField disabledSpells = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField uiChromieTimeExpansionID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField transportServerTime = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField weeklyRewardsPeriodSinceOrigin = new UpdateField(typeof(uint), UpdateFieldFlag.None, comment: "week count since Cfg_RegionsEntry::ChallengeOrigin");
        public static readonly UpdateField DEBUGSoulbindConduitRank = new UpdateField(typeof(short), UpdateFieldFlag.None);
        public static readonly UpdateField dungeonScore = new UpdateField(typeof(DungeonScoreData), UpdateFieldFlag.None);
        public static readonly UpdateField traitConfigs = new UpdateField(typeof(DynamicUpdateField<JamMirrorTraitConfig_C>), UpdateFieldFlag.None);
        public static readonly UpdateField activeCombatTraitConfigID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField craftingOrders = new UpdateField(typeof(DynamicUpdateField<JamMirrorCraftingOrder_C>), UpdateFieldFlag.None);
        public static readonly UpdateField personalCraftingOrderCounts = new UpdateField(typeof(DynamicUpdateField<JamMirrorPersonalCraftingOrderCount_C>), UpdateFieldFlag.None);
        public static readonly UpdateField categoryCooldownMods = new UpdateField(typeof(DynamicUpdateField<JamMirrorCategoryCooldownMod_C>), UpdateFieldFlag.None);
        public static readonly UpdateField weeklySpellUses = new UpdateField(typeof(DynamicUpdateField<JamMirrorWeeklySpellUse_C>), UpdateFieldFlag.None);
        public static readonly UpdateField itemUpgradeHighWatermark = new UpdateField(typeof(float[]), UpdateFieldFlag.None, 17);
        public static readonly UpdateField itemUpgradeHighOnehandWeaponItemID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField itemUpgradeHighFingerItemID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField itemUpgradeHighFingerWatermark = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField itemUpgradeHighTrinketItemID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField itemUpgradeHighTrinketWatermark = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField lootHistoryInstanceID = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField petStableExists = new UpdateField(typeof(BlzOptionalField<JamMirrorStableInfo_C>), UpdateFieldFlag.None, typeof(CGActivePlayerData).GetField("petStable", BindingFlags.Static | BindingFlags.Public), bitSize: 1);
        public static readonly UpdateField petStable = new UpdateField(typeof(BlzOptionalField<JamMirrorStableInfo_C>), UpdateFieldFlag.None);
        public static readonly UpdateField trackedCollectableSources = new UpdateField(typeof(DynamicUpdateField<JamMirrorCollectableSourceTrackedData_C>), UpdateFieldFlag.None);
        public static readonly UpdateField requiredMountCapabilityFlags = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField backpackAutoSortDisabled = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField backpackSellJunkDisabled = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField bankAutoSortDisabled = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField sortBagsRightToLeft = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField insertItemsLeftToRight = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField hasPerksProgramPendingReward = new UpdateField(typeof(bool), UpdateFieldFlag.None);
        public static readonly UpdateField researchSites = new UpdateField(typeof(DynamicUpdateField<ushort>[]), UpdateFieldFlag.None, 1);
        public static readonly UpdateField researchSiteProgress = new UpdateField(typeof(DynamicUpdateField<uint>[]), UpdateFieldFlag.None, 1);
        public static readonly UpdateField research = new UpdateField(typeof(DynamicUpdateField<JamMirrorResearch_C>[]), UpdateFieldFlag.None, 1);
    }
}
