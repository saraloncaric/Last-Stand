using UnityEngine;

public class DeploymentSystem : MonoBehaviour
{
    public EconomyManager economy;
    public GameObject vojnik;
    public Transform[] lokacije;
    public int cijenaVojnika = 10;

    private int trenutnaLokcija = 0;
    public void DeployUnit() {
        if(economy.coins >= cijenaVojnika) {
            if(trenutnaLokcija < lokacije.Length) {
                Instantiate(vojnik, lokacije[trenutnaLokcija].position, lokacije[trenutnaLokcija].rotation);
                economy.coins -= cijenaVojnika;
                trenutnaLokcija++;
                Debug.Log("Vojnik postavljen, ostala mjesta: " + (lokacije.Length + trenutnaLokcija));
            } else {
                Debug.Log("Toranj je pun");
            }
        } else {
            Debug.Log("Nemaš dovoljno coinsa za vojnika");
        }
    }
}