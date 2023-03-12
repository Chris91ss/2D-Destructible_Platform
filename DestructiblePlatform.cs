using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePlatform : MonoBehaviour
{
    public float timeUntilDestruction;
    public float timeUntilRespawn;

    private GameObject platform;

    private void Awake()
    {
        platform = GameObject.Find("DestructiblePlatform/Platform/Group");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            StartCoroutine(DisablePlatform());
        }
    }

    private IEnumerator DisablePlatform()
    {
        yield return new WaitForSeconds(timeUntilDestruction);

        platform.SetActive(false);
        StartCoroutine(EnablePlatform());
    }

    private IEnumerator EnablePlatform()
    {
        yield return new WaitForSeconds(timeUntilRespawn);

        platform.SetActive(true);
    }
}
