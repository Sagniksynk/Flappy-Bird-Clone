using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public Text scoretext;
  public Text highestScore;
  public GameObject playButton;
  public GameObject gameOver;
  public playerController player;

  private int score;

  private void Awake(){
    Application.targetFrameRate=60;
    Pause();
  }
  private void Start(){
    highestScore.text=PlayerPrefs.GetInt("Highest Score",0).ToString();
  }
  public void Play(){
    score=0;
    scoretext.text=score.ToString();
    playButton.SetActive(false);
    gameOver.SetActive(false);
    Time.timeScale=1f;
    player.enabled=true;

    piperScrolling[] pipes= FindObjectsOfType<piperScrolling>();
    for(int i=0;i<pipes.Length;i++){
      Destroy(pipes[i].gameObject);
    }
  }
  public void Pause(){
    Time.timeScale=0f;
    player.enabled=false;
    
  }
  public void IncreaseScore(){
    score++;
    scoretext.text = score.ToString();
    HighestScore();
  }
  public void GameOver(){
    gameOver.SetActive(true);
    playButton.SetActive(true);
    Pause();
  }
  public void HighestScore(){
    if(score>PlayerPrefs.GetInt("Highest Score",0)){
      PlayerPrefs.SetInt("Highest Score",score);
      highestScore.text=score.ToString();
    }
  }
}
