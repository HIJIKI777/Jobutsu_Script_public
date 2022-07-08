using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;
    //high* は一度に加算されるスコアの量
    public int high = 1;
    public int high2 = 4;
    public int high3 = 5;
    public int high4 = 40;
    public int high5 = 50;
    public int high6 = 100;

    public int FlyingTime;
    public PlayerScript playerscript;           //プレイヤー
    private float currentTime = 0f;
    public float span = 1f;

    // Start is called before the first frame update
    void Start()
    {
        FlyingTime = 0;         //スコア初期化
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        //spanにて設定した値を超える毎に，タイマーを0秒に戻し，スコアを加算する．
        //ステージごとに一度に加算する値を変更する
        if(currentTime > span && playerscript.GameOverFlag == false){
            currentTime = 0f;
            if(FlyingTime >= 0 && FlyingTime < 100){
                FlyingTime = FlyingTime + high;
            }else if(FlyingTime >= 100 && FlyingTime < 500){
                FlyingTime = FlyingTime + high2;
            }else if(FlyingTime >= 500 && FlyingTime < 1000){
                FlyingTime = FlyingTime + high3;
            }else if(FlyingTime >= 1000 && FlyingTime < 5000){
                FlyingTime = FlyingTime + high4;
            }else if(FlyingTime >= 5000 && FlyingTime < 10000){
                FlyingTime = FlyingTime + high5;
            }else if(FlyingTime >= 10000){
                FlyingTime = FlyingTime + high6;
            }
        }else if(playerscript.GameOverFlag){
            //GameOverになった場合，スコアを加算しない
        }

        //スコアをテキストで表示
        ScoreText.text = "Score : " + FlyingTime.ToString() + "m";
    }

}