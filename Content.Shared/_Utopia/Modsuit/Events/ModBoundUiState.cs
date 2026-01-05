using Robust.Shared.Serialization;

namespace Content.Shared._Utopia.ModSuits;

[Serializable, NetSerializable]
public sealed class ModBoundUiState : BoundUserInterfaceState
{
    public Dictionary<NetEntity, bool> EquipmentStates = new();
}

[Serializable, NetSerializable]
public sealed class RadialModBoundUiState : BoundUserInterfaceState;
