using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCookie : Cookie
{
    [Range(-Mathf.Infinity, Mathf.Infinity)]
    public float timer = Data.goldCookieTimeInSeconds;

    private void Start()
    {
        timer = Data.goldCookieTimeInSeconds;
        miniCookieStorage = GameObject.FindGameObjectWithTag("Mini Cookie Storage");
    }

    public override void OnMouseDown()
    {
        Data.cookies += Data.cookiesPerClick * Data.goldCookieMultiplier;
        GameObject miniCookieClone = Instantiate(miniCookie, miniCookieStorage.transform);
        miniCookieClone.transform.position = new Vector2(Random.Range(transform.position.x - transform.localScale.x / 2, transform.position.x + transform.localScale.x / 2), Random.Range(transform.position.y - transform.localScale.y / 2, transform.position.y + transform.localScale.y / 2));
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
