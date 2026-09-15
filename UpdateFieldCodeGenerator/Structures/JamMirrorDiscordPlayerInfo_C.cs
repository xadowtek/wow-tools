using System.Reflection;

namespace UpdateFieldCodeGenerator.Structures
{
    public class JamMirrorDiscordPlayerInfo_C
    {
        public static readonly UpdateField m_accessTokenLength = new UpdateField(typeof(DynamicString), UpdateFieldFlag.None, typeof(JamMirrorDiscordPlayerInfo_C).GetField("m_accessToken", BindingFlags.Static | BindingFlags.Public), bitSize: 24);
        public static readonly UpdateField m_discordUserID = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField m_accountType = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField m_guildLobbyID = new UpdateField(typeof(ulong), UpdateFieldFlag.None);
        public static readonly UpdateField m_guildSettings = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField m_displayNameType = new UpdateField(typeof(byte), UpdateFieldFlag.None);
        public static readonly UpdateField m_accessToken = new UpdateField(typeof(DynamicString), UpdateFieldFlag.None);
    }
}
