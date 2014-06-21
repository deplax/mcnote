using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Sand
    {
        int x;          //모래의 x 좌표
        int y;          //모래의 y 좌표

        public Sand(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveLaft()
        {
            x--;
        }
        public void MoveRight()
        {
            x++;
        }
        public void MoveSend()
        {
            y++;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
