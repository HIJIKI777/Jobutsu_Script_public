using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMScript : MonoBehaviour
{

    public AudioSource Audio;
    public ScoreScript scorescript;             //スコアを計算するゲームオブジェクトを挿入
    public int FlyingScore;                     //ゲーム内のスコアを参照
    public int Fadeout;                         //BGMがフェードアウトするときのスコア
    public float Volume;                        //BGM音量

    void Start()
    {
        // MusicPlayer.SetActive(false);    これは親オブジェクトに
        scorescript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
        Audio = GetComponent<AudioSource>();
    }

    void Update(){
        FlyingScore = scorescript.FlyingTime;
        Audio.volume = Volume;

        //とあるスコアを超えた段階でBGMをフェードアウトさせる
        if(FlyingScore >= Fadeout){
            Volume = Volume - 0.001f;
        }


    }


}