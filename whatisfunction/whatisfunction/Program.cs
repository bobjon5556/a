using System;

namespace mine
{
    public class Player
    {
        int x, y;
        string shape = "㉯";
        string message = "";

        public Player(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            Console.SetCursorPosition(x * 2, y);
            Console.Write(shape);
        }

        public Player input(char dir)
        {
            message = "";
            switch (dir)
            {
                case 'w':
                    if (y > 0)
                    {
                        y--;
                        message = "up";
                    }
                    break;

                case 's':
                    if (y + 1 < Map.y)
                    {
                        y++;
                        message = "down";
                    }
                    break;
                case 'a':
                    if (x > 0)
                    {
                        x--;
                        message = "left";
                    }
                    break;
                case 'd':
                    if (x + 1 < Map.x)
                    {
                        x++;
                        message = "right";
                    }
                    break;

                case 'p':
                    message = "flag";
                    break;

                case 'o':
                    message = "enter";
                    break;

                case 'q':
                    message = "quit";
                    break;
            }
            return this;
        }

        public int getx() { return x; }
        public int gety() { return y; }
        public void setx(int x) { this.x = x; }
        public void sety(int y) { this.y = y; }
        public string send()
        {
            return message;
        }
    }

    public class Map
    {
        public static int x, y;
        int mineNum;
        int[,] numMap;
        bool[,] open;
        bool[,] mineMap;
        bool[,] flag;
        int flagnum = 0;
        bool lose = false;

        public Map(int x = 9, int y = 9, int num = 10)
        {
            Map.x = x;
            Map.y = y;
            mineNum = num;
            numMap = new int[y, x];
            mineMap = new bool[y, x];
            open = new bool[y, x];
            flag = new bool[y, x];

            Random r = new Random();

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    numMap[i, j] = 0;
                    mineMap[i, j] = open[i, j] = false;
                }
            }

            for (int i = 0; i < mineNum; i++)
            {
                int sx = r.Next(0, x);
                int sy = r.Next(0, y);

                if (mineMap[sy, sx] == false)
                {
                    mineMap[sy, sx] = true;
                    numMap[sy, sx] = -1;

                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            if (dx == 0 && dy == 0) continue;

                            int lx = sx + dx;
                            int ly = sy + dy;
                            if (lx >= 0 && lx < x && ly >= 0 && ly < y)
                            {
                                if (mineMap[ly, lx] == true) { continue; }
                                numMap[ly, lx] += 1;
                            }
                        }
                    }
                    continue;
                }
                else { i--; }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
        void flagShow()
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (flag[i, j] == true)
                    {
                        Console.SetCursorPosition(j * 2, i);
                        Console.Write("♠");
                    }
                }
            }
        }
        public void show()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (open[i, j])
                    {
                        Console.SetCursorPosition(j * 2, i);
                        Console.Write(selectShape(numMap[i, j]));
                    }
                    else { }
                }
            }
        }

        void printShape(int x, int y)
        {
            Console.SetCursorPosition(x * 2, y);
            Console.Write(selectShape(numMap[y, x]));
        }

        string selectShape(int s)
        {
            string[] shape = {
                "□","①","②","③","④","⑤","⑥","⑦","⑧"
            };
            switch (s)
            {
                case -1:
                    return "⊙";
                case -2:
                    return "★";
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 0:
                    return shape[s];
            }
            return "■";
        }

        public void invest0(int sy, int sx)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;

                    int lx = sx + dx;
                    int ly = sy + dy;
                    if (lx >= 0 && lx < x && ly >= 0 && ly < y)
                    {
                        if (open[ly, lx] == true) continue;
                        if (flag[ly, lx] == true) flag[ly, lx] = false;
                        open[ly, lx] = true;
                        if (numMap[ly, lx] == 0)
                        {
                            invest0(ly, lx);

                        }
                        printShape(lx, ly);
                    }
                }
            }
        }

        public bool investFlag(Player p)
        {
            int sum = 0;
            int opened = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {

                    if (dx == 0 && dy == 0) continue;
                    int lx = p.getx() + dx;
                    int ly = p.gety() + dy;

                    if (availablePoint(lx, ly))
                    {
                        if (flag[ly, lx] == true)
                        {
                            sum++;
                        }
                        if (open[ly, lx]) opened++;
                    }
                }
            }
            if (opened == 8 - numMap[p.gety(), p.getx()])
            {
                return false;
            }
            if (sum == numMap[p.gety(), p.getx()])
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        int lx = p.getx() + dx;
                        int ly = p.gety() + dy;
                        if (dx == 0 && dy == 0) continue;

                        if (availablePoint(lx, ly))
                        {
                            if (!flag[ly, lx] && !open[ly, lx])
                            {
                                open[ly, lx] = true;
                                Console.SetCursorPosition(lx * 2, ly);
                                Console.Write(selectShape(numMap[ly, lx]));
                            }
                            else { continue; }

                            if (numMap[ly, lx] == 0)
                            {
                                invest0(ly, lx);
                            }
                            else if (mineMap[ly, lx] == true)
                            {
                                for (int i = 0; i < y; i++)
                                {
                                    for (int j = 0; j < x; j++)
                                    {
                                        open[i, j] = true;
                                        if (flag[i, j] == true && numMap[i, j] != -1)
                                        {
                                            flag[i, j] = false;
                                        }
                                    }
                                }
                                lose = true;
                                return true;
                            }
                        }
                    }
                }
            }
            lose = false;
            return false;
        }

        public bool winCheck()
        {
            int sum = 0;
            for (int i = 0; i < Map.y; i++)
            {
                for (int j = 0; j < Map.x; j++)
                {
                    if (open[i, j] == false) sum++;
                }
            }

            if (mineNum == sum)
            {
                return true;
            }
            else return false;
        }

        public bool availablePoint(int x, int y)
        {
            if (x >= 0 && x < Map.x && y >= 0 && y < Map.y)
            {
                return true;
            }
            else return false;
        }

        public bool receive(Player p)
        {
            int dx = 0, dy = 0;
            bool move = false;

            switch (p.send())
            {
                case "left":
                    dx = -1;
                    move = true;
                    break;
                case "right":
                    dx = 1;
                    move = true;
                    break;
                case "up":
                    dy = -1;
                    move = true;
                    break;
                case "down":
                    dy = 1;
                    move = true;
                    break;
                case "enter":
                    if (open[p.gety(), p.getx()] == true && numMap[p.gety(), p.getx()] != 0)
                    {
                        investFlag(p);
                    }
                    else if (!flag[p.gety(), p.getx()])
                    {
                        open[p.gety(), p.getx()] = true;
                        printShape(p.getx(), p.gety());
                    }
                    else { return true; }

                    if (numMap[p.gety(), p.getx()] == 0)
                    {
                        invest0(p.gety(), p.getx());
                    }
                    else if (numMap[p.gety(), p.getx()] == -1 || lose)
                    {
                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                open[i, j] = true;
                                if (flag[i, j] == true && numMap[i, j] != -1)
                                {
                                    flag[i, j] = false;
                                }
                            }
                        }
                        show();
                        Console.SetCursorPosition(35, 10);
                        Console.Write("Game Over");
                        Console.SetCursorPosition(35, 11);
                        Console.Write("Please press Enter");
                        while (Console.ReadKey(true).KeyChar != (char)13) { }
                        return false;
                    }
                    if (winCheck())
                    {
                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                open[i, j] = true;
                                flag[i, j] = false;
                                if (numMap[i, j] == -1)
                                {
                                    numMap[i, j] = -2;
                                }
                            }
                        }
                        show();
                        Console.SetCursorPosition(35, 10);
                        Console.Write("You Win!!");
                        Console.SetCursorPosition(35, 11);
                        Console.Write("Please press Enter");
                        while (Console.ReadKey(true).KeyChar != (char)13) { };
                        return false;
                    }

                    break;

                case "flag":
                    if (!open[p.gety(), p.getx()])
                        switch (flag[p.gety(), p.getx()])
                        {
                            case true:
                                flag[p.gety(), p.getx()] = false;
                                flagnum--;
                                break;
                            case false:
                                flag[p.gety(), p.getx()] = true;
                                flagnum++;
                                break;
                        }
                    Console.SetCursorPosition(70, 24);
                    Console.Write("     ");
                    Console.SetCursorPosition(72, 24);
                    Console.Write(mineNum - flagnum);
                    break;
                case "quit":
                    return false;
            }
            if (move)
            {
                Console.SetCursorPosition((p.getx() - dx) * 2, (p.gety() - dy));

                if (!open[p.gety() - dy, p.getx() - dx])
                {
                    if (flag[p.gety() - dy, p.getx() - dx] == false)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("♠");
                    }
                }
                else Console.Write(selectShape(numMap[p.gety() - dy, p.getx() - dx]));

                p.show();
            }
            return true;
        }
    }

    public class main
    {
        public static void copyRight()
        {
            Console.SetCursorPosition(0, 24);
            Console.Write("Made by BSY");
        }
        public static void Main(string[] args)
        {
            int select;
            Player p = new Player();
            Map map = new Map();
            Console.CursorVisible = false;
            int minenum = 0;
            while (true)
            {
                Console.Clear();
                copyRight();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("지뢰찾기<ver 1.0>");
                Console.WriteLine("난이도를 설정해주세요");
                Console.WriteLine("1.쉬움(9x9) 2.보통(19x19) 3.어려움(39x24) 4.커스텀 5.설명 6.종료");

                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        minenum = 10;
                        map = new Map(9, 9, 10);
                        break;
                    case 2:
                        minenum = 51;
                        map = new Map(19, 19, 51);
                        break;
                    case 3:
                        minenum = 111;
                        map = new Map(39, 24, 111);
                        break;
                    case 4:
                        Console.WriteLine("가로(9~39): ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("세로(9~24): ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        minenum = x * y / 7;
                        map = new Map(x, y, minenum);
                        break;
                    case 5:
                        int pos = 6;
                        Console.SetCursorPosition(0, pos++);
                        Console.Write("w,s,a,d: 방향키");
                        Console.SetCursorPosition(0, pos++);
                        Console.Write("o: 선택, p:플래그");
                        Console.SetCursorPosition(0, pos++);
                        Console.Write("q: 나가기");
                        Console.SetCursorPosition(0, pos++);
                        Console.Write("숫자를 누르면 플래그 숫자와 동일 시 주변부를 엽니다");
                        Console.SetCursorPosition(20, pos++);
                        Console.Write("Please press Enter");
                        while (Console.ReadKey(true).KeyChar != (char)13) { };
                        continue;
                    case 6:
                        return;

                }
                p.setx(Map.x / 2);
                p.sety(Map.y / 2);
                Console.Clear();

                for (int i = 0; i < Map.y; i++)
                {
                    for (int j = 0; j < Map.x; j++)
                    {
                        Console.Write("■");
                    }
                    Console.WriteLine();
                }
                p.show();

                Console.SetCursorPosition(55, 24);
                Console.Write("남은 지뢰 갯수: {0}", minenum);

                while (true)
                {
                    if (map.receive(p.input(Console.ReadKey(true).KeyChar)) == false)
                    {
                        break;
                    }
                }
            }
        }
    }
}

