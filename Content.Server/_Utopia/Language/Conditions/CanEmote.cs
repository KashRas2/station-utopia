using Content.Shared.ActionBlocker;
using Robust.Shared.Prototypes;
using Content.Shared.Utopia.Language;

namespace Content.Server.Utopia.Language;

[DataDefinition]
public sealed partial class CanEmote : ILanguageCondition
{
    public ProtoId<LanguagePrototype> Language { get; set; }

    [DataField]
    public bool RaiseOnListener { get; set; } = false;

    public bool Condition(EntityUid targetEntity, EntityUid? source, IEntityManager entMan)
    {
        var blocker = entMan.System<ActionBlockerSystem>();
        return blocker.CanEmote(targetEntity);
    }
}
