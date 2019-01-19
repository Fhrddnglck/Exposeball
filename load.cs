using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        Ads.instance.RequestFullScreenAd();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    public void loadScene()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.RequestFullScreenAd();
        SceneManager.LoadScene("MainMenu");
    }
    public void start_menu_play()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.RequestFullScreenAd();
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void level1()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();

        SceneManager.LoadScene("Level1");
    }
    public void level2()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        SceneManager.LoadScene("Level2");
    }
    public void level3()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        SceneManager.LoadScene("Level3");
    }
    public void level4()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        SceneManager.LoadScene("Level4");
    }
    public void level5()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        SceneManager.LoadScene("Level5");
    }
    public void Level_Cloud()
    {
        enemy.EnemyAlive = 0;
        ball.atilanTop = 0;
        Ads.instance.ShowFullScreenAd();
        SceneManager.LoadScene("LevelCloud");
    }

}
