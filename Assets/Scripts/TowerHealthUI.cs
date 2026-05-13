using UnityEngine;
using TMPro;

public class TowerHealthUI : MonoBehaviour
{
    public Health glavniToranj;
    public Health[] zidovi;
    public Health lijeviBocniToranj;
    public Health desniBocniToranj;

    public TextMeshProUGUI glavniToranjText;
    public TextMeshProUGUI zidoviText;
    public TextMeshProUGUI lijeviToranjText;
    public TextMeshProUGUI desniToranjText;

    public EconomyManager economy;
    public int cijenaPopravka = 4;

    void Update()
    {
        if (glavniToranj != null)
            glavniToranjText.text = "Glavni toranj: " + glavniToranj.currentHealth + "/" + glavniToranj.maxHealth;

        if (zidovi.Length > 0)
            zidoviText.text = "Zidovi: " + zidovi[0].currentHealth + "/" + zidovi[0].maxHealth;

        if (lijeviBocniToranj != null)
            lijeviToranjText.text = "Lijevi toranj: " + lijeviBocniToranj.currentHealth + "/" + lijeviBocniToranj.maxHealth;

        if (desniBocniToranj != null)
            desniToranjText.text = "Desni toranj: " + desniBocniToranj.currentHealth + "/" + desniBocniToranj.maxHealth;
    }

    public void RepairAll()
    {
        if (economy.coins < cijenaPopravka) return;
        economy.coins -= cijenaPopravka;

        if (glavniToranj != null)
            glavniToranj.currentHealth = glavniToranj.maxHealth;

        foreach (var z in zidovi)
            z.currentHealth = z.maxHealth;

        if (lijeviBocniToranj != null)
            lijeviBocniToranj.currentHealth = lijeviBocniToranj.maxHealth;

        if (desniBocniToranj != null)
            desniBocniToranj.currentHealth = desniBocniToranj.maxHealth;
    }
}