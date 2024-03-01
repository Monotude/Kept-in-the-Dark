using UnityEngine;

public class PlayerVisibility : MonoBehaviour
{
    private PlayerFlashlight playerFlashlight;
    private PlayerUVLight playerUVLight;
    private Light playerVisibilityLight;

    private void Start()
    {
        playerFlashlight = GameObject.FindWithTag("Flashlight Light").GetComponent<PlayerFlashlight>();
        playerUVLight = GameObject.FindWithTag("UV Light").GetComponent<PlayerUVLight>();
        playerVisibilityLight = GetComponent<Light>();
    }

    private void Update()
    {
        playerVisibilityLight.enabled = !playerFlashlight.IsFlashlightOn && !playerUVLight.IsUVLightOn;
    }
}
