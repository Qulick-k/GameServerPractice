using _Scripts;
using SharedLibrary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        //The localhost 's portnumber may vary each time, it is better to check the port number before running the game.
        var player = await HttpClient.Get<Player>("https://localhost:7289/player/500");
        Debug.Log(player.Id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
