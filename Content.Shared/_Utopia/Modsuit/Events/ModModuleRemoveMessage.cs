using Robust.Shared.Serialization;

namespace Content.Shared._Utopia.ModSuits;

[Serializable, NetSerializable]
public sealed class ModModuleRemoveMessage : BoundUserInterfaceMessage
{
    public NetEntity Module;

    public ModModuleRemoveMessage(NetEntity module)
    {
        Module = module;
    }
}
