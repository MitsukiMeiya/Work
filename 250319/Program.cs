using System;
using System.Collections.Generic;

namespace _250319
{
    class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }

        static bool gameOver = false;
        static Position playerPos;
        static char[,] map;
        static int stage = 0;
        static List<char[,]> stages = new List<char[,]>();
        static List<Position> startPositions = new List<Position>();

        static void Main(string[] args)
        {
            Stages();
            Start();

            while (!gameOver)
            {
                Render();
                ConsoleKey key = Input();
                Restart(key);
                Update(key);
            }
            End();
        }

        // 여러 개의 스테이지와 초기 플레이어 위치 저장
        static void Stages()
        {
            // 스테이지 1
            stages.Add(new char[,]
            {
                { '▒', '▒', '▒', '▒', '▒', '▒', 'R'},
                { '▒', ' ', '□', '■', ' ', '▒', '='},
                { '▒', '□', ' ', ' ', ' ', '▒', '재'},
                { '▒', '■', ' ', ' ', '□', '▒', '시'},
                { '▒', ' ', ' ', ' ', '■', '▒', '작'},
                { '▒', ' ', '■', '□', ' ', '▒', ' '},
                { '▒', '▒', '▒', '▒', '▒', '▒', ' '},

            });
            startPositions.Add(new Position { x = 3, y = 2 });
             // 스테이지 1의 플레이어 시작 위치

            // 스테이지 2
            stages.Add(new char[,]
            {
                { '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', 'R'},
                { '▒', '□', ' ', ' ', '□', ' ', ' ', '□', '▒', '='},
                { '▒', ' ', '■', ' ', '■', ' ', '■', ' ', '▒', '재'},
                { '▒', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '▒', '시'},
                { '▒', '□', '■', ' ', ' ', ' ', '■', '□', '▒', '작'},
                { '▒', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '▒', ' '},
                { '▒', ' ', '■', ' ', '■', ' ', '■', ' ', '▒', ' '},
                { '▒', '□', ' ', ' ', '□', ' ', ' ', '□', '▒', ' '},
                { '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', ' '},

            });
            startPositions.Add(new Position { x = 4, y = 4 }); // 스테이지 2의 플레이어 시작 위치

            // 스테이지 3
            stages.Add(new char[,]
            {
                { '▒', '▒', '▒', '▒', ' ', ' ', 'R'},
                { '▒', ' ', '□', '▒', ' ', ' ', '='},
                { '▒', ' ', ' ', '▒', '▒', '▒', '재'},
                { '▒', '▣', ' ', ' ', ' ', '▒', '시'},
                { '▒', ' ', ' ', '■', ' ', '▒', '작'},
                { '▒', ' ', ' ', '▒', '▒', '▒', ' '},
                { '▒', '▒', '▒', '▒', ' ', ' ', ' '},
            });
            startPositions.Add(new Position { x = 2, y = 3 }); // 스테이지 3의 플레이어 시작 위치

            // 스테이지 4
            stages.Add(new char[,]
            {
                { '▒', '▒', '▒', '▒', '▒', '▒', '▒', 'R'},
                { '▒', '□', ' ', '□', ' ', '□', '▒', '='},
                { '▒', ' ', '■', '■', '■', ' ', '▒', '재'},
                { '▒', '□', '■', ' ', '■', '□', '▒', '시'},
                { '▒', ' ', '■', '■', '■', ' ', '▒', '작'},
                { '▒', '□', ' ', '□', ' ', '□', '▒', ' '},
                { '▒', '▒', '▒', '▒', '▒', '▒', '▒', ' '},

            });
            startPositions.Add(new Position { x = 3, y = 3 }); // 스테이지 4의 플레이어 시작 위치
        }

        // 게임 시작
        static void Start()
        {
            Console.Clear();
            Console.CursorVisible = false;

            if (stage >= stages.Count)
            {
                gameOver = true;
                return;
            }

            map = (char[,])stages[stage].Clone();
            playerPos = startPositions[stage]; // 현재 스테이지의 시작 위치 적용
        }

        // 맵과 플레이어 출력
        static void Render()
        {
            Console.SetCursorPosition(0, 0);
            PrintMap();
            PrintPlayer();
        }

        // 맵 출력
        static void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        // 플레이어 출력
        static void PrintPlayer()
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("♥");
            Console.ResetColor();
        }

        // 키 입력
        static ConsoleKey Input()
        {
            return Console.ReadKey(true).Key;
        }

        // 게임 업데이트
        static void Update(ConsoleKey key)
        {
            Move(key);

            if (IsClear())
            {
                stage++;
                Start(); // 다음 스테이지로 이동
            }
        }

        // 움직임 처리
        static void Move(ConsoleKey key)
        {
            Position movePos;
            Position overPos;

            switch (key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    movePos.x = playerPos.x;
                    movePos.y = playerPos.y - 1;
                    overPos.x = playerPos.x;
                    overPos.y = playerPos.y - 2;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    movePos.x = playerPos.x;
                    movePos.y = playerPos.y + 1;
                    overPos.x = playerPos.x;
                    overPos.y = playerPos.y + 2;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    movePos.x = playerPos.x - 1;
                    movePos.y = playerPos.y;
                    overPos.x = playerPos.x - 2;
                    overPos.y = playerPos.y;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    movePos.x = playerPos.x + 1;
                    movePos.y = playerPos.y;
                    overPos.x = playerPos.x + 2;
                    overPos.y = playerPos.y;
                    break;
                default:
                    return;
            }

            if (map[movePos.y, movePos.x] == '■')
            {
                if (map[overPos.y, overPos.x] == '□')
                {
                    map[overPos.y, overPos.x] = '▣';
                    map[movePos.y, movePos.x] = ' ';
                    playerPos.x = movePos.x;
                    playerPos.y = movePos.y;
                }
                else if (map[overPos.y, overPos.x] == ' ')
                {
                    map[overPos.y, overPos.x] = '■';
                    map[movePos.y, movePos.x] = ' ';
                    playerPos.x = movePos.x;
                    playerPos.y = movePos.y;
                }
            }
            else if (map[movePos.y, movePos.x] == '▣')
            {
                if (map[overPos.y, overPos.x] == '□')
                {
                    map[overPos.y, overPos.x] = '▣';
                    map[movePos.y, movePos.x] = '□';
                    playerPos.x = movePos.x;
                    playerPos.y = movePos.y;
                }
                else if (map[overPos.y, overPos.x] == ' ')
                {
                    map[overPos.y, overPos.x] = '■';
                    map[movePos.y, movePos.x] = '□';
                    playerPos.x = movePos.x;
                    playerPos.y = movePos.y;
                }
            }
            else if (map[movePos.y, movePos.x] == ' ' || map[movePos.y, movePos.x] == '□')
            {
                playerPos.x = movePos.x;
                playerPos.y = movePos.y;
            }
            else if (map[movePos.y, movePos.x] == '▒')
            { 

            }
        }

        // 클리어 여부 판단
        static bool IsClear()
        {
            foreach (char tile in map)
            {
                if (tile == '□') return false;
            }
            return true;
        }

        // 게임 재시작 (현재 스테이지를 초기화)
        static void Restart(ConsoleKey key)
        {
            if (key == ConsoleKey.R)
            {
                Console.Clear();
                Start();
                Render();
            }
        }

        // 게임 종료
        static void End()
        {
            Console.Clear();
            Console.WriteLine("축하합니다! 모든 스테이지를 클리어했습니다.");
        }
    }
}
