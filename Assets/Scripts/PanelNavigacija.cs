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
        Debug.Log("PrikaziHealth pozvan! MenuPanel aktivan: " + transform.parent?.gameObject.activeSelf);
        glavniMeniPanel.SetActive(false);
        healthPanel.SetActive(true);
        lokacijePanel.SetActive(false);
    }

    public void PrikaziLokacije() {
        Debug.Log("PrikaziLokacije pozvan! MenuPanel aktivan: " + transform.parent?.gameObject.activeSelf);
        glavniMeniPanel.SetActive(false);
        healthPanel.SetActive(false);
        lokacijePanel.SetActive(true);
    }
}