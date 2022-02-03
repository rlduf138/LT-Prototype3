# Legendary Thief  Prototype3
 이 프로젝트는 인디게임팀 **PixelSilo**에서 개발하던 프로젝트의 프로토타입 1번입니다.    
 팀의 1인 프로그래머로 Unity엔진을 사용해 개발하였습니다.
 
  ----
### 어떤 게임인가

   게임명 : LegendaryThief
   타겟 플랫폼 : Android (미출시)
   사용언어, 엔진 : C#, Unity
   
<img src = "./LegendaryThief/img/01.PNG" width = "50%" height = "50%" title = "px Set" alt = "LT1"></img><img src = "./LegendaryThief/img/02.PNG" width = "50%" height = "50%" title = "px Set" alt = "LT2"></img>
<img src = "./LegendaryThief/img/03.PNG" width = "50%" height = "50%" title = "px Set" alt = "LT3"></img><img src = "./LegendaryThief/img/04.PNG" width = "50%" height = "50%" title = "px Set" alt = "LT4"></img>

게임 플레이 영상 : 

**게임 소개**
> 전 세계에 퍼져있는 유물을 훔쳐 전설의 대도둑이 되는 스토리를 가지고 있습니다.     
> 2D 플랫포머 게임으로 건물에 있는 각종 함정을 피하며 최종스테이지에 있는 유물을 획득하는게 목적입니다.

**Prototype2 와의 차이점**
> 캐릭터, 맵 리소스 변경.     
> 플레이어의 대쉬 기능이 삭제되었습니다.     
> 플레이어는 홀로그램(분신)만 지나갈 수 있는 함정과 발판을 이용하여 게임 진행을 합니다.    
> 기존 Celeste의 룸 형식에서 메트로베니아 스타일로 변경하였습니다.

----
### 사용한 유니티 기능
 * **애니메이션**
   * **Sprite Sheet**를 이용한 애니메이션 구현.
   * **Animation Controller**의 Transition 및 애니메이션 이벤트를 이용한 코드 구현.
 * **URP(Universal Render Pipeline)**
   * Hologram, Bloom 효과를 위해 사용.
 * **PixelPerfectCamera**
   * 유니티 Package Manager의 **2D Pixel Perfect** 사용.
 * **Tilemap**
   * 맵 디자인에 Tilemap, TilemapCollider 사용.
 * **Unity Collaborate**
   * 기획자가 직접 맵을 수정하며 테스트를 하기위해 **Unity Collaborate**를 사용하여 협업 진행.
   * 그래픽 디자이너가 Shader의 세부 설정을 수정하기 위하여 **Unity Collaborate**를 사용하여 협업 진행.
