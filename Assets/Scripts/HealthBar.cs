using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    Sprite currentSprite;
    GameObject currentGameObject;
    public float alphaTransparent = 0.5f;
    public float alphaNonTransparent = 1f;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        currentGameObject = gameObject;
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alphaTransparent);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alphaNonTransparent);
    }

    // Update is called once per frame
    void Update()
    {
        currentSprite = sprites[player.GetHealth()];
        this.gameObject.GetComponent<SpriteRenderer>().sprite = currentSprite;
    }
}
