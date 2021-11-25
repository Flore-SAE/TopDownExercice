using TMPro;
using UnityEngine;

public class SpeedDisplayer2 : MonoBehaviour
{
    public PlayerSpeedTunnel playerSpeed;

    private TextMeshProUGUI textMeshPro;

    private void OnEnable()
    {
        playerSpeed.speedDisplayer = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(float speed)
    {
        textMeshPro.text = speed.ToString();
    }

    private void OnDisable()
    {
        playerSpeed.speedDisplayer = null;
    }
}
