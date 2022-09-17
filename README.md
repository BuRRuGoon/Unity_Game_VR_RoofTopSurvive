# Unity_Game_VR_RoofTopSurvive
<<<<<<< HEAD
 VR SurviveGame

# 소스 코드 간단한 설명
[[BuildSystem.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/BuildSystem.cs)  
망치를 이용해서 건축을 가능하게 해줍니다.  
VR에 특성을 이용해 자유롭게 원하는 위치에 물건을 고정하는 방식으로 BuildSystem을 간단하게 제작했습니다.  
공중에서는 건축이 불가능하고 땅에 먼저 물건을 고정하고 위로 쌓는 방식으로 고정이 가능합니다.  
Build라는 태그를 가지고 있어야되고 만약 하단에 고정되있던 물건을 건축해제하는 경우 건축물이 전부 무너지도록 설정했습니다. 

[[CollisionEvent.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/CollisionEvent.cs)  
목재를 도끼를 이용해서 나누는 충돌 이벤트 스크립트입니다.  
간단한 충돌 이벤트는 해당 이벤트.cs에서 tag에 따라 관리하기 위해서 제작했습니다.  

[[Cup.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/Cup.cs)  
물을 담는 컵에서 활용되는 스크립트입니다.  
물에 닿았을경우에 물이 있는 컵으로 변경이 되며 만약 90도 이상 기울이게 되면 해당 물을 버리게됩니다.  

[[DeadZone.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/DeadZone.cs)  
닿으면 물체가 파괴되는 스크립트입니다.  
떠내려가는 아이템과 플레이어가 물속으로 들어갔을경우에는 리스폰하기 위해서 사용되었습니다.  

[[FlashLight.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/FlashLight.cs)  
손전등을 켰다 끄기 위한 스크립트입니다.  
flashLit이라는 라이트를 설정 해제합니다.  
플레이어 컨트롤러 키에 해당 함수를 설정해서 같은 키를 누르면서 스위칭하는 방식으로 구현했습니다.  

[[HungerIndicator.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/HungerIndicator.cs)  
배고픔을 표시해주는 인디케이터 스크립터입니다.  
VR환경이기 때문에 따로 HP바 역활을 할 UI가 필요해서 시계 UI에 마테리얼 Cutoff 값을 조정해서 구현했습니다.  

[[ItemSpawner.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/ItemSpawner.cs)  
아이템을 물 위에 스폰해주는 아이템 스폰 스크립트입니다.  
프리팹으로 제작된 아이템을 인스펙터창에 Item 배열에 추가해주면 랜덤값을 이용해 해당 아이템이 랜덤적으로 스폰되게 설정해두었습니다.  
차후에 아이템이 많아지면 각 각 가중치를 이용한 방식으로 변경할 예정입니다.  

[[ItemVolumeControl.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/ItemVolumeControl.cs)  
아이템을 획득하는 곳에 너무 많은 아이템이 쌓여져있을 경우에 아이템 스폰을 중지하는 스크립트입니다.  
플레이어가 아이템을 줍지않고 너무 많이 방치해뒀을경우 메모리를 많이 차지할것 같아서 제작해두었습니다.  
maxVolumeCount를 값만큼 아이템 획득 장소에 해당 아이템 값 이상이 있는 경우에는 스폰 스크립트가 차단됩니다.  

[[ItemWaveMove.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/ItemWaveMove.cs)  
스폰된 아이템을 물위에서 이동시켜주는 스크립트입니다.  
해당 스크립트는 StylizedWater2에 FloatingTransform 기능을 활용해서 작성했습니다.  
처음에 아이템이 스폰되고 파도에 있는 경우에는 EndPoint를 향해서 움직이게 됩니다.  
물건이 겹쳐져서도 안되고 플레이어가 물속에서 물건을 잡거나 다시 물속에 물건을 던졌을때 상태를 구현했습니다.  

[[PlayerStatus.cs]](https://github.com/BuRRuGoon/Unity_Game_VR_RoofTopSurvive/blob/main/RTS_Project/Assets/Scripts/PlayerStatus.cs)  
플레이어의 스테이터스를 관리해주는 스크립트입니다.  
Drink()와 Eat()을 통하여 시간마다 줄고있는 배고픔 게이지와 목마름 게이지를 회복 할 수 있습니다.  

[NotUsed]  
개발중 더 좋은 기능이나 동작을 찾아서 사용되지 않는 스크립트 파일들입니다.  
=======
해당 문서에는 직접 제작한 소스 파일만 업로드 되어있습니다.
>>>>>>> 02074bf083657c5c0d7fc03b05915f0690a0ba53
