using System;

namespace Puzzle2048
{
	class Puzzle
	{
		private int puzzleSize = 4;
		private int[,] puzzle;
		private Random rand = new Random();		//항상 변하는 랜덤을 위해 초기화
		private int xPos = 0, yPos = 0;

		public void PrintPuzzle()
		{
			for (int i = 0; i < puzzleSize; i++)
			{
				PrintLine();
				for (int j = 0; j < puzzleSize; j++)
				{
					if (puzzle[i, j] == 0)
						Console.Write("| {0, -5}","");
					else
						Console.Write("| {0, -5}", puzzle[i, j]);
				}
				Console.WriteLine("|");
			}
			PrintLine();
		}
		private void PrintLine()
		{
			for (int j = 0; j < puzzleSize; j++)
			{
				Console.Write("-------");
			}
			Console.WriteLine("-");
		}

		public Puzzle()					//생성자
		{
			puzzle = new int[puzzleSize, puzzleSize];	//퍼즐 세팅하고

			for (int i = 0; i < puzzleSize; i++)
			{
				for (int j = 0; j < puzzleSize; j++)
				{
					puzzle[i, j] = 0;			//퍼즐 초기화
				}
			}

			BlockAdd();

		}

		/*
		private void ReadStrToInt()
		{
			string str = Console.ReadLine();
			int n = Convert.ToInt32(str);
		}
		*/

		public void BlockAdd()				//랜덤으로 2라는 블럭을 추가한다.
		{
			int currentRand = rand.Next(0, EmptyBlock());   //이미 무언가 있는 블럭은 제외하고 랜덤
			for (int i = 0; i < puzzleSize; i++)
				for (int j = 0; j < puzzleSize; j++)
				{
					if (currentRand == 0 && puzzle[i, j] == 0)     //퍼즐이 비었는지, 랜덤잡은 위치가 맞는지
					{
						puzzle[i, j] = 2;
						return;
					}
					else if (puzzle[i, j] == 0)		        //퍼즐이 비었다면 현재 랜덤을 깎는다.
					{
						currentRand--;
					}
				}
		}

		private int EmptyBlock()				        //빈 블록 갯수를 리턴
		{
			int emptyblock = 0;
			for (int i = 0; i < puzzleSize; i++)
				for (int j = 0; j < puzzleSize; j++)
					if (puzzle[i, j] == 0)
					{
						emptyblock++;
					}
			return emptyblock;
		}

		private void SearchBlock(int num)			        //특정 번호를 찾아서 x y 저장
		{
			for (int i = 0; i < puzzleSize; i++)
				for (int j = 0; j < puzzleSize; j++)
					if (puzzle[i, j] == num)
					{
						xPos = i;
						yPos = j;
						return;
					}
		}

		public void MoveLeft()
		{
			int temp;
			for (int i = 0; i < puzzleSize; i++)		        //행루프
			{
				int useBlock = 0;
				for (int j = 0; j < puzzleSize; j++)		         //열루프
				{
					bool matchFlag = false;
					if (puzzle[i, j] != 0)			        //퍼즐이 비어있지 않으면
					{
						for (int k = 1; k < puzzleSize - j; k++)	//퍼즐 오른쪽을 탐색
						{
							if (puzzle[i, j] == puzzle[i, j + k])	//같은 퍼즐을 만나면
							{
								temp = puzzle[i, j];
								puzzle[i, j] = 0;
								puzzle[i, useBlock] = temp * 2;	//곱하기 2 해서 앞쪽부터 저장
								useBlock++;
								puzzle[i, j + k] = 0;
								matchFlag = true;
								break;
							}
							else if (puzzle[i, j + k] != 0)
								break;
						}

						if (matchFlag == false)
						{
							temp = puzzle[i, j];			//템프에 넣고
							puzzle[i, j] = 0;			//빈칸으로 정리
							puzzle[i, useBlock] = temp;		//기록
							useBlock++;
						}
					}
				}
			}
		}

		public void MoveRight()
		{
			int temp;
			for (int i = puzzleSize - 1; i >= 0; i--)		        //행루프
			{
				int useBlock = puzzleSize - 1;
				for (int j = puzzleSize - 1; j >= 0 ; j--)		         //열루프
				{
					bool matchFlag = false;
					if (puzzle[i, j] != 0)			        //퍼즐이 비어있지 않으면
					{
						for (int k = 1; k < j + 1; k++)	
						{
							if (puzzle[i, j] == puzzle[i, j - k])	//같은 퍼즐을 만나면
							{
								temp = puzzle[i, j];
								puzzle[i, j] = 0;
								puzzle[i, useBlock] = temp * 2;	//곱하기 2 해서 앞쪽부터 저장
								useBlock--;
								puzzle[i, j - k] = 0;
								matchFlag = true;
								break;
							}
							else if (puzzle[i, j - k] != 0)
								break;
						}

						if (matchFlag == false)
						{
							temp = puzzle[i, j];			//템프에 넣고
							puzzle[i, j] = 0;			//빈칸으로 정리
							puzzle[i, useBlock] = temp;		//기록
							useBlock--;
						}
					}
				}
			}
		}

		public void MoveUp()
		{
			int temp;
			for (int j = 0; j < puzzleSize; j++)		        //행루프
			{
				int useBlock = 0;
				for (int i = 0; i < puzzleSize; i++)		         //열루프
				{
					bool matchFlag = false;
					if (puzzle[i, j] != 0)			        //퍼즐이 비어있지 않으면
					{
						for (int k = 1; k < puzzleSize - i; k++)	//퍼즐 오른쪽을 탐색
						{
							if (puzzle[i, j] == puzzle[i + k, j])	//같은 퍼즐을 만나면
							{
								temp = puzzle[i, j];
								puzzle[i, j] = 0;
								puzzle[useBlock, j] = temp * 2;	//곱하기 2 해서 앞쪽부터 저장
								useBlock++;
								puzzle[i + k, j] = 0;
								matchFlag = true;
								break;
							}
							else if (puzzle[i + k, j] != 0)
								break;
						}

						if (matchFlag == false)
						{
							temp = puzzle[i, j];			//템프에 넣고
							puzzle[i, j] = 0;			//빈칸으로 정리
							puzzle[useBlock, j] = temp;		//기록
							useBlock++;
						}
					}
				}
			}
		}

		public void MoveDown()
		{
			int temp;
			for (int j = puzzleSize - 1; j >= 0; j--)		        //행루프
			{
				int useBlock = puzzleSize - 1;
				for (int i = puzzleSize - 1; i >= 0; i--)		         //열루프
				{
					bool matchFlag = false;
					if (puzzle[i, j] != 0)			        //퍼즐이 비어있지 않으면
					{
						for (int k = 1; k < i + 1; k++)
						{
							if (puzzle[i, j] == puzzle[i - k, j])	//같은 퍼즐을 만나면
							{
								temp = puzzle[i, j];
								puzzle[i, j] = 0;
								puzzle[useBlock, j] = temp * 2;	//곱하기 2 해서 앞쪽부터 저장
								useBlock--;
								puzzle[i - k, j] = 0;
								matchFlag = true;
								break;
							}
							else if (puzzle[i - k, j] != 0)
								break;
						}

						if (matchFlag == false)
						{
							temp = puzzle[i, j];			//템프에 넣고
							puzzle[i, j] = 0;			//빈칸으로 정리
							puzzle[useBlock, j] = temp;		//기록
							useBlock--;
						}
					}
				}
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Puzzle pz = new Puzzle();
			Console.Clear();

			while (true)
			{
				pz.BlockAdd();
				pz.PrintPuzzle();
				ConsoleKeyInfo kb = Console.ReadKey();
				if (kb.Key == ConsoleKey.UpArrow)
				{
					Console.Clear();
					pz.MoveUp();
				}
				else if (kb.Key == ConsoleKey.DownArrow)
				{
					Console.Clear();
					pz.MoveDown();
				}
				else if (kb.Key == ConsoleKey.LeftArrow)
				{
					Console.Clear();
					pz.MoveLeft();
				}
				else if (kb.Key == ConsoleKey.RightArrow)
				{
					Console.Clear();
					pz.MoveRight();
				}


			}


			//while (true)
			//{
			//        pz.BlockAdd();
			//        pz.PrintPuzzle();

			//        string t = Console.ReadLine();
			//        switch (t)
			//        {
			//	case "w":
			//	        Console.Clear();
			//	        pz.MoveUp();
			//	        break;
			//	case "s":
			//	        Console.Clear();
			//	        pz.MoveDown();
			//	        break;
			//	case "d":
			//	        Console.Clear();
			//	        pz.MoveRight();
			//	        break;
			//               case "a":
			//	        Console.Clear();
			//	        pz.MoveLeft();
			//	        break;
			//        }

			//}

		}
	}
}
