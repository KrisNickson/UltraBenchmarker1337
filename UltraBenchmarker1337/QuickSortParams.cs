using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct QuickSortParams
{
    public dynamic Array {  get; private set; }
    public int StartIndex {  get; private set; }
    public int EndIndex {  get; private set; }

    public QuickSortParams(dynamic array, int startIndex, int endIndex) 
        : this()
    {
        this.Array = array;
        this.StartIndex = startIndex;
        this.EndIndex = endIndex;
    }
}
