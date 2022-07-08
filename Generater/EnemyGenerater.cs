/*
敵を生成するゲームオブジェクトにアタッチしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownGeneraterScript : MonoBehaviour
{

    public GameObject enemy;   //ステージ1の敵を生成
    public GameObject enemy102;
    public GameObject enemy103;
    public GameObject enemy2;  //ステージ2の敵を生成
    public GameObject enemy202;
    public GameObject enemy203;
    public GameObject enemy3;  //ステージ3の敵を生成
    public GameObject enemy302;
    public GameObject enemy302;
    public GameObject enemy4;  //ステージ4の敵を生成
    public GameObject enemy402;
    public GameObject enemy403;
    public GameObject enemy5;  //ステージ5の敵を生成
    public GameObject enemy502;
    public GameObject enemy503;
    public GameObject enemy6;  //ステージ6の敵を生成
    public GameObject enemy602;
    public GameObject enemy603;

    public GameObject empty;   //敵を生成しない
    float rnd;                 //乱数用
    public float count;        //タイムカウンター
    public float GenTime;      //各Generaterの発射周期
    ScoreScript scorescript;
    public int FlyingScore;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        scorescript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        rnd = Random.Range(1,100);
        FlyingScore = scorescript.FlyingTime;

        //GenTime(発射周期)を超えたときに敵を生成する(しない場合もある).
        //さらに，rnd(乱数)の値によって生成する敵を変更する.
        //また，FlyingScore(ステージ)によって生成する敵や確率を変える.
        //実際にゲームにて使用されているコードとは少し異なります.
        if(FlyingScore > 100 && FlyingScore <= 500){             //ステージ2
            if(count > GenTime && rnd > 50 && rnd <= 67){
                CreateEnemy(enemy2);
                count = 0;
            }else if(count > GenTime && rnd > 67 && rnd <= 84){
                CreateEnemy(enemy202);
                count = 0;
            }else if(count > GenTime && rnd > 84 && rnd <= 100){
                CreateEnemy(enemy203);
                count = 0;
            }else if(count> GenTime && rnd <= 50){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }else if(FlyingScore > 500 && FlyingScore <= 1000){      //ステージ3
            if(count > GenTime && rnd > 60 && rnd <= 70){
                CreateEnemy(enemy3);
                count = 0;
            }else if(count > GenTime && rnd > 70 && rnd <= 80){
                CreateEnemy(enemy302);
                count = 0;
            }else if(count > GenTime && rnd > 80 && rnd <= 90){
                CreateEnemy(enemy2);
                count = 0;
            }else if(count > GenTime && rnd > 90 && rnd <= 100){
                CreateEnemy(enemy303);
                count = 0;
            }else if(count> GenTime && rnd <= 60){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }else if(FlyingScore > 1000 && FlyingScore <= 5000){     //ステージ4
            if(count > GenTime && rnd > 60 && rnd <= 80){
                CreateEnemy(enemy4);
                count = 0;
            }else if(count > GenTime && rnd > 80 && rnd <= 90){
                CreateEnemy(enemy402);
                count = 0;
            }else if(count > GenTime && rnd > 90 && rnd <= 100){
                CreateEnemy(enemy403);
                count = 0;
            }else if(count> GenTime && rnd <= 60){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }else if(FlyingScore > 5000 && FlyingScore <= 10000){    //ステージ5
            if(count > GenTime && rnd > 40 && rnd <= 60){
                CreateEnemy(enemy5);
                count = 0;
            }else if(count > GenTime && rnd > 60 && rnd <= 80){
                CreateEnemy(enemy502);
                count = 0;
            }else if(count > GenTime && rnd > 80 && rnd <= 100){
                CreateEnemy(enemy503);
                count = 0;
            }else if(count> GenTime && rnd <= 40){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }else if(FlyingScore > 10000){                           //ステージ6
            if(count > GenTime && rnd > 30 && rnd <= 50){
                CreateEnemy(enemy6);
                count = 0;
            }else if(count > GenTime && rnd > 50 && rnd <= 70){
                CreateEnemy(enemy602);
                count = 0;
            }else if(count > GenTime && rnd > 70 && rnd <= 90){
                CreateEnemy(enemy603);
                count = 0;
            }else if(count > GenTime && rnd > 90 && rnd <= 100){
                CreateEnemy(enemy3);
                count = 0;
            }else if(count> GenTime && rnd <= 30){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }else if(FlyingScore <= 100){                            //ステージ1
            if(count > GenTime && rnd > 70 && rnd <= 80){
                CreateEnemy(enemy);
                count = 0;
            }else if(count > GenTime && rnd > 80 && rnd <= 90){
                CreateEnemy(enemy102);
                count = 0;
            }else if(count > GenTime && rnd > 90 && rnd <= 100){
                CreateEnemy(enemy103);
                count = 0;
            }else if(count> GenTime && rnd <= 70){
                CreateEmpty();
                count = 0;
            }else{
                count += Time.deltaTime;
            }
        }
    }

    //引数に格納された敵を生成する関数
    void CreateEnemy(GameObject ene){
        GameObject gen_enemy = Instantiate(ene,this.transform.position,Quaternion.identity);
    }


    void CreateEmpty(){
        GameObject gen_empty = Instantiate(empty,this.transform.position,Quaternion.identity);
    }
// 1秒毎に敵を生成（そこにも乱数つけてもいいかも）、そして乱数rndの示したtransform.positionに敵を生成する

}