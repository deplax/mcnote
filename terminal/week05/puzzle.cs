using System;
class puzzle
{

	public static void ArrPrint(int[, ] arr, int row, int col)
	{
		for(int i = 0; i < row; i++)
		{
			for(int j = 0; j < col * 5 + 1; j++)
				Console.Write("-");
			Console.WriteLine();
			for(int j = 0; j < col; j++)
			{
				if(arr[i, j] == 0)
					Console.Write("|    ");			//옮길 커서칸
				else
					Console.Write(string.Format("| {0:D2} ", arr[i, j]));
			}
			Console.WriteLine("|");
		}
		for(int j = 0; j < col * 5 + 1; j++)
			Console.Write("-");
		Console.WriteLine();
	}

	public static int ReadInt()
	{
		string temp = Console.ReadLine();
		return Convert.ToInt32(temp);
	}

	public static void Move(ref int[, ] arr, int size, ref bool flagq, ref string msg)
	{
		//입력을 받고 움직일 수 있는지 판단
		//움직일 수 없는 블럭 선택시 메세지
		Console.Write("Select a move block : ");
		int mblock = ReadInt();
		int blockx = 0, blocky = 0, zerox = 0, zeroy = 0;
		if(mblock == 777) 		//종료
		{
			msg = "bye";
			flagq = true;
			return; 
		}

		if(1 > mblock || Math.Pow(size, 2) < mblock)		//정상 입력범위 벗어남
		{
			msg = "Input out of range!!";
			//Console.WriteLine("Inout out of range!!");
			return;
		}
		//블럭을 찾아라!
		for(int i = 0; i < size; i++)
		{
			for(int j = 0; j < size; j++)
			{
				if(arr[i, j] == mblock)
				{
					blockx = i;
					blocky = j;
				}else if(arr[i, j] == 0){
					zerox = i;
					zeroy = j;
				}
			}
		}

		int temp;
		if((zerox - blockx == 0 && zeroy - blocky != 0) || (zerox - blockx != 0 && zeroy - blocky == 0))	//움직임 가능 블럭
		{
			for(int i = 1; i < size; i++)
			{
				int ofs;
				if(zerox - blockx == i)			//0기준 up
				{	
					ofs = zerox - blockx;
					temp = arr[zerox, zeroy];
					for(int j = 0; j > -(ofs); j--)
						arr[zerox + j, zeroy] = arr[zerox + j - 1, zeroy];
					arr[zerox - ofs, zeroy] = temp;
				}
			}

			for(int i = -1; i > -(size); i--)
			{
				int ofs;
				if(zerox - blockx == i)			//0기준 down
				{	
					ofs = zerox - blockx;
					temp = arr[zerox, zeroy];
					for(int j = 0; j < -(ofs); j++)
						arr[zerox + j, zeroy] = arr[zerox + j + 1, zeroy];
					arr[zerox - ofs, zeroy] = temp;
				}

			}

			for(int i = 1; i < size; i++)
			{
				int ofs;
				if(zeroy - blocky == i)			//0기준 left
				{	
					ofs = zeroy - blocky;
					temp = arr[zerox, zeroy];
					for(int j = 0; j > -(ofs); j--)
						arr[zerox, zeroy + j] = arr[zerox, zeroy + j - 1];
					arr[zerox, zeroy - ofs] = temp;
				}
			}

			for(int i = -1; i > -(size); i--)
			{
				int ofs;
				if(zeroy - blocky == i)			//0기준 right
				{	
					ofs = zeroy - blocky;
					temp = arr[zerox, zeroy];
					for(int j = 0; j < -(ofs); j++)
						arr[zerox, zeroy + j] = arr[zerox, zeroy + j + 1];
					arr[zerox, zeroy - ofs] = temp;
				}

			}

		}else{
			msg = "Can not move!!";
			//Console.WriteLine("Can not move!!");
		}
	}

	public static void Main(string [] args)
	{
		Console.Write("press puzzle size : ");
		int psize = ReadInt();


		int[, ] arr = new int [psize, psize];
		int num = 0;
		bool flagq = false;
		
		for(int i = 0; i < arr.GetLength(0); i++)
		{
			for(int j = 0; j < arr.GetLength(1); j++)
			{
				arr[i, j] = num;
				num++;
			}
		}

		string msg = "";
		Console.Clear();
		ArrPrint(arr, arr.GetLength(0), arr.GetLength(1));
		
		while(flagq == false)
		{
			Move(ref arr, arr.GetLength(0), ref flagq, ref msg);
			Console.Clear();
			ArrPrint(arr, arr.GetLength(0), arr.GetLength(1));
			if(msg != "")
			{
				Console.WriteLine(msg);
				msg = "";
			}
		}
		
		//Console.WriteLine(arr.GetLength(0));
	}
}
