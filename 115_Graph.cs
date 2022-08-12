//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class _115_Graph
//    {
//        static void Main(string[] args)
//        {
//            // 그래프 
//            // 비선형 자료구조
//            // 요소들이 서로 복잡하게 연결되어 있는 관계를 표현하는 자료구조
//            // 정점(Vertex)와 간선(Edge)들의 집합으로 구성
//            // 수학적으로 그래프를 표시하는 방법 : G = (V, E)
//            // V는 그래프(G)의 정점들의 집합을, E는 간선들의 집합, G는 그래프를 의미
//            // 지하철 노선도, 길찾기 알고리즘, 네비게이션 등 실생활 다양한 분야에서 활용

//            // 그래프 용어
//            // 1. 정점(Vertex)
//            // 노드(Node)라고도 부르며 데이터가 저장되는 기본 원소
//            // 2. 간선(Edge)
//            // 링크(Link)라고도 부르며 정점 간의 관계를 나타냄
//            // 3. 인접정점(Adjacent Vertex)
//            // 하나의 정점에서 간선에 의해 직접 연결되어 있는 정점
//            // 4. 차수(Degree)
//            // 정점에 연결된 간선의 수
//            // 방향그래프의 경우 외부에서 오는 간선의 수를 진입차수
//            // 외부로 향하는 간선의 수를 진출 차수
//            // 5. 경로(Path)
//            // 간선이 따라갈 수 있는 길을 의미
//            // 정점을 나열하여 표시
//            // 간선이 존재하지 않는 길은 경로가 될 수 없다.
//            // 6. 경로의 길이(Lengh)
//            // 경로를 구하는데 사용된 간선의 수
//            // 7. 단순 경로(Simple Path)
//            // 경로 중에서 반복되는 간선이 없는 경로
//            // 8. 사이클(Cycle)
//            // A -> B -> C -> A
//            // 시작정점과 종료정점이 같은 단순 경로

//            Graph graph = new Graph();
//            graph.InsertVectex("A"); //0
//            graph.InsertVectex("B"); //1 
//            graph.InsertVectex("C"); //2
//            graph.InsertVectex("D"); //3

//            graph.InsertEdge(0, 1); //A - B 연결
//            graph.InsertEdge(0, 2); //A - C 연결
//            graph.InsertEdge(0, 3); //A - D 연결
//            graph.InsertEdge(2, 3); //C - D 연결

//            graph.Display();

//        }
//        class Graph
//        {
//            private int size; //정점의 갯수
//            private string[] vertices = new string[256]; //정점의 이름
//            private int[,] adjMat = new int[256, 256]; //엣지

//            public Graph()
//            {
//                Reset(); //그래프 초기화
//            }
//            public bool isEmpty() { return size == 0; }
//            public bool isFull() { return size >= 256; }
//            private void Reset()
//            {
//                size = 0;
//                for (int i = 0; i < 256; i++)
//                {
//                    for (int j = 0; j < 256; j++)
//                    {
//                        SetEdge(i, j, 0);
//                        //선을 전부 0으로 변경
//                    }
//                }
//            }
//            public string GetVertex(int i)
//            {
//                return vertices[i]; //정점 반환
//            }
//            public int GetEdge(int i, int j)
//            {
//                return adjMat[i, j]; //엣지 반환
//            }
//            public void SetEdge(int i, int j, int value)
//            {
//                adjMat[i, j] = value; //엣지 변경
//            }

//            public void InsertVectex(string name)
//            {//정점 삽입 함수
//                if (isFull())
//                {
//                    Console.WriteLine("Graph Vetex is full");
//                    return;
//                }
//                vertices[size++] = name;
//            }
//            public void InsertEdge(int u, int v)
//            {
//                SetEdge(u, v, 1);
//                SetEdge(v, u, 1);
//            }
//            public void Display()
//            {
//                Console.WriteLine("VertexSize : "+size);
//                Console.Write("   "); //3칸 띄어줌
//                for (int i = 0; i < size; i++)
//                {
//                    Console.Write(GetVertex(i)+" ");
//                }
//                Console.WriteLine(""); //개행

//                for (int i = 0; i < size; i++)
//                {
//                    Console.Write(GetVertex(i)+" : ");
//                    for (int j = 0; j < size; j++)
//                    {
//                        Console.Write(GetEdge(i,j)+ " ");
//                    }
//                    Console.WriteLine("");
//                }

//            }
//        }
//    }
//}
