using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text scoreText, pickupText, highScoreText, highPickupText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.instance.score.ToString();
        pickupText.text = GameManager.instance.pickup.ToString();

        highPickupText.text = GameManager.instance.highPickup.ToString();
        highScoreText.text = GameManager.instance.highScore.ToString();
    }
}
