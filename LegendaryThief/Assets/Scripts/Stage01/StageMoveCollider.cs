using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMoveCollider : MonoBehaviour
{
      public StageInfo prevStageInfo;
      public StageInfo nextStageInfo;
      public DontDestroyInfo dontDestroyInfo;
      Player player;
      Stage01 stage;
      // Start is called before the first frame update
      void Start()
      {
            dontDestroyInfo = FindObjectOfType<DontDestroyInfo>();
            player = FindObjectOfType<Player>();
            stage = FindObjectOfType<Stage01>();
      }

      // Update is called once per frame
      void Update()
      {

      }

      public void SetObjectPass()
      {
            for (int i = 0; i < prevStageInfo.fuelMachines.Count; i++)
            {
                  prevStageInfo.fuelMachines[i].isPass = true;
            }
            for(int i = 0; i<prevStageInfo.activeObjects.Count; i++)
            {
                  prevStageInfo.activeObjects[i].isPass = true;
            }
            for(int i = 0; i<prevStageInfo.deergs.Count; i++)
            {
                  prevStageInfo.deergs[i].isReset = false;
            }
      }
      private void OnTriggerEnter2D(Collider2D collision)
      {
            if (collision.CompareTag("Player"))
            {
                  if (player.m_canControl)
                  {
                        Debug.Log("Trigger");
                        if (dontDestroyInfo.stageInfoNumber == nextStageInfo.stageNumber)
                        {
                              // 액티브 인포와 스테이지 인포가 같으면 반대로 돌아감.
                              Debug.Log("전 맵으로 이동");
                              dontDestroyInfo.stageInfo = prevStageInfo;
                              dontDestroyInfo.startPos = dontDestroyInfo.stageInfo.respawnPosList[1];
                              player.StartCoroutine("StageMove", dontDestroyInfo.startPos);
                              stage.ChangeActiveStage();
                              dontDestroyInfo.stageInfoNumber = dontDestroyInfo.stageInfo.stageNumber;
                              dontDestroyInfo.startPosNumber = 1;

                            //  SetObjectPass();

                              if(player.prevStageinfo == nextStageInfo)
                              {
                                    // 플레이어가 방금 지나온 맵이 다음맵이랑 같으면.
                                    // 즉 왔다가 돌아가는 경우.
                              }
                              else
                              {
                                    // 왔다가 돌아가는게 아닌 경우.
                                    Debug.Log("Save Next");
                                    nextStageInfo.SaveMapObject();
                              }

                              // 전 스테이지 오브젝트 작동, 다음 스테이지 오브젝트 비활성
                              player.prevStageinfo = nextStageInfo;
                              prevStageInfo.ActiveAllObject();
                              nextStageInfo.DisableAllObject();
                        }
                        else if (dontDestroyInfo.stageInfoNumber == prevStageInfo.stageNumber)
                        {
                              // 다음 스테이지로 진행
                              Debug.Log("다음맵으로 이동");
                              dontDestroyInfo.stageInfo = nextStageInfo;
                              dontDestroyInfo.startPos = dontDestroyInfo.stageInfo.respawnPosList[0];
                              player.StartCoroutine("StageMove", dontDestroyInfo.startPos);
                              stage.ChangeActiveStage();
                              dontDestroyInfo.stageInfoNumber = dontDestroyInfo.stageInfo.stageNumber;
                              dontDestroyInfo.startPosNumber = 0;

                              
                              if (player.prevStageinfo == prevStageInfo)
                              {
                                    // 플레이어가 방금 지나온 맵이 다음맵이랑 같으면.
                                    // 즉 왔다가 돌아가는 경우.
                              }
                              else
                              {
                                    // 왔다가 돌아가는게 아닌 경우.
                                    Debug.Log("Save Prev");
                                    prevStageInfo.SaveMapObject();
                              }
                              player.prevStageinfo = prevStageInfo;
                              prevStageInfo.DisableAllObject();
                              nextStageInfo.ActiveAllObject();
                              
                        }

                        if (dontDestroyInfo.stageInfoNumber <= 2)
                        {
                              stage.RainOn();
                        }
                        else
                        {
                              stage.RainOff();
                        }

                  }
            }
      }
}
