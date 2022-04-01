using UnityEngine;
using UnityEngine.Events;

public class GameRules : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private ScoreCounter scoreBid;


    public UnityEvent startGameEvent;
    public UnityEvent stopGameEvent;
    public UnityEvent betPlayedEvent;
    public UnityEvent betNotPlayedEvent;

    public void StartGame()
    {
        CompareResults();
        startGameEvent?.Invoke();
    }




    public void StopGame()
    {
        stopGameEvent?.Invoke();
    }

    private void CompareResults()
    {
        

        float yourBid = scoreBid.Score > scoreCounter.Score ? scoreCounter.Score : scoreBid.Score;
        

        if (Random.Range(0,2) == 1)
        {
            scoreCounter.add(yourBid);
            betPlayedEvent?.Invoke();
        }
        else
        {
            scoreCounter.takeAway(yourBid);
            betNotPlayedEvent?.Invoke();
        }
    }
}
