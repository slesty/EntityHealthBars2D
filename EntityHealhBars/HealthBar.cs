using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject healthBarUI;
    public Slider slider;
    public Entity owner;

    void Update()
    {

        Player player = Player.localPlayer;
        if (player != null)

        {
            //Health
            slider.value = owner.HealthPercent();
            if (slider.value == 1)
            {
                healthBarUI.SetActive(true);
            }
            if (slider.value == 0)
            {
                healthBarUI.SetActive(false);
            }
                
        }

    }
}




            

        
   

