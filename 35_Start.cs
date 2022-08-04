using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class _35_Start
    {
        static void Main(string[] args)
        {
            // 별찍기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 다른모양
            //*
            //**
            //***
            //****
            //*****
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j <= i)
                        //j변수가 i변수보다 작다면 같다면
                        Console.Write("*");
                }
                Console.WriteLine();
            }

            //실습 
            //*****
            //****
            //***
            //**
            //*

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j >= i)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            // 다른 별짓기도 연습해보자

        }
    }
}
