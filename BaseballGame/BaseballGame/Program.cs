using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("|                 궁극의 숫자야구 게임                |");
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("| 컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다. |");
            Console.WriteLine("| 각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다.  |");
            Console.WriteLine("| 모든 숫자와 위치를 맞히면 승리합니다.               |");
            Console.WriteLine("| 숫자와 순서가 둘 다 맞으면 스트라이크입니다.        |");
            Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("| 숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+-----------------------------------------------------+");

            //===========================================>여기부터 작동되는 코드.

            Random random = new Random(); // 수비수가 가지게되는 숫자를 무작위로 섞기위한 랜덤

            int[] numbers = new int[3]; // 3개의 숫자를 담기 위한 int배열 변수
            int index = 0; //증가를 위한 변수

            // 3개의 숫자를 받기위한 반복제어문.
            while (index < 3)
            {
                numbers[index] = random.Next(1, 10); // 1~10까지의 숫자를 랜덤하게 배열에 담는다.

                bool hasDuplicate = false;
                for (int i = 0; i < index; i++)
                {
                    if (numbers[index] == numbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }

                    // 무작위 카드와 배열의 카드 숫자가 일치하지 않으면 인덱스값 증가
                    if (!hasDuplicate)
                        index++;
                }

                int[] guesses = new int[3];
                string[] inputMessages =
                    { "> 첫 번째 숫자를 입력하세요.", "> 두 번째 숫자를 입력하세요.", "> 세 번째 숫자를 입력하세요." };

                while (true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(inputMessages[i]);
                        Console.WriteLine("반드시 숫자를 입력하세요!");
                        guesses[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("> 공격수가 고른 숫자");

                    for (int i = 0; i < 3; i++)
                        Console.WriteLine(guesses[i]);

                    if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
                    {
                        Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
                        continue;
                    }

                    int strikeCount = 0; // 스트라이크 갯수
                    int ballCount = 0; // 볼 갯수

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (guesses[i] == numbers[j])
                            {
                                if (i == j)
                                    strikeCount++;
                                else
                                    ballCount++;
                            }
                        }
                    }
                    Console.Write("스트라이크 ");
                    Console.WriteLine(strikeCount);
                    Console.Write("볼 ");
                    Console.WriteLine(ballCount);
                    Console.Write("아웃 ");
                    Console.WriteLine(3 - strikeCount - ballCount);

                    if (strikeCount == 3)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                }
            }// end of while
        }// end of main
    }
}
