using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DeploymentSystem : MonoBehaviour
{
    [System.Serializable]
    public class Lokacija
    {
        public string naziv;
        public Transform spawnPoint;
        public bool zauzeto;
    }

    public EconomyManager economy;
    public GameObject vojnikPrefab;
    public Lokacija[] lokacije;
    public int cijenaVojnika = 1;

    public GameObject gumbPrefab;
    public Transform gumbContainer;

    void Start() {
        PrikaziLokacije();
    }

    public void PrikaziLokacije() {
        foreach (Transform child in gumbContainer)
            Destroy(child.gameObject);

        for (int i = 0; i < lokacije.Length; i++)
        {
            int index = i;
            GameObject gumb = Instantiate(gumbPrefab, gumbContainer);
            string status = lokacije[i].zauzeto ? " (zauzeto)" : " (slobodno)";
            gumb.GetComponentInChildren<TextMeshProUGUI>().text = lokacije[i].naziv + status;
            gumb.GetComponent<Button>().onClick.AddListener(() => PostaviVojnika(index));
        }
    }

    public void PostaviVojnika(int index) {
        if (lokacije[index].zauzeto) {
            Debug.Log("Lokacija je zauzeta!");
            return;
        }
        if (economy.coins < cijenaVojnika) {
            Debug.Log("Nema dovoljno coinsa!");
            return;
        }
        economy.coins -= cijenaVojnika;
        Instantiate(vojnikPrefab, lokacije[index].spawnPoint.position, lokacije[index].spawnPoint.rotation);
        lokacije[index].zauzeto = true;
        PrikaziLokacije();
    }
}