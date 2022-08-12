//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _114_BinaryTree
//    {
//        static void Main(string[] args)
//        {
//            // 이진 탐색 트리
//            // 좌측 하위 트리의 노드들은 상위 노드보다 작거나 같은 값
//            // 우측 하위 트리들은 상위 노드보다 큰 값
//            // 좌측 및 우측 하위트리 역시 이진 탐색 트리

//            // 탐색
//            // 탐색 시작은 루트노드에서 시작
//            // 탐색하려는 값이 루트 노드의 값이라면 루트노드의 값 반환
//            // 탐색하려는 값이 루트 노드보다 작다면 좌측 하위트리 탐색 반복
//            // 탐색하려는 값이 루트 노드보다 크다면 우측 하위트리 탐색 반복
//            ''
//        }

//        class Node
//        {
//            public int data; //값
//            public Node left; //왼쪽 자식
//            public Node right; //오른쪽 자식

//        }
//        static Node CreateNode(int _data)
//        {
//            Node node = new Node();
//            node.data = _data;
//            node.left = null;
//            node.right = null;
//            return node;
//        }

//        static Node MinNode(Node node)
//        {
//            Node minNode = node; //현재 노드가 minNode에 들어감
//            while (minNode.left != null) //값이 없을때까지 반복
//            {
//                minNode = minNode.left;
//                //값이 있다면 왼쪽으로 계속 이동
//            }
//            return minNode;
//        }

//        static Node DeleteNode(Node root, int key)
//        { //노드를 제거하는 함수
//            if (root == null)
//            {
//                return root;
//            }
//            if (key < root.data)//제거하려는 값이 노드값보다 작다면
//            {
//                root.left = DeleteNode(root.left, key);
//                //왼쪽으로 이동
//            }
//            else if (key > root.data) //제거하려는 값이 노드값보다 크다면
//            {
//                root.right = DeleteNode(root.right, key);
//                //오른쪽으로 이동
//            }
//            else //제거하려는 값이 노드값과 같다면
//            {
//                if (root.left == null) //왼쪽에 값이 없다면
//                {
//                    Node temp = root.right;//오른쪽 하위 노드를 저장
//                    root = null;//메모리 해제가 안되므로 null을 넣음
//                    return temp; //오른쪽 하위 노드 반환
//                }
//                if (root.right == null)//오른쪽에 값이 없다면
//                {
//                    Node temp = root.left;//왼쪽 하위 노드를 저장
//                    root = null;
//                    return temp; //왼쪽 하위 노드 반환

//                }
//                //좌우 전부 값이 있다면
//                Node _temp = MinNode(root.right);
//                root.data = _temp.data;
//                root.right = DeleteNode(root.right, _temp.data);

//            }
//            return root;
//        }

//        //탐색 (검색) 함수
//        static Node Search(Node root, int key)
//        {
//            if (root==null||root.data==key)
//            { //값이 없거나 원하는 값과 root의 값과 같다면
//                return root;
//            }
//            else if (root.data < key)
//            {
//                return Search(root.right, key);
//                //값이 루트보다 크다면 오른쪽으로 이동
//            }
//            else //if(root.data>key)
//            {
//                return Search(root.left, key);
//            }
//        }
//    }
//}
