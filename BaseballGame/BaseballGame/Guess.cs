﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Guess : NumberContainer
    {

        protected override string GetShowText()
        {
            return "> 공격수가 고른 숫자";
        }

        public void Input()
        {
            _numbers = new int[3];

            string[] inputMessages =
                {
                "> 첫 번째 숫자를 입력하세요.",
                "> 두 번째 숫자를 입력하세요.",
                "> 세 번째 숫자를 입력하세요."
                };

            for (int i = 0; i < 3;)
            {
                Console.WriteLine(inputMessages[i]);
                string readLine = Console.ReadLine();
                if (readLine == "")
                {
                    Console.WriteLine("@공백을 입력하지 마세요!\n");
                    continue;
                }
                else
                {
                    _numbers[i] = int.Parse(readLine);
                    if (_numbers[i] > 9)
                    {
                        Console.WriteLine("@한자리 숫자만 입력하세요!\n");
                        continue;
                    }
                }
                i++;
            }
        }

        internal string ToText()
        {
            return "";
        }

        public bool IsInvalid()
        {
            return _numbers[0] == _numbers[1] || _numbers[0] == _numbers[2] || _numbers[1] == _numbers[2];
        }
    }//end of main
}
