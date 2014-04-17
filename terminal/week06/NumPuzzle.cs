using System;

public class NumPuzzle
{	
	public string name;
	private int[,] mData;
	private int mSize;
	private int xZero, yZero;
	private int xBlock, yBlock;

	//initialze all.
	public void Init(int size)  
	{
		mSize = size;
		mData = new int[size, size];
		for (int i = 0; i < size; i++)
			for (int j = 0; j < size; j++)
				mData[i, j] = i * size + j + 1;
		mData[size - 1, size - 1] = 0;
		xZero = yZero = size - 1;
		xBlock = yBlock = -1;
	}

	//return all the number sequences
	public string FindMove()			//움직일 수 있는 블럭 찾기
	{
		string ret = "";
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (IsMove(i, j) == true)
				{
					ret = ret + mData[i, j] + " ";
				}
			}
		}
		return ret;
	}

	/**
	 * If possible to move, move the number
	 * return true if success, else return false
	 */
	public bool Move(int num)			//움직임이 가능한지
	{
		ZeroLocation();
		BlockLocation(num);

		swap(ref mData[xZero, yZero], ref mData[xBlock, yBlock]);

		return true;
	}

	private void ZeroLocation()			//0은 어디?
	{
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i, j] == 0)
				{
					xZero = i;
					yZero = j;
					return;
				}
			}
		}
	}

	private void BlockLocation(int num)			//0은 어디?
	{
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i, j] == num)
				{
					xBlock = i;
					yBlock = j;
					return;
				}
			}
		}
	}

	private bool IsMove(int row, int col)
	{
		ZeroLocation();
		if (!IsValid(row, col))
			return false;
		if ((xZero - 1 == row && yZero == col) || (xZero + 1 == row && yZero == col) || (xZero == row && yZero - 1 == col) || (xZero == row && yZero + 1 == col))
			return true;
		return false;
	}

	//check whether row and col values are in valid range
	//0 <= row, col < mSize
	private bool IsValid(int row, int col)			        //움직일 수 없는 공간은 아닌지
	{
		return (0 <= row && 0 <= col && row < mSize && col < mSize);
	}

	private void swap(ref int a,  ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}

	public void PrintPuzzle()
	{
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i, j] == 0)
					Console.Write("[]  ");
				else
					Console.Write("{0, -3} ",mData[i, j]);
			}
			Console.WriteLine();
		}
	}
}

class Test
{
	static void Main()
	{
		int num;
		NumPuzzle np = new NumPuzzle();
		np.Init(3);

		while (true)
		{
			Console.Clear();
			np.PrintPuzzle();
			Console.WriteLine("움직일 수 있는 블럭 : " + np.FindMove());
			num = Read(Console.ReadLine());
			if (num < 0)
				break;
			np.Move(num);

		}
	}

	static int Read(string msg)
	{
		return int.Parse(msg);
	}

	static void Fail(string msg)
	{
		Console.WriteLine(msg);
		Environment.Exit(1);
	}
}
