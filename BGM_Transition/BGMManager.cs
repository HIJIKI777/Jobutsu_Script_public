/*
どの子オブジェクトのBGMを流すかを選択するゲームオブジェクトにアタッチしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMManager : MonoBehaviour
{

    public GameObject[] MusicPlayer;            //BGMを鳴らすゲームオブジェクトを挿入

    public ScoreScript scorescript;             //スコアを計算するゲームオブジェクトを挿入
    public int FlyingScore;                     //ゲーム内のスコアを参照

    void Start()
    {
        scorescript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
        MusicPlayer[0].SetActive(false);            //最初は全てfalse
        MusicPlayer[1].SetActive(false);
        MusicPlayer[2].SetActive(false);
        MusicPlayer[3].SetActive(false);
        MusicPlayer[4].SetActive(false);
        MusicPlayer[5].SetActive(false);
    }

    void Update(){
        FlyingScore = scorescript.FlyingTime;

        //複数の音源を同時に再生すると重くなるので
        //スコアを参照して，ステージごとにtrueとなるオブジェクト
        //即ち，再生するBGMを選択して，それのみを再生する
        if(FlyingScore > 550 && FlyingScore <= 1050){
            MusicPlayer[0].SetActive(false);
            MusicPlayer[1].SetActive(true);
        }else if(FlyingScore > 1050 && FlyingScore <= 5200){
            MusicPlayer[1].SetActive(false);
            MusicPlayer[2].SetActive(true);
        }else if(FlyingScore > 5200 && FlyingScore <= 11000){
            MusicPlayer[2].SetActive(false);
            MusicPlayer[3].SetActive(true);
        }else if(FlyingScore > 11000 && FlyingScore <= 11000){
            MusicPlayer[3].SetActive(false);
            MusicPlayer[4].SetActive(true);
        }else if(FlyingScore > 52000){
            MusicPlayer[4].SetActive(false);
            MusicPlayer[5].SetActive(true);
        }else{
            MusicPlayer[0].SetActive(true);
        }


    }


}