using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerManager : NetworkBehaviour
{
    private static int playerCount = 0;

    public static int GetNextPlayerNumber()
    {
        // Increment player count and return it
        return ++playerCount;
    }

    // Optional: Reset player count when game restarts or ends
    public static void ResetPlayerCount()
    {
        playerCount = 0;
    }
    /*

    // Make sure to reset player count when the server starts
    public override void OnNetworkSpawn()
    {
        if (IsServer && IsOwner)
        {
            ResetPlayerCount();
        }
    }*/
}
