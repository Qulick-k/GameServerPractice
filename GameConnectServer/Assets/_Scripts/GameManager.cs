using _Scripts;
using SharedLibrary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var player = await HttpClient.Get<Player>("http://localhost:5000/player/500");
        Debug.Log(player.Id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
