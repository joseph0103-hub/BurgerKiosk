# (C# 코딩) 키오스크 주문 프로그램

## 목차
1. 개요
2. 과제 1
3. 과제 2
4. 과제 3
5. 과제 4

---

## 1. 개요
본 실습은 C# Windows Forms(.NET 8) 환경에서 버거 주문 키오스크(Burger Kiosk)를 구현하는 과제이다. Visual Studio 2026을 사용하여 컨트롤 배치, 이벤트 처리, 사용자 입력 검증, 키보드 조작, 실시간 UI 갱신 기능을 단계적으로 구현하였다. 각 단계별 과제를 통해 사용자 인터페이스 설계와 이벤트 기반 프로그래밍 구조를 이해하고, 실제 키오스크와 유사한 주문 시스템을 완성하는 것을 목표로 한다.

- 사용한 플랫폼  
  : C#, .NET Windows Forms, Visual Studio, GitHub  

- 사용한 컨트롤  
  : Label, GroupBox, RadioButton, CheckBox, ListBox, Button, PictureBox  

- 사용한 기술과 구현 기능  
  : Visual Studio를 이용한 UI 디자인  
  : 이벤트 기반 프로그래밍  

- 수업 중에 배우고 사용했던 클래스들 관련된 설명  
  - string: 사용자 선택값을 문자열로 저장하고 처리  

- 실습 중에 구현한 기능들 설명  
  : 메뉴 및 옵션 선택 기능 구현  
  : 주문 내역 출력 및 총 금액 계산 기능 구현  
  : 입력 검증 및 오류 메시지 표시 기능 구현  
  : 키보드 입력 기반 주문 기능 구현  
  : 선택 즉시 UI 갱신 기능 구현  

---

## 2. 과제 1

### 실행 화면

![초기화면](img/Assignment_1_initial.png)
![과제1-2](img/Assignment_1_menuSelect.png)
![과제1-3](img/Assignment_1_optionSelect.png)
![과제1-4](img/Assignment_1_orderBtn.png)

### 과제 내용
- 컨트롤 배치와 기본적인 속성 설정을 수행한다.  
- RadioButton과 CheckBox를 이용하여 메뉴와 옵션을 구성한다.  
- GroupBox를 사용하여 메뉴와 옵션을 구분한다.  
- 주문하기 버튼과 초기화 버튼의 기능을 구현한다.  
- 주문 내역과 총 금액을 화면에 표시한다.  

### 구현 내용과 기능 설명
- Label, GroupBox, RadioButton, CheckBox, ListBox, Button, PictureBox를 활용하여 키오스크 UI를 구성하였다.  
- 메뉴는 RadioButton으로 구성하여 하나만 선택되도록 구현하고, 옵션은 CheckBox를 사용하여 복수 선택이 가능하도록 구성하였다.  
- GroupBox를 활용하여 메뉴 영역과 옵션 영역을 구분하여 사용자 인터페이스를 명확하게 구성하였다.  
- 주문하기 버튼 클릭 시 선택된 메뉴와 옵션을 ListBox에 출력하고, 선택된 항목의 가격을 합산하여 총 금액을 Label에 표시하도록 구현하였다.  
- 초기화 버튼을 통해 선택 상태와 주문 내역, 총 금액을 모두 초기 상태로 되돌리는 기능을 구현하였다.  

---