using Godot;
using GameFactory.Networking.Peers;
using GameFactory.Networking.Players;
using GameFactory.Shell;

namespace MultiplayerCave.Shell;

public partial class ParticipantSpawnDataProvider : Node, IPlayerSpawnDataProvider
{
    public Godot.Collections.Dictionary CreateSpawnData(NetworkPeer peer, PlayerId playerId) => new()
    {
        ["player_id"] = playerId.Value
    };
}
