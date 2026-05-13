using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPanel;

    void Start() {
        menuPanel.SetActive(false);
    }
    public void ToggleMenu() {
        menuPanel.SetActive(!menuPanel.activeSelf);
    }
}
