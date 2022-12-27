public class Algoritsm

{
    internal static class DefineConstants
    {
        public const int UP = 65;
        public const int DOWN = 66;
        public const int LEFT = 68;
        public const int RIGHT = 67;
        public const int N = 3;
        public const int M = 3;
    }
    private int GetInvCount(int[] arr)
    {
        int inv_count = 0;
        for (int i = 0; i < DefineConstants.N * DefineConstants.N - 1; i++)
        {
            for (int j = i + 1; j < DefineConstants.N * DefineConstants.N; j++)
            {
                // count pairs(i, j) such that i appears
                // before j, but i > j.
                if (arr[j] != 0 && arr[i] != 0 && arr[i] > arr[j])
                {
                    inv_count++;
                }
            }
        }
        return inv_count;
    }

    // find Position of blank from bottom
    private int FindXPosition(int[][] puzzle)
    {
        // start from bottom-right corner of matrix
        for (int i = DefineConstants.N - 1; i >= 0; i--)
        {
            for (int j = DefineConstants.N - 1; j >= 0; j--)
            {
                if (puzzle[i][j] == 0)
                {
                    return DefineConstants.N - i;
                }
            }
        }return 0;
    }

    // This function returns true if given
    // instance of N*N - 1 puzzle is solvable
   
}

