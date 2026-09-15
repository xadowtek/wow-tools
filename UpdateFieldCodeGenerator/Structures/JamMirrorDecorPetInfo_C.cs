using System.Reflection;

namespace UpdateFieldCodeGenerator.Structures
{
    [HasChangesMask(blockGroupSize: -1)]
    public class JamMirrorDecorPetInfo_C
    {
        public static readonly UpdateField m_battlePetGUID = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField m_spawnGroup = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField m_spawnedPet = new UpdateField(typeof(WowGuid), UpdateFieldFlag.None);
        public static readonly UpdateField m_creatureID = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField m_petNameLength = new UpdateField(typeof(string), UpdateFieldFlag.None, typeof(JamMirrorDecorPetInfo_C).GetField("m_petName", BindingFlags.Static | BindingFlags.Public), bitSize: 6);
        public static readonly UpdateField m_petBehavior = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField m_petName = new UpdateField(typeof(string), UpdateFieldFlag.None);
    }
}
