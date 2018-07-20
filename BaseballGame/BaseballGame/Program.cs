using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 환영 메시지 출력 (splash screen)
            ShowWelcomeMessage();

            // 랜덤한 정답 생성한다.
            Answer answer = new Answer();
            answer.Generate();

            Guess guess = new Guess();

            List<HistoryItem> historyItems = new List<HistoryItem>();

            while (true)
            {
                answer.Show();

                // 추측을 입력받는다.
                guess.Input();

                // 입력받은 추측을 출력한다.
                guess.Show();

                // 추측의 유효성을 검사한다.
                if (guess.IsInvalid())
                {
                    Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
                    continue;
                }

                // 결과를 계산한다.
                Result result = new Result();
                result.Calculate(answer, guess);

                // 결과를 출력한다.
                result.Show();

                // 히스토리 출력
                HistoryItem item = new HistoryItem();
                item.Result = 
                    item.Guess = 
                        historyItems.Add(item);

                // 정답이면 게임을 끝낸다.
                if (result.IsFinished())
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }// end of while
        }// end of main


    }
}
