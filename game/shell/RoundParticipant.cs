using Godot;
using GameFactory.Networking.Objects;
using GameFactory.Networking.Players;

namespace MultiplayerCave.Shell;

/// <summary>Represents a session player in the round before the diver scene exists.</summary>
public partial class RoundParticipant : Node, INetworkSpawnInitializable
{
    public PlayerId SessionPlayerId { get; private set; }

    public void ApplyNetworkSpawnData(Variant data)
    {
        SessionPlayerId = new PlayerId(data.AsGodotDictionary()["player_id"].AsInt64());
    }
}
