using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPanel;
    public PanelNavigacija panelNavigacija;

    void Start() {
        menuPanel.SetActive(false);
    }

    public void ToggleMenu() {
        bool trebaOtvoriti = !menuPanel.activeSelf;
        menuPanel.SetActive(trebaOtvoriti);
        if (trebaOtvoriti) {
            panelNavigacija.PrikaziGlavniMeni();
        }
    }
}