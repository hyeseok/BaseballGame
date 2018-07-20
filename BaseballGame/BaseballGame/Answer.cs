using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Answer :  NumberContainer
    {
        protected override string GetShowText()
        {
            return "> 컴퓨터가 생성한 정답";
        }

        public void Generate()
        {
            Random random = new Random();

            _numbers = new int[3];
            int index = 0; //증가를 위한 변수

            // 3개의 숫자를 받기위한 반복제어문.
            while (index < 3)
            {
                _numbers[index] = random.Next(1, 10); // 1~10까지의 숫자를 랜덤하게 배열에 담는다.
                bool hasDuplicate = false; // 랜덤으로 입력된 숫자를 확인하기 위한 불린 변수

                for (int i = 0; i < index; i++)
                {
                    if (_numbers[index] == _numbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }
                // 무작위 카드와 배열의 카드 숫자가 일치하지 않으면 인덱스값 증가
                if (!hasDuplicate)
                    index++;

            }// end of while
        }
    }// end of class
}
