using TMPro;
using UnityEngine;

public class SpeedDisplayer1 : MonoBehaviour
{

    private Rigidbody2D playerRigidbody;
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    private void Start()
    {
        var player = GameObject.FindWithTag("Player");
        playerRigidbody = player.GetComponent<Rigidbody2D>();
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textMeshPro.text = playerRigidbody.velocity.magnitude.ToString();
    }
}
