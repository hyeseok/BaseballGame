using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    abstract class NumberContainer
    {
        protected int[] _numbers;

        public int Get(int index)
        {
            return _numbers[index];
        }

        protected abstract string GetShowText();
        public void Show()
        {
            Console.WriteLine(GetShowText());
            //Console.WriteLine("> 컴퓨터가 생성한 정답");

            for (int i = 0; i < 3; i++)
                Console.WriteLine(_numbers[i]);
        }
    }// end of class
}
