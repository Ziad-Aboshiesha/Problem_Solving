namespace _2684._Maximum_Number_of_Moves_in_a_Grid
{
    internal class Program
    {

        public class Solution
        {
            public int MaxMoves(int[][] grid)
            {
                int moves = 0;
                int[][] ints = new int[grid.Length][];
                for (int i = 0; i < grid.Length; i++)
                {
                    ints[i] = new int[grid[i].Length]; 
                }

                //int i = grid.Length - 1; i > 0; i--
                //    int j = grid[i].Length - 1; j >= 0; j--
                for (int i = grid[0].Length - 1;i >= 0; i--)
                {
                    for (int j = grid.Length - 1; j > 0; j--)
                    {
                        if (j!= 0 && grid[j - 1][i-1] < grid[j][i])
                        {
                            ints[j - 1][i - 1] = Math.Max(ints[j - 1][i - 1], ints[j][i] + 1);
                        }
                        if (grid[j][i - 1] < grid[j][i])
                        {
                            ints[j ][i - 1] = Math.Max(ints[j ][i - 1], ints[j][i] + 1);
                        }
                        if (j!= grid.Length - 1 && grid[j + 1][i - 1] < grid[j][i])
                        {
                            ints[j + 1][i - 1] = Math.Max(ints[j + 1][i - 1], ints[j][i] + 1);
                        }
                    }
                }

                for (int i = 0; i < grid[0].Length; i++)
                {
                    moves = Math.Max(moves, ints[i][0]);
                }
                return moves;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxMoves([
            [1000000, 92910, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068],
            [1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096, 1097, 1098, 1099, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118]]));
        }
    }
}
