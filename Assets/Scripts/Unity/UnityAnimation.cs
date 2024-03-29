using UnityEngine;

namespace Unity
{
    public class UnityAnimation : MonoBehaviour
    {
        /************************************************************************************
         * 애니메이션 (Animation)
         * 
         * 특정 게임오브젝트의 속성이 시간에 따라 변경되는 정보를 연속적으로 진행하는 시스템
         *************************************************************************************/

        // <애니메이터 컴포넌트>
        // 애니메이션들을 관리하고 동작시키는 컴포넌트
        // 아바타 : 한 뼈대를 다른 뼈대에 1대1로 매칭하여 애니메이션을 적용하도록 하는 인터페이스
        // 루트모션 : 애니메이션 자체에 의해 가해지는 움직임


        // <애니메이터 컨트롤러>
        // 특정 캐릭터나 게임오브젝트의 애니메이션 클립들을 관리 및 유지
        // 컨트롤러는 다양한 애니메이션 상태와 상태 간 전환을 상태머신을 이용하여 관리
        // 상태간의 전환조건을 파라매터를 통해 지정하며, 전환간의 보간을 진행


        // <애니메이션 클립>
        // 특정 게임오브젝트의 속성이 시간에 따라 변경되는 정보의 에셋
        // 애니메이션 창을 통해 애니메이션 클립의 시간에 따라 변경되는 정보를 편집
        // 키프레임 : 애니메이션 클립의 프레임 당시의 속성값을 저장
        // 커브 : 키프레임간의 속성값을 보간하여 변경
    }
}