# unity-Vector3

## 벡터와 스칼라   
1. 벡터: 공간상에서의 방향과 크기.   
2. 스칼라: 크기만 가진 단일 값.   
3. 방향, 속도(v1과 v2의 이동 방향을 확인), 좌표를 가진다.   

## 벡터의 계산   
### v1+v2-덧셈: V1(1,2)과 V2(2,1)의 덧셈은 V3(3,3)이다. 서로 다른 방향에서 중간값 또는 두 방향이 합쳐지는 값.   


<img width="266" alt="1" src="https://user-images.githubusercontent.com/48555909/125881569-eec8f3cd-ea6e-4c11-86c7-c7e50fff4b20.png">


### v1-v2-뺄셈: V1(1,2)와 V2(2,1)의 뺄셈은 V3(-1,1)이다. 결과값 V4가 V1,V2사이의 벡터와 같다.   


<img width="266" alt="2" src="https://user-images.githubusercontent.com/48555909/125881597-e2672f98-0c23-429c-a697-f03f294d7e27.png">


### v1*S-벡터와 스칼라의 곱: V1(1,1)의 S=4 곱은 V2(4,4)이다.    
방법1: 1<S 값을 증가, 1<S 값을 감소.   
방법2: S = -1로 V의 반대 방향을 구함.


<img width="280" alt="3" src="https://user-images.githubusercontent.com/48555909/125881606-2a3e6d18-5914-4ce4-bf4c-c00cdb130385.png">


### v1.magnitude-벡터의 길이(속도)   
2차원 벡터의 길이 = √X²+Y²   
3차원 벡터의 길이 = √X²+Y² +Z²  


<img width="239" alt="4" src="https://user-images.githubusercontent.com/48555909/125881620-53a628ec-b64f-4d9f-9d9e-55d8338f504d.png">


### v1.normalized-벡터의 정규화: 벡터의 방향을 유지, 길이를 1로 만듬. 벡터의 정확한 방향을 확인하기 위해 사용.   
단위벡터(길이가 1인 벡터)를 만든다. 단위벡터 = 벡터의 각 원소 또는 벡터의 길이   


<img width="434" alt="5" src="https://user-images.githubusercontent.com/48555909/125881659-df8ad4f3-de75-4781-b16e-711ef9ca82c6.png">

*Vector3.Angle(v0, v1) : v0와 v1사이의 각도를 구하는 함수.
### Vector3.Dot(v0, v1)-벡터의 내적: 계산 결과값, 스칼라 값을 냄. *벡터와 스칼라의 곱은 원소값을 낸다. 벡터의 내적과는 다르다.   
2차원 벡터의 내적(U*V) = UxVx +UyVy   
3차원 벡터의 내적(U*V) = UxVx +UyVy + UzVz
-U*V = 0 : 90도   
-U*V > 0 : 90도보다 작음.   
-U*V < 0 : 90도보다 큼.   
-삼각함수(cos,sin,tan)를 사용하면 두 벡터 사이의 각도를 구할 수 있다.   


<img width="343" alt="6" src="https://user-images.githubusercontent.com/48555909/125881683-0b2bbc07-502d-4e07-bd60-6e889f38fb34.png">



### Vector3.Cross(v1, v2)-벡터의 외적: 계산할 2개의 벡터에게서 90도를 이루는 벡터 결과 값를 얻음.   *3차원 공간에서만 사용가능.   


<img width="347" alt="7" src="https://user-images.githubusercontent.com/48555909/125881718-febf0a15-1256-4105-ba02-79a12206b405.png">


## 유니티확인 결과.


<img width="232" alt="화면 캡처 2021-07-16 105307" src="https://user-images.githubusercontent.com/48555909/125881882-d9fc6da8-b240-4306-9c97-7ae1acff76e1.png">
