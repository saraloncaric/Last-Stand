using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GamePhase { Priprema, Val, GameOver }
    public GamePhase trenutnafaza;
    public EconomyManager economy;
    void Start() {
        trenutnafaza = GamePhase.Priprema;
        Debug.Log("Faza pripreme! Potroši svoje coinse mudro.");
    }
    public void StartVal() {
        if(trenutnafaza == GamePhase.Priprema) {
            trenutnafaza = GamePhase.Val;
            Debug.Log("Val počinje! Neprijatelji napadaju.");
        }
    }
    public void TriggerGameOver() {
        trenutnafaza = GamePhase.GameOver;
        Debug.Log("Glavni toranj je pao. Game Over!");
    }
}
