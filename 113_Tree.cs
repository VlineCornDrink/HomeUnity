//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _113_Tree
//    {
//        static void Main(string[] args)
//        {
//            // 트리
//            // 비선형 자료구조
//            // 계층적 자료구조이며 계층형성 정보 저장을 위해 사용
//            // 이진 탐색 트리와 같이 정렬되어 있는 트리는
//            // 적당한 접근 및 탐색을 제공
//            // 정보 검색을 쉽게 만들어 줌

//            // 용어
//            // Node : 트리 구조의 요소(Element)
//            // 루트 노드 : 최상위 노드
//            // 부모 노드 : 현재 노드 바로 위에 노드
//            // 자식 노드 : 현재 노드 바로 아래 노드
//            // 잎(Leaf)노드 : 자식노드가 없는 노드

//            Node root = CreateNode(1); //노드 생성
//            root.right = CreateNode(2); //오른쪽 자식 노드생성
//            root.left = CreateNode(3); //왼쪽 자식 노드생성
//            root.left.right = CreateNode(4); //왼쪽자식의 오른쪽 자식 노드생성
//            root.right.right = CreateNode(5); //오른쪽자식의 오른쪽자식 노드생성
//            root.left.right.left = CreateNode(6);


//        }

//        class Node
//        {
//            public int data; // 값
//            public Node left; //왼쪽 자식
//            public Node right; //오른쪽 자식
//        }

//        static Node CreateNode(int _data)
//        {//노드 생성 함수
//            Node node = new Node();
//            node.data = _data;
//            node.left = null;
//            node.right = null;
//            return node; //생성한 노드 반환
//        }

//    }
//}
