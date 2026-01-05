using Robust.Shared.Serialization;

namespace Content.Shared._Utopia.ModSuits;

[Serializable, NetSerializable]
public sealed class ModModuleActivateMessage : BoundUserInterfaceMessage
{
    public NetEntity Module;

    public ModModuleActivateMessage(NetEntity module)
    {
        Module = module;
    }
}
