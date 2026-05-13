using UnityEngine;

public class PanelNavigacija : MonoBehaviour
{
    public GameObject glavniMeniPanel;
    public GameObject healthPanel;
    public GameObject lokacijePanel;

    void Start() {
        glavniMeniPanel.SetActive(false);
        healthPanel.SetActive(false);
        lokacijePanel.SetActive(false);
    }

    public void PrikaziGlavniMeni() {
        glavniMeniPanel.SetActive(true);
        healthPanel.SetActive(false);
        lokacijePanel.SetActive(false);
    }

    public void PrikaziHealth() {
        glavniMeniPanel.SetActive(false);
        healthPanel.SetActive(true);
        lokacijePanel.SetActive(false);
    }

    public void PrikaziLokacije() {
        glavniMeniPanel.SetActive(false);
        healthPanel.SetActive(false);
        lokacijePanel.SetActive(true);
    }
}