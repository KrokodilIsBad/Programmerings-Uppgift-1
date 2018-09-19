using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public bool goldCookieActivated;

    public Text textCookies;
    public GameObject cookie;
    public GameObject goldenCookie;

    public Texture2D cursor;

    private float cheatCooldown;

    private void Start()
    {
        //cursor.Resize(10, 20);
        //Cursor.SetCursor(cursor, new Vector2(125,25), CursorMode.ForceSoftware);
    }

    private void Update()
    {
        textCookies.text = Data.cookies.ToString();

        if (cheatCooldown > 0f)
        {
            cheatCooldown -= 0.01f;
        }
        if (goldCookieActivated)
        {
            if (GameObject.Find("Cartoon Cookie"))
            {
                Destroy(GameObject.Find("Cartoon Cookie"));
                Instantiate(goldenCookie).name = "Gold Cookie";
                textCookies.color = Color.yellow;
                goldCookieActivated = false;
            }
        }
        else
        {
            if (!GameObject.Find("Gold Cookie") && !GameObject.Find("Cartoon Cookie"))
            {
                Instantiate(cookie).name = "Cartoon Cookie";
                textCookies.color = Color.white;
            }
        }

        if (Input.GetKey(KeyCode.V) && Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.K))
        {
            if (cheatCooldown <= 0f)
            {
                cheatCooldown = 15f;
                goldCookieActivated = true;
            }
        }
    }

}
