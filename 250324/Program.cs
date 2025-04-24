namespace _250324
{
    internal class Program
    {
        class Trainer
        {
            public string name;
            public Monster[] monsters = new Monster[6];

            public Trainer(string name)
            {
                this.name = name;
            }

            public void Add(string name, int level)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] == null)
                    {
                        monsters[i] = new Monster(name, level);
                        Console.WriteLine("{0}가 추가되었습니다.", name);
                        return;
                    }
                }
                Console.WriteLine("더 이상 몬스터를 추가할 수 없습니다.");
            }

            public void Remove(string name)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] != null && monsters[i].name == name)
                    {
                        monsters[i]=null;
                        Console.WriteLine("{0}가 제거되었습니다.", name);
                        return;
                    }
                }
                Console.WriteLine("해당 몬스터를 찾을 수 없습니다.");
            }

            public void PrintAll()
            {
                bool hasMonster = false;
                
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i]!= null)
                    {
                        Console.WriteLine("몬스터 이름 : {0}", monsters[i].name);
                        Console.WriteLine("몬스터 레벨 : {0}", monsters[i].level);
                        hasMonster = true;
                    }
                }
                if (!hasMonster)
                {
                    Console.WriteLine("보유한 몬스터가 없습니다");
                }
            }
        }

        public class Monster
        {
            public string name;
            public int level;

            public Monster(string name, int level)
            {
                this.name = name;
                this.level = level;
            }
            public void Print()
            {
                Console.WriteLine("몬스터 이름 : {0}", this.name);
                Console.WriteLine("몬스터 레벨 : {0}", this.level);
            }
        }

        static void Main(string[] args)
        {
            Trainer trainer;
            Monster monster;
            string name;
            int level;

            Console.WriteLine("플레이어명을 입력하세요.");
            trainer = new Trainer(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("몬스터 추가 = 1, 몬스터 제거 = 2, 몬스터 정보 출력 = 3, 모든 몬스터 출력 = 4, 종료 : 5");
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        
                        Console.WriteLine("몬스터명을 입력하세요.");
                        name = Console.ReadLine();
                        Console.WriteLine("몬스터의 레벨을 입력하세요.");
                        level = int.Parse(Console.ReadLine());
                        trainer.Add(name, level);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("몬스터명을 입력하세요.");
                        name = Console.ReadLine();
                        trainer.Remove(name);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("몬스터명을 입력하세요.");
                        name = Console.ReadLine();
                        bool found = false;
                        for(int i = 0; i < trainer.monsters.Length; i++)
                        {
                            if (trainer.monsters[i]!=null&& trainer.monsters[i].name == name)
                            {
                                trainer.monsters[i].Print();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("해당 몬스터를 찾을 수 없습니다.");
                        }
                        break;
                    case ConsoleKey.D4:
                        trainer.PrintAll();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                }
            }

        }
    }
}
