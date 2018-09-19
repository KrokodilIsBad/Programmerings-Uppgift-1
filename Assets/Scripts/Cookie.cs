using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{

    public GameObject miniCookie;
    public bool canClick = true;

    protected GameObject miniCookieStorage;

    private void Start()
    {
        miniCookieStorage = GameObject.FindGameObjectWithTag("Mini Cookie Storage");
    }

    public virtual void OnMouseDown()
    {
        Data.cookies += Data.cookiesPerClick;
        GameObject miniCookieClone = Instantiate(miniCookie, miniCookieStorage.transform);
        miniCookieClone.transform.position = new Vector2(Random.Range(transform.position.x - transform.localScale.x / 2, transform.position.x + transform.localScale.x / 2), Random.Range(transform.position.y - transform.localScale.y / 2, transform.position.y + transform.localScale.y / 2));
    }
}
