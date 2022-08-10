using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Node //노드
    {
        public int data;// 값을 저장할 데이터
        public Node next; //다음 노드 

        public Node(int _data)
        {
            data = _data;
            next = null;
        }
    }

    class LinkedList //연결리스트
    {
        Node head; //첫번쨰 노드
        public Node GetLastNode() //마지막 노드를 반환
        {
            Node temp = head;
            while (temp.next != null) //노드가 값이 없을때까지(마지막까지)반복
            {
                temp = temp.next; //다음노드를 넣어줌

            }
            return temp; //찾은 마지막 노드를 반환
        }
        public void InsertFront(int _data) //맨앞에 데이터 추가
        {
            Node node = new Node(_data); //노드를 만들어서줌
            node.next = head; //맨 앞 노드는 새로 만든 노드의 다음으로
            head = node; // 새로 만든 노드는 맨 앞으로 
        }
        public void InsertLast(int _data) //맨뒤에 데이터 추가
        {
            Node node = new Node(_data);
            if (head == null) //맨 앞에 데이터가 없다면
            {
                head = node; //맨앞으로 현재노드를 넣어줌
                return; //함수 종료
            }
            Node lastMode = GetLastNode(); //맨뒤 노드를 찾음
            lastMode.next = node; // 현재 노드를 맨뒤에 넣어줌
        }
        public void Insert(int index, int data) //중간에 노드 삽입
        {
            Node tempNode = head;
            for (int i = 0; i < index; i++)
            {
                if (tempNode == null)
                {
                    return;
                }
                tempNode = tempNode.next; //다음으로 이동

            }
            Node node = new Node(data);
            node.next = tempNode.next;
            tempNode.next = node; //중간에 넣는다.
        }

        public void Delete(int key) //노드 제거
        {
            Node temp= head;
            Node prev = null;
            if (temp.data == key)
            {//시작점과 제거할 값이 같다면
                head = temp.next;
            }
            while (temp == null)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;
        }
        public void Display()
        {
            for (Node node =head; node!=null;node=node.next)
            {
                Console.WriteLine(node.data);
            }
        }

        

    }
}
