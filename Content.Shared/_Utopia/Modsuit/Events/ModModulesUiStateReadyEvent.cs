using Robust.Shared.Serialization;

namespace Content.Shared._Utopia.ModSuits;

public sealed class ModModulesUiStateReadyEvent : EntityEventArgs
{
    public Dictionary<NetEntity, BoundUserInterfaceState?> States = new();  // ADT Mech UI Fix
}
