using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    //METHODS TO TEST

    // TAKS 2  START <=================================================================
    //subtraction methods
    #region subtraction
    public static void IntSubtract(dynamic parameter = null)
    {
        int val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 13371337 - 1;
        }
    }

    public static void LongSubtract(dynamic parameter = null)
    {
        long val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 13371337L - 1L;
        }
    }

    public static void FloatSubtract(dynamic parameter = null)
    {
        float val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 13371337f - 1f;
        }
    }

    public static void DoubleSubtract(dynamic parameter = null)
    {
        double val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 13371337d - 1d;
        }
    }

    public static void DecimalSubtract(dynamic parameter = null)
    {
        decimal val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 13371337m - 1m;
        }
    }
    #endregion

    //addition methods
    #region addition
    public static void IntAdd(dynamic parameter = null)
    {
        int val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 12 + 1;
        }
    }

    public static void LongAdd(dynamic parameter = null)
    {
        long val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 12L + 1L;
        }
    }

    public static void FloatAdd(dynamic parameter = null)
    {
        float val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 12f + 1f;
        }
    }

    public static void DoubleAdd(dynamic parameter = null)
    {
        double val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 12d + 1d;
        }
    }

    public static void DecimalAdd(dynamic parameter = null)
    {
        decimal val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 12m + 1m;
        }
    }
    #endregion

    //increment methods
    #region increment
    public static void IntIncrement(dynamic parameter = null)
    {
        int val = 0;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val++;
        }
    }

    public static void LongIncrement(dynamic parameter = null)
    {
        long val = 0;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val++;
        }
    }

    public static void FloatIncrement(dynamic parameter = null)
    {
        float val = 0;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val++;
        }
    }

    public static void DoubleIncrement(dynamic parameter = null)
    {
        double val = 0;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val++;
        }
    }

    public static void DecimalIncrement(dynamic parameter = null)
    {
        decimal val = 0;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val++;
        }
    }
    #endregion

    //multiply
    #region multiply
    public static void IntMult(dynamic parameter = null)
    {
        int val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337 * 1337;
        }
    }

    public static void LongMult(dynamic parameter = null)
    {
        long val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337L * 1337L;
        }
    }

    public static void FloatMult(dynamic parameter = null)
    {
        float val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337f * 1337f;
        }
    }

    public static void DoubleMult(dynamic parameter = null)
    {
        double val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337d * 1337d;
        }
    }

    public static void DecimalMult(dynamic parameter = null)
    {
        decimal val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337m * 1337m;
        }
    }
    #endregion

    //divide
    #region divide
    public static void IntDiv(dynamic parameter = null)
    {
        int val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337 / 1337;
        }
    }

    public static void LongDiv(dynamic parameter = null)
    {
        long val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337L / 1337L;
        }
    }

    public static void FloatDiv(dynamic parameter = null)
    {
        float val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337f / 1337f;
        }
    }

    public static void DoubleDiv(dynamic parameter = null)
    {
        double val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337d / 1337d;
        }
    }

    public static void DecimalDiv(dynamic parameter = null)
    {
        decimal val;

        for (int counter = 1; counter <= 10000; counter++)
        {
            val = 1337m / 1337m;
        }
    }
    #endregion

    //TASK 3 START <=====================================================================
    //SQRT
    #region sqrt
    public static void FloatSqrt(dynamic parameter)
    {
        float val = 1337f;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Sqrt(val);
        }
    }

    public static void DoubleSqrt(dynamic parameter)
    {
        double val = 1337d;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Sqrt(val);
        }
    }

    public static void DecimalSqrt(dynamic parameter)
    {
        decimal val = 1337m;

        for (int counter = 1; counter <= 10000; counter++)
        {
            //needs cast T_T there is no point to have sqrt from decimal lol
            Math.Sqrt((double)val);
        }
    }
    #endregion

    //SIN
    #region SIN
    public static void FloatSin(dynamic parameter)
    {
        float val = 1337f;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Sin(val);
        }
    }

    public static void DoubleSin(dynamic parameter)
    {
        double val = 1337d;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Sin(val);
        }
    }

    public static void DecimalSin(dynamic parameter)
    {
        decimal val = 1337m;

        for (int counter = 1; counter <= 10000; counter++)
        {
            //needs cast T_T there is no point to have sin from decimal lol
            Math.Sin((double)val);
        }
    }
    #endregion

    //ln
    #region ln
    public static void FloatLn(dynamic parameter)
    {
        float val = 1337f;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Log(val, Math.E);
        }
    }

    public static void DoubleLn(dynamic parameter)
    {
        double val = 1337d;

        for (int counter = 1; counter <= 10000; counter++)
        {
            Math.Log(val, Math.E);
        }
    }

    public static void DecimalLn(dynamic parameter)
    {
        decimal val = 1337m;

        for (int counter = 1; counter <= 10000; counter++)
        {
            //needs cast T_T there is no point to have ln from decimal lol
            Math.Log((double)val, Math.E);
        }
    }
    #endregion

    //TASK 4 START <=======================================================================

    //QUICK SORT
    #region QuickSort
    public static void Quicksort<T>(T[] inputArray, int startIndex, int endIndex) where T : IComparable<T>
    {
        int leftSelector = startIndex; //searches for elements bigger than the pivot
        int rightSelector = endIndex; //searches for elements smaller than the pivot

        //T pivot = inputArray[(startIndex + endIndex) / 2];

        Random pivotIndexGenerator = new Random();
        int pivotIndex = pivotIndexGenerator.Next(startIndex, endIndex + 1);

        T pivot = inputArray[pivotIndex];

        while (leftSelector <= rightSelector)
        {
            while (inputArray[leftSelector].CompareTo(pivot) < 0)
            {
                leftSelector++;
            }

            while (inputArray[rightSelector].CompareTo(pivot) > 0)
            {
                rightSelector--;
            }

            if (leftSelector <= rightSelector)
            {
                // Swap
                T swapper = inputArray[leftSelector];
                inputArray[leftSelector] = inputArray[rightSelector];
                inputArray[rightSelector] = swapper;

                leftSelector++;
                rightSelector--;
            }
        }

        // Recursive calls
        if (startIndex < rightSelector)
        {
            Quicksort(inputArray, startIndex, rightSelector);
        }

        if (leftSelector < endIndex)
        {
            Quicksort(inputArray, leftSelector, endIndex);
        }
    }

    public static void QuickSortCaller(dynamic parameters)
    {
        Quicksort(parameters.Array, parameters.StartIndex, parameters.EndIndex);
    }
    #endregion

    //SelectionSort
    #region SelectionSort
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        int size = arr.Length;
        int min = 0;

        for (int i = 0; i < size; i++)
        {
            min = i;

            for (int j = i; j < size; j++)
            {
                if (arr[min].CompareTo(arr[j]) > 0)
                {
                    min = j; 
                }
            }

            T swapper;
            swapper = arr[i];
            arr[i] = arr[min];
            arr[min] = swapper;
        }
    }

    public static void SelectionSortCaller(dynamic array)
    {
        SelectionSort(array);
    }
    #endregion

    #region InsertionSort
    public static void InsertionSort<T>(T[] inputArray) where T : IComparable<T>
    {
        for (int i = 1; i < inputArray.Length; i++)
        {
            T temp = inputArray[i];

            int j = i - 1;

            while ((j > -1) && (inputArray[j].CompareTo(temp) > 0))
            {

                T tempo = inputArray[j + 1];

                inputArray[j + 1] = inputArray[j];

                inputArray[j] = tempo;

                j = j - 1;
            }
        }
    }

    public static void InsertionSortCaller(dynamic inputArray)
    {
        InsertionSort(inputArray);
    }
    #endregion

    static void Main(string[] args)
    {
        Task02Executor();

        //Task03Executor();

        //you may need to wait a bit for this one lol
        //Task04Executor();
    }

    public static void Task02Executor()
    {
        Console.WriteLine("Executing task 2");
        Console.WriteLine();
        Console.WriteLine();

        Testable intSubTest = new Testable(IntSubtract);
        TestableFragment intSub = new TestableFragment("10 000 Int subtractions", intSubTest, 200, 200);
        intSub.Test();
        Console.WriteLine(intSub);

        Testable longSubTest = new Testable(LongSubtract);
        TestableFragment longSub = new TestableFragment("10 000 Long subtractions", longSubTest, 200, 200);
        longSub.Test();
        Console.WriteLine(longSub);

        Testable floatSubTest = new Testable(FloatSubtract);
        TestableFragment floatSub = new TestableFragment("10 000 Float subtractions", floatSubTest, 200, 200);
        floatSub.Test();
        Console.WriteLine(floatSub);

        Testable doubleSubTest = new Testable(DoubleSubtract);
        TestableFragment doubleSub = new TestableFragment("10 000 Double subtractions", doubleSubTest, 200, 200);
        doubleSub.Test();
        Console.WriteLine(doubleSub);

        Testable decimalSubTest = new Testable(DecimalSubtract);
        TestableFragment decSub = new TestableFragment("10 000 Decimal subtractions", decimalSubTest, 200, 200);
        decSub.Test();
        Console.WriteLine(decSub);


        Testable intAddTest = new Testable(IntAdd);
        TestableFragment intAdd = new TestableFragment("10 000 Integer additions", intAddTest, 200, 200);
        intAdd.Test();
        Console.WriteLine(intAdd);

        Testable longAddTest = new Testable(LongAdd);
        TestableFragment longAdd = new TestableFragment("10 000 Long additions", longAddTest, 200, 200);
        longAdd.Test();
        Console.WriteLine(longAdd);

        Testable floatAddTest = new Testable(FloatAdd);
        TestableFragment floatAdd = new TestableFragment("10 000 Float additions", floatAddTest, 200, 200);
        floatAdd.Test();
        Console.WriteLine(floatAdd);

        Testable doubleAddTest = new Testable(DoubleAdd);
        TestableFragment doubleAdd = new TestableFragment("10 000 Double additions", doubleAddTest, 200, 200);
        doubleAdd.Test();
        Console.WriteLine(doubleAdd);

        Testable decimalAddTest = new Testable(DecimalAdd);
        TestableFragment decimalAdd = new TestableFragment("10 000 Decimal additions", decimalAddTest, 200, 200);
        decimalAdd.Test();
        Console.WriteLine(decimalAdd);


        Testable intIncTest = new Testable(IntIncrement);
        TestableFragment intInc = new TestableFragment("10 000 Int increments", intIncTest, 200, 200);
        intInc.Test();
        Console.WriteLine(intInc);

        Testable longIncTest = new Testable(LongIncrement);
        TestableFragment longInc = new TestableFragment("10 000 Long increments", longIncTest, 200, 200);
        longInc.Test();
        Console.WriteLine(longInc);

        Testable floatIncTest = new Testable(FloatIncrement);
        TestableFragment floatInc = new TestableFragment("10 000 Float increments", floatIncTest, 200, 200);
        floatInc.Test();
        Console.WriteLine(floatInc);

        Testable doubleIncTest = new Testable(DoubleIncrement);
        TestableFragment doubleInc = new TestableFragment("10 000 Double increments", doubleIncTest, 200, 200);
        floatInc.Test();
        Console.WriteLine(floatInc);

        Testable decimalIncTest = new Testable(DecimalIncrement);
        TestableFragment decimalInc = new TestableFragment("10 000 Decimal increments", decimalIncTest, 200, 200);
        decimalInc.Test();
        Console.WriteLine(decimalInc);


        Testable intMultTest = new Testable(IntMult);
        TestableFragment intMult = new TestableFragment("10 000 Int multiplications", intMultTest, 200, 200);
        intMult.Test();
        Console.WriteLine(intMult);

        Testable longMultTest = new Testable(LongMult);
        TestableFragment longMult = new TestableFragment("10 000 Long multiplications", longMultTest, 200, 200);
        longMult.Test();
        Console.WriteLine(longMult);

        Testable floatMultTest = new Testable(FloatMult);
        TestableFragment floatMult = new TestableFragment("10 000 Float multiplications", floatMultTest, 200, 200);
        floatMult.Test();
        Console.WriteLine(floatMult);

        Testable doubleMultTest = new Testable(DoubleMult);
        TestableFragment doubleMult = new TestableFragment("10 000 Double multiplications", doubleMultTest, 200, 200);
        doubleMult.Test();
        Console.WriteLine(doubleMult);

        Testable decimalMultTest = new Testable(DecimalMult);
        TestableFragment decimalMult = new TestableFragment("10 000 Decimal multiplications", decimalMultTest, 200, 200);
        decimalMult.Test();
        Console.WriteLine(decimalMult);


        Testable intDivTest = new Testable(IntDiv);
        TestableFragment intDiv = new TestableFragment("10 000 Int divisions", intDivTest, 200, 200);
        intDiv.Test();
        Console.WriteLine(intDiv);

        Testable longDivTest = new Testable(LongDiv);
        TestableFragment longDiv = new TestableFragment("10 000 Long divisions", longDivTest, 200, 200);
        longDiv.Test();
        Console.WriteLine(longDiv);

        Testable floatDivTest = new Testable(FloatDiv);
        TestableFragment floatDiv = new TestableFragment("10 000 Float divisions", floatDivTest, 200, 200);
        floatDiv.Test();
        Console.WriteLine(floatDiv);

        Testable doubleDivTest = new Testable(DoubleDiv);
        TestableFragment doubleDiv = new TestableFragment("10 000 Double divisions", doubleDivTest, 200, 200);
        doubleDiv.Test();
        Console.WriteLine(doubleDiv);

        Testable decimalDivTest = new Testable(DecimalMult);
        TestableFragment decimalDiv = new TestableFragment("10 000 Decimal divisions", decimalDivTest, 200, 200);
        decimalDiv.Test();
        Console.WriteLine(decimalDiv);
    }

    public static void Task03Executor()
    {
        Console.WriteLine("Executing task 3");
        Console.WriteLine();
        Console.WriteLine();

        Testable floatSqrtTest = new Testable(FloatSqrt);
        TestableFragment floatSqrt = new TestableFragment("10 000 Float SQRT`S", floatSqrtTest, 200, 200);
        floatSqrt.Test();
        Console.WriteLine(floatSqrt);

        Testable doubleSqrtTest = new Testable(DoubleSqrt);
        TestableFragment doubleSqrt = new TestableFragment("10 000 Double SQRT`S", doubleSqrtTest, 200, 200);
        doubleSqrt.Test();
        Console.WriteLine(doubleSqrt);

        Testable decimalSqrtTest = new Testable(DecimalSqrt);
        TestableFragment decimalSqrt = new TestableFragment("10 000 Decimal SQRT`S", decimalSqrtTest, 200, 200);
        decimalSqrt.Test();
        Console.WriteLine(decimalSqrt);


        Testable floatSinTest = new Testable(FloatSin);
        TestableFragment floatSin = new TestableFragment("10 000 Float sin", floatSinTest, 200, 200);
        floatSin.Test();
        Console.WriteLine(floatSin);

        Testable doubleSinTest = new Testable(DoubleSin);
        TestableFragment doubleSin = new TestableFragment("10 000 Double sin", doubleSinTest, 200, 200);
        doubleSin.Test();
        Console.WriteLine(doubleSin);

        Testable decimalSinTest = new Testable(DecimalSin);
        TestableFragment decimalSin = new TestableFragment("10 000 Decimal sin", decimalSinTest, 200, 200);
        decimalSin.Test();
        Console.WriteLine(decimalSin);


        Testable floatLnTest = new Testable(FloatLn);
        TestableFragment floatLn = new TestableFragment("10 000 Float Ln", floatLnTest, 200, 200);
        floatLn.Test();
        Console.WriteLine(floatLn);

        Testable doubleLnTest = new Testable(DoubleLn);
        TestableFragment doubleLn = new TestableFragment("10 000 Double Ln", doubleLnTest, 200, 200);
        doubleLn.Test();
        Console.WriteLine(doubleLn);

        Testable decimalLnTest = new Testable(DecimalLn);
        TestableFragment decimalLn = new TestableFragment("10 000 Decimal Ln", decimalLnTest, 200, 200);
        decimalLn.Test();
        Console.WriteLine(decimalLn);
    }

    public static void Task04Executor()
    {
        int[] intArr = new int[] { 2, 4, 3, 4, 12, 12, 123, 123, 18, 4, 18, 1337, 1024, 128, 1337, 1233, -238, 74, 66, 133, 1025,
            32, 344, 7743, -90, -7, 11, 700, 333, 666, 808, 31, 37, 16, 32, 164, 128, 256, 512, 1024, 2048 };//41 elements

        double[] doubleArr = new double[] {2.33, 1.337, 2,222, 100d, 28327d, 93d, 132d, 9088d, -123.321, 192d, 0d, 1337d, 66.6666,
            231d, 323d, 128d, 256d, 1024.256, 3902d, 3912d, 7777d, 122112d, -1238d, -999d, 975d, -12d, -37.9084d, 1337, 38287d,
            43d, 3123.22, 32.123, 94594.123, 3234873d, 313d, 321d, 329.312, 798.87, 65.221, 5498.3635, 1756.345 };//41

        string[] stringArr = new string[] {"as", "as", "fuck", "lolminator", "lol", "zzz", "asdf", "qq", "terminator", "asshole", 
            "turbo", "gosu", "as", "storm", "road", "car", "computer", "keyboard", "ka-me-ha-me-haaaaaaa~", 
            "pokemon", "final fantasy", "starcraft", "diablo 3 sux rotten ass", "trololololol", "as", "asdds", "eqwe", "qwe", "l", 
            "gsl", "JavaScript sux hard", "bvbv", "yrt", "ewrw", "hdfg", "fjghj", "lhjk", "lhjk", "as", "iop", "askghj" }; //41

        Testable quickSortTest = new Testable(QuickSortCaller);
        TestableFragment qsTest = new TestableFragment("QuickSort 41 integer elements array", quickSortTest, 200, 200);
        QuickSortParams p = new QuickSortParams(intArr, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        Testable selectionSortTest = new Testable(SelectionSortCaller);
        TestableFragment ssTest = new TestableFragment("SelectionSort 41 integer elements array", selectionSortTest, 200, 200);
        ssTest.Test(intArr);
        Console.WriteLine(ssTest);

        Testable insertionSortTest = new Testable(InsertionSortCaller);
        TestableFragment isTest = new TestableFragment("InsertionSort 41 integer elements array", insertionSortTest, 200, 200);
        isTest.Test(intArr);
        Console.WriteLine(isTest);


        qsTest.Description = "QuickSort 41 double elements array";
        p = new QuickSortParams(doubleArr, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        ssTest.Description = "SelectionSort 41 double elements array";
        ssTest.Test(doubleArr);
        Console.WriteLine(ssTest);

        isTest.Description = "InsertionSort 41 double elements array";
        isTest.Test(doubleArr);
        Console.WriteLine(isTest);


        qsTest.Description = "QuickSort 41 string elements array";
        p = new QuickSortParams(stringArr, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        ssTest.Description = "SelectionSort 41 string elements array";
        ssTest.Test(stringArr);
        Console.WriteLine(ssTest);

        isTest.Description = "InsertionSort 41 string elements array";
        isTest.Test(stringArr);
        Console.WriteLine(isTest);


        int[] randomArray = GenerateRandomArray(1000);
        int[] sortedArray = GenerateSortedArray(1000);
        int[] reverseSortedArray = GenerateReverseSortedArray(1000);

        qsTest.Description = "QuickSort 1000 random elements";
        p = new QuickSortParams(randomArray, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        ssTest.Description = "SelectionSort 1000 random elements";
        ssTest.Test(randomArray);
        Console.WriteLine(ssTest);

        isTest.Description = "InsertionSort 1000 random elements";
        isTest.Test(randomArray);
        Console.WriteLine(isTest);


        qsTest.Description = "QuickSort 1000 sorted elements";
        p = new QuickSortParams(sortedArray, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        ssTest.Description = "SelectionSort 1000 sorted elements";
        ssTest.Test(sortedArray);
        Console.WriteLine(ssTest);

        isTest.Description = "InsertionSort 1000 sorted elements";
        isTest.Test(sortedArray);
        Console.WriteLine(isTest);


        qsTest.Description = "QuickSort 1000 reverse sorted elements";
        p = new QuickSortParams(reverseSortedArray, 0, intArr.Length - 1);
        qsTest.Test(p);
        Console.WriteLine(qsTest);

        ssTest.Description = "SelectionSort 1000 reverse sorted elements";
        ssTest.Test(reverseSortedArray);
        Console.WriteLine(ssTest);

        isTest.Description = "InsertionSort 1000 reverse sorted elements";
        isTest.Test(reverseSortedArray);
        Console.WriteLine(isTest);
    }

    private static int[] GenerateRandomArray(int size)
    {
        int[] arr = new int[size];
        Random elementGenerator = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = elementGenerator.Next(0, 100001);
        }

        return arr;
    }

    private static int[] GenerateSortedArray(int size)
    {
        int[] arr = new int[size];
        Random elementGenerator = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
        }

        return arr;
    }

    private static int[] GenerateReverseSortedArray(int size)
    {
        int[] arr = new int[size];
        int val = size;
        Random elementGenerator = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = val;
            val--;
        }

        return arr;
    }
}

