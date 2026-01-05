using Robust.Shared.Serialization;

namespace Content.Shared._Utopia.ModSuits;

[Serializable, NetSerializable]
public sealed class ToggleModSuitPartMessage : BoundUserInterfaceMessage
{
    public NetEntity PartEntity;

    public ToggleModSuitPartMessage(NetEntity partEntity)
    {
        PartEntity = partEntity;
    }
}
