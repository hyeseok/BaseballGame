using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    // partial 기능은 메인 클래스의 부분클래스 느낌을 준다. 호출은 foo(); 로 한다.
    partial class Program
    {
        /// <summary>
        /// 환영메시지 출력(splash screen)
        /// </summary>
        static void ShowWelcomeMessage()
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
        }

        
    }
}
