using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour {
    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public GameObject NextBall;
    GameObject[] Top;
    private bool isPressed = false;
    public float releaseTime = .15f;
    public float maxDragDistance = 2f;
    public static int atilanTop = 0;
    private void Start()
    {
        Time.timeScale = 1;
        
        
        /*sonTop = GameObject.FindGameObjectWithTag("Player2");
        sonTop.SetActive(false);*/
    }
    private void Update()
    {
        
        /* #region pc
         if (isPressed)
         {
             Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             if (Vector3.Distance(mousePos, hook.position) > maxDragDistance) rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
             else rb.position = mousePos;
         }
         #endregion*/
        #region Mobile
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance) rb.position = hook.position + (mousePos-hook.position).normalized * maxDragDistance;
            else rb.position = mousePos;
        }
        #endregion
       
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        atilanTop++;

    }
    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        
        this.enabled = false;
        yield return new WaitForSeconds(6f);
        
        if (NextBall != null) { NextBall.SetActive(true); }
        else
        {
            enemy.EnemyAlive = 0;
                SceneManager.LoadScene("Restart");
            
        }
    }
    public void replay()
    {
        enemy.EnemyAlive = 0;
        atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
