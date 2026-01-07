namespace Content.Server.Utopia.Chat;

[ByRefEvent]
public record struct CanHearVoiceEvent(EntityUid Source, bool Whisper, bool Cancelled = false);
