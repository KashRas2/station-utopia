namespace Content.Shared.Utopia.Language;

[ByRefEvent]
public record struct GetLanguagesEvent(EntityUid Uid)
{
    public string Current = default!;
    public Dictionary<string, LanguageKnowledge> Languages = [];
    public Dictionary<string, LanguageKnowledge> Translator = [];
}
