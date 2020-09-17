using System;       // 하단에 구구단 있습니다.
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Rock_Paper_Scissors
    {
        static void Main(string[] args)
        {
            int computer;
            int user;
            int match = 0;
            int win = 0;
            int draw = 0;
            int lose = 0;
            string[] rockPaperScissors = { "가위", "바위", "보" };
            do
            {
                computer = (new Random()).Next(1, 4);
                Console.Write(" 1(가위)  2(바위)  3(보)  4(전적)  5~(종료)  입력: ");
                user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (user > 3)
                {
                    if (user == 4)
                    {
                        Console.WriteLine($" 총 {match}판 : {win}승 {draw}무 {lose}패 입니다.\n");
                        continue;
                    }
                    else
                        break;
                }
                else
                {
                    Console.WriteLine($" 유저 : {rockPaperScissors[user - 1]}");

                    Console.WriteLine($" 컴퓨터 : {rockPaperScissors[computer - 1]}");

                    if (user == computer)
                    {

                        Console.WriteLine(" 비겼습니다.\n");
                        draw++;
                        match++;
                    }
                    else
                    {

                        switch (user)
                        {
                            case 1:
                                if (computer == 3)
                                {
                                    Console.WriteLine(" 이겼습니다.\n");
                                    win++;
                                    match++;
                                }
                                else
                                {
                                    Console.WriteLine(" 졌습니다.\n");
                                    lose++;
                                    match++;
                                }
                                break;
                            case 2:
                                if (computer == 1)
                                {
                                    Console.WriteLine(" 이겼습니다.\n");
                                    win++;
                                    match++;
                                }
                                else
                                {
                                    Console.WriteLine(" 졌습니다.\n");
                                    lose++;
                                    match++;
                                }
                                break;
                            case 3:
                                if (computer == 2)
                                {
                                    Console.WriteLine(" 이겼습니다.\n");
                                    win++;
                                    match++;
                                }
                                else
                                {
                                    Console.WriteLine(" 졌습니다.\n");
                                    lose++;
                                    match++;
                                }
                                break;
                        }
                    }
                }
            } while (user < 5);
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Class3
    {
        static void Main(string[] args)
        {
            int dan = 0;

            for (int a = 1; a < 4; a++)                 // 3단씩 3칸으로 출력 3x3형식
            {
                for (dan = 1; dan < 10; dan++)
                {
                    for (int b = 3 * a - 2; b < 3 * a + 1; b++)
                    {
                        Console.Write($"{b} * {dan} = {b * dan}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
*/