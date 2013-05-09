using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


class TestableFragment
{
    private string description;
    private Testable method;
    private Stopwatch sw = new Stopwatch();

    private List<decimal> times = new List<decimal>();
    private decimal avarageRunTime = 0m;
    private decimal minRunTime = 0m;
    private decimal maxRunTime = 0m;

    private int warmupRepetitions = 200; //warmup testRepetitions
    private int testRepetitions = 200;

    public string Description
    {
        get
        {
            return this.description;
        }

        set
        {
            this.description = value;
        }
    }

    public TestableFragment(string testDescription, Testable methodToTest, int warmupRepetitions, int testRepetitions)
    {
        this.description = testDescription;
        this.method = methodToTest;
        this.warmupRepetitions = warmupRepetitions;
        this.testRepetitions = testRepetitions;
    }

    public void Test(Object parameter = null)
    {
        Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); //always use the second cpu core
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;//set high process priority
        Thread.CurrentThread.Priority = ThreadPriority.Highest;//set high thread priority

        this.avarageRunTime = 0m;
        this.times.Clear();

        //warmup
        for (int curretnRepetition = 1; curretnRepetition <= warmupRepetitions; curretnRepetition++)
        {
            this.sw.Start();

            //stuff to be benchmarked start
            this.method.Invoke(parameter);
            //stuff to be benchmarked end

            this.sw.Stop();

            this.times.Add(Convert.ToDecimal(sw.Elapsed.TotalSeconds));
            this.avarageRunTime = this.avarageRunTime + times[curretnRepetition - 1];
            this.sw.Reset();
        }

        for (int curretnRepetition = 1; curretnRepetition <= testRepetitions; curretnRepetition++)
        {
            this.sw.Start();

            //stuff to be benchmarked start
            this.method.Invoke(parameter);
            //stuff to be benchmarked end

            this.sw.Stop();

            this.times.Add(Convert.ToDecimal(sw.Elapsed.TotalSeconds));
            this.avarageRunTime = this.avarageRunTime + times[curretnRepetition - 1];
            this.sw.Reset();
        }

    }

    public override string ToString()
    {
        CallculateStats();

        StringBuilder result = new StringBuilder();
        result.Append("Running " + this.testRepetitions + " repetitions of " + this.description + " yielded: ");
        result.Append("\nMaximum runtime: " + this.maxRunTime + " seconds");
        result.Append("\nMinimum runtime: " + this.minRunTime + " seconds");
        result.Append("\nAverage runtime: " + this.avarageRunTime + " seconds\n\n");

        return result.ToString();
    }

    private void CallculateStats()
    {
        this.avarageRunTime = this.avarageRunTime / this.times.Count;
        this.times.Sort();
        this.minRunTime = times[0];
        this.maxRunTime = times[times.Count-1];
    }
}

