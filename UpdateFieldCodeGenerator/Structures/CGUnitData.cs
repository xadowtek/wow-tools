﻿using System.Reflection;

namespace UpdateFieldCodeGenerator.Structures
{
    [HasChangesMask]
    [HasMutableInterface]
    class CGUnitData
    {
        public static readonly ObjectType ObjectType = ObjectType.Unit;

        public static readonly UpdateField displayID = new UpdateField(typeof(int), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField npcFlags = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 2, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField stateSpellVisualID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField stateAnimID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField stateAnimKitID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField stateWorldEffectIDsSize = new UpdateField(typeof(BlzVectorField<uint>), UpdateFieldFlag.None, typeof(CGUnitData).GetField("stateWorldEffectIDs", BindingFlags.Static | BindingFlags.Public));
        public static readonly UpdateField stateWorldEffectsQuestObjectiveID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField spellOverrideNameID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField stateWorldEffectIDs = new UpdateField(typeof(BlzVectorField<uint>), UpdateFieldFlag.None);
        public static readonly UpdateField charm = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField summon = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField critter = new UpdateField(typeof(WowGuid), UpdateFieldFlag.Owner);
        public static readonly UpdateField charmedBy = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField summonedBy = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField createdBy = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField demonCreator = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField lookAtControllerTarget = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField target = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField battlePetCompanionGUID = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField battlePetDBID = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField channelData = new UpdateField(typeof(JamMirrorUnitChannel_C), UpdateFieldFlag.None);
        public static readonly UpdateField spellEmpowerStage = new UpdateField(typeof(sbyte), UpdateFieldFlag.None);
        public static readonly UpdateField summonedByHomeRealm = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField race = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField classId = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField playerClassId = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField sex = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField displayPower = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField overrideDisplayPowerID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField health = new UpdateField(typeof(long), UpdateFieldFlag.None);
        public static readonly UpdateField power = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 10);
        public static readonly UpdateField maxPower = new UpdateField(typeof(int[]), UpdateFieldFlag.None, 10);
        public static readonly UpdateField powerRegenFlatModifier = new UpdateField(typeof(float[]), UpdateFieldFlag.Owner | UpdateFieldFlag.UnitAll, 10);
        public static readonly UpdateField powerRegenInterruptedFlatModifier = new UpdateField(typeof(float[]), UpdateFieldFlag.Owner | UpdateFieldFlag.UnitAll, 10);
        public static readonly UpdateField maxHealth = new UpdateField(typeof(long), UpdateFieldFlag.None);
        public static readonly UpdateField level = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField effectiveLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField contentTuningID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField scalingLevelMin = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField scalingLevelMax = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField scalingLevelDelta = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField scalingFactionGroup = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField factionTemplate = new UpdateField(typeof(int), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField virtualItems = new UpdateField(typeof(JamMirrorVisibleItem_C[]), UpdateFieldFlag.None, 3);
        public static readonly UpdateField flags = new UpdateField(typeof(uint), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField flags2 = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField flags3 = new UpdateField(typeof(uint), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField auraState = new UpdateField(typeof(uint), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField attackRoundBaseTime = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 2);
        public static readonly UpdateField rangedAttackRoundBaseTime = new UpdateField(typeof(uint), UpdateFieldFlag.Owner);
        public static readonly UpdateField boundingRadius = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField combatReach = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField displayScale = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField creatureFamily = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField creatureType = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField nativeDisplayID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField nativeXDisplayScale = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField mountDisplayID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField cosmeticMountDisplayID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField minDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner | UpdateFieldFlag.Empath);
        public static readonly UpdateField maxDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner | UpdateFieldFlag.Empath);
        public static readonly UpdateField minOffHandDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner | UpdateFieldFlag.Empath);
        public static readonly UpdateField maxOffHandDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner | UpdateFieldFlag.Empath);
        public static readonly UpdateField standState = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField petTalentPoints = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField visFlags = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField animTier = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField petNumber = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField petNameTimestamp = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField petExperience = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField petNextLevelExperience = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField modCastingSpeed = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modCastingSpeedNeg = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modSpellHaste = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modHaste = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modRangedHaste = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modHasteRegen = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField modTimeRate = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField createdBySpell = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField emoteState = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField stats = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 4);
        public static readonly UpdateField statPosBuff = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 4);
        public static readonly UpdateField statNegBuff = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 4);
        public static readonly UpdateField statSupportBuff = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 4);
        public static readonly UpdateField resistances = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner | UpdateFieldFlag.Empath, 7);
        public static readonly UpdateField bonusResistanceMods = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 7);
        public static readonly UpdateField manaCostModifier = new UpdateField(typeof(int[]), UpdateFieldFlag.Owner, 7);
        public static readonly UpdateField baseMana = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField baseHealth = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField sheatheState = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField pvpFlags = new UpdateField(typeof(byte), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField petFlags = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField shapeshiftForm = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField attackPower = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField attackPowerModPos = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField attackPowerModNeg = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField attackPowerMultiplier = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField attackPowerModSupport = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedAttackPower = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedAttackPowerModPos = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedAttackPowerModNeg = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedAttackPowerMultiplier = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedAttackPowerModSupport = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField mainHandWeaponAttackPower = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField offHandWeaponAttackPower = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField rangedWeaponAttackPower = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField setAttackSpeedAura = new UpdateField(typeof(int), UpdateFieldFlag.Owner);
        public static readonly UpdateField lifesteal = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField minRangedDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField maxRangedDamage = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField manaCostMultiplier = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField maxHealthModifier = new UpdateField(typeof(float), UpdateFieldFlag.Owner);
        public static readonly UpdateField hoverHeight = new UpdateField(typeof(float), UpdateFieldFlag.None);
        public static readonly UpdateField minItemLevelCutoff = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField minItemLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField maxItemLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField azeriteItemLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField wildBattlePetLevel = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField battlePetCompanionExperience = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField battlePetCompanionNameTimestamp = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField interactSpellID = new UpdateField(typeof(int), UpdateFieldFlag.None, customFlag: CustomUpdateFieldFlag.ViewerDependent);
        public static readonly UpdateField scaleDuration = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField looksLikeMountID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField looksLikeCreatureID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField lookAtControllerID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField perksVendorItemID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField taxiNodesID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField guildGUID = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField passiveSpells = new UpdateField(typeof(DynamicUpdateField<JamMirrorPassiveSpellHistory_C>), UpdateFieldFlag.None);
        public static readonly UpdateField worldEffects = new UpdateField(typeof(DynamicUpdateField<int>), UpdateFieldFlag.None);
        public static readonly UpdateField channelObjects = new UpdateField(typeof(DynamicUpdateField<WowGuid>), UpdateFieldFlag.None);
        public static readonly UpdateField flightCapabilityID = new UpdateField(typeof(int), UpdateFieldFlag.None);
        public static readonly UpdateField glideEventSpeedDivisor = new UpdateField(typeof(float), UpdateFieldFlag.None, comment: "Movement speed gets divided by this value when evaluating what GlideEvents to use");
        public static readonly UpdateField field_308 = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField field_30C = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField silencedSchoolMask = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField currentAreaID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField nameplateAttachToGUID = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None, comment: "When set, nameplate of this unit will instead appear on that object");
    }
}
