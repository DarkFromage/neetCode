namespace neetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ManagerEncodeAndDecodeStrings();
            //ManageProductExceptSelf();
            //ManageValidSudoku();
            //ManageLongestConsecutiveSequence();
            //ManageIsPalindrome();
            //ManageTwoSum();
            ManageThreeSum();
        }

        public static void ManagerEncodeAndDecodeStrings()
        {
            List<string> InputOne = new List<string>([""]);
            List<string> InputTwo = new List<string>(["we", "say", ":", "yes"]);

            EncodeAndDecodeStrings encodeAndDecodeStrings = new EncodeAndDecodeStrings();

            var _one = encodeAndDecodeStrings.Encode(InputOne);
            foreach(string str in encodeAndDecodeStrings.Decode(_one))
            {
                Console.Write(str + " - "); 
            }
            Console.WriteLine("");

            var _two = encodeAndDecodeStrings.Encode(InputTwo);
            Console.WriteLine(_two);
            foreach (string str in encodeAndDecodeStrings.Decode(_two))
            {
                Console.Write(str + " - ");
            }
            Console.WriteLine("");
        }

        public static void ManageProductExceptSelf()
        {
            int[] inputOne = { 1, 2, 4, 6 };
            int[] inputTwo = { -1, 0, 1, 2, 3 };

            ProductExceptSelfSolution productExceptSelfSolution = new ProductExceptSelfSolution();

            var _one = productExceptSelfSolution.ProductExceptSelf(inputOne);
            foreach (int i in _one)
            {
                Console.Write(i + ", ");
            }

            var _two = productExceptSelfSolution.ProductExceptSelf(inputTwo);
            foreach (int i in _two)
            {
                Console.Write(i + ", ");
            }
        }

        public static void ManageValidSudoku()
        {
            char[][] inputOne = new char[][]
            {
                ['1','2','.','.','3','.','.','.','.'],
                ['4','.','.','5','.','.','.','.','.'],
                ['.','9','8','.','.','.','.','.','3'],
                ['5','.','.','.','6','.','.','.','4'],
                ['.','.','.','8','.','3','.','.','5'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','.','.','.','.','.','2','.','.'],
                ['.','.','.','4','1','9','.','.','8'],
                ['.','.','.','.','8','.','.','7','9']
            };
            char[][] inputTwo = new char[][]
            {
                ['1','2','.','.','3','.','.','.','.'],
                ['4','.','.','5','.','.','.','.','.'],
                ['.','9','1','.','.','.','.','.','3'],
                ['5','.','.','.','6','.','.','.','4'],
                ['.','.','.','8','.','3','.','.','5'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','.','.','.','.','.','2','.','.'],
                ['.','.','.','4','1','9','.','.','8'],
                ['.','.','.','.','8','.','.','7','9']
            };

            ValidSudokuSolution validSudokuSolution = new ValidSudokuSolution();

            var _one = validSudokuSolution.IsValidSudoku(inputOne);
            Console.WriteLine(_one.ToString());
            var _two = validSudokuSolution.IsValidSudoku(inputTwo);
            Console.WriteLine(_two.ToString());

        }

        public static void ManageLongestConsecutiveSequence()
        {
            int[] inputOne = [2,20,4,10,3,5];
            int[] inputTwo = [0,3,2,5,4,6,1,1];

            LongestConsecutiveSequenceSolution longestConsecutiveSequenceSolution = new LongestConsecutiveSequenceSolution();
            var _resultOne = longestConsecutiveSequenceSolution.LongestConsecutiveSequence(inputOne);
            Console.WriteLine(_resultOne.ToString());
            var _resultTwo = longestConsecutiveSequenceSolution.LongestConsecutiveSequence(inputTwo);
            Console.WriteLine(_resultTwo.ToString());
        }

        public static void ManageIsPalindrome()
        {
            string inputOne = "Was it a car or a cat I saw?";
            string inputTwo = "tab a cat";

            IsPalindromeSolution isPalindromeSolution = new IsPalindromeSolution();
            var result = isPalindromeSolution.IsPalindrome(inputOne);
            Console.WriteLine(result);
            result = isPalindromeSolution.IsPalindrome(inputTwo);
            Console.WriteLine(result);
        }

        public static void ManageTwoSum()
        {
            int[] input = { 1, 2, 3, 4 };
            int target = 6;

            TwoSumSolution twoSumSolution = new TwoSumSolution();
            var result = twoSumSolution.TwoSum(input, target);
            foreach(int i in result) Console.Write(i + " ");
        }

        public static void ManageThreeSum()
        {
            int[] inputOne = [-1, 0, 1, 2, -1, -4];
            int[] inputTwo = [0, 1, 1];
            int[] inputThree = [0, 0, 0];

            ThreeSumSolution threeSumSolution = new ThreeSumSolution();
            var _result = threeSumSolution.ThreeSum(inputOne);
            foreach (List<int> list in _result)
            {
                foreach (int i in list) Console.Write(i + " ");
                Console.WriteLine();
            }
            
        }


    }
}
