# 2D3D – Pre-Alpha  
2D Characters in a 3D World  
쿼터뷰 스타일의 2.5D Unity 프로젝트입니다.  
2D 스프라이트가 3D 환경에서 자연스럽게 움직이고,  
카메라가 지연 추적과 부드러운 오빗 회전을 동시에 지원합니다.

---

## 📦 Development Environment

- **Unity Version**: `6000.0.45f1`
- **Render Pipeline**: Built-in (기본)
- **Platform**: Windows (기본), 다른 플랫폼도 추후 지원 예정
- **Git LFS**: 사용 (필수)
  - `.fbx`, `.png`, `.wav` 등 모든 대용량 파일은 LFS로 추적

---

## 🎮 Core Features

### 📌 1. 2D Sprite Billboard System  
- 캐릭터는 항상 카메라를 바라보는 Billboard 방식  
- 3D 공간에서 자연스러운 2D 애니메이션 표현

### 📌 2. Camera Orbit + Delayed Follow  
- Q/E로 카메라 회전  
- 플레이어 움직임을 늦게 따라오는 자연스러운 카메라 추적  
- 대시 시 화면 연출 강화

### 📌 3. Camera-Based Movement  
- W/S = 전후 이동 (조금 느리게)  
- A/D = 좌우 이동 (조금 빠르게)  
- 카메라 기준 움직임으로 직관적인 조작 가능

---

## 🗂️ Project Structure

Assets/

├── Scripts/

│ ├── CameraOrbitAroundPlayer.cs

│ ├── PlayerMovement.cs

│ └── SpriteBillboard.cs

├── Sprites/

├── Models/

└── Scenes/



---

## 🚀 How to Run

1. Unity 6000.0.45f1 버전으로 프로젝트 열기  
2. Git LFS 설치 필수  
git lfs install

3. LFS 파일 자동 다운로드  
git lfs pull

4. `/Scenes/Main.unity` 실행

---

## 📝 Roadmap (Todo)

- [ ] 캐릭터 스프라이트 애니메이션 추가  
- [ ] 8방향 이동 애니메이션  
- [ ] 몬스터 AI(추적/공격)  
- [ ] 지형 및 환경 오브젝트 배치  
- [ ] 타일 기반 맵 생성  
- [ ] UI/HUD (HP, Dash Gauge, 미니맵)  
- [ ] 대시 이펙트 추가  
- [ ] 사운드 시스템 구성  

---

## 🤝 Contributors  
- ****  
- (추가 예정)

---

## 🔒 License  
현재는 개인 개발용 비공개 프로젝트입니다.
