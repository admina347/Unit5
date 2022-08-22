using System;

class MainClass {
  public static void Main (string[] args) {
		
		var arr = new int[] { 1, 2,3 };
		BigDataOperation(arr);

		Console.WriteLine(arr[0]);

  }


	static void BigDataOperation(int[] arr)
	{
		arr[0] = 4;
	}

}
