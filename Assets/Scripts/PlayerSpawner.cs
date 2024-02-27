using Unity.Netcode;
using UnityEngine;


public class PlayerSpawner : NetworkBehaviour
{
    public GameObject playerPrefab; // Assign your player prefab in the inspector
    public Transform[] spawnPoints; // Assign your two spawn points in the inspector
    public Goal[] goals; // Add an array to reference goals


    public override void OnNetworkSpawn()
    {
        if (IsServer) // Only the server should execute the spawn logic
        {
            SpawnPlayers();
        }
    }

    private void SpawnPlayers()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            // Instantiate the player at the spawn point
            GameObject playerInstance = Instantiate(playerPrefab, spawnPoints[i].position, spawnPoints[i].rotation);

            // Spawn the player on the network
            playerInstance.GetComponent<NetworkObject>().Spawn();
            goals[i].associatedPlayer = playerInstance.GetComponent<CubeController>();
        
            // Optionally, assign the player to a client here if needed
        }
    }
}
