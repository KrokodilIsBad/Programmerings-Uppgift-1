using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCookies : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(new Vector2(0, 0.01f));
        transform.Rotate(new Vector3(0, 0, 1));
        if (transform.localScale.x > 0)
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0f);
        }
        StartCoroutine(disappear(3));
    }

    IEnumerator disappear(int delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
