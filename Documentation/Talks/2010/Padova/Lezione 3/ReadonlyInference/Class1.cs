// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace ReadonlyInference
{
  public class Counter
  {
    private int c;
    readonly int Max;

    public Counter(int start)
    {
      this.c = 0;
      this.Max = Int32.MaxValue;
    }

    
    public Counter(int c, int MaxValue)
    {
      Contract.Requires(MaxValue > 0);

      this.c = 0;
      this.Max = MaxValue;
    }

    public int Add()
    {
      c = c < Max ? c + 1 : 0;

      Contract.Assert(0.0 == 0.0);
      Contract.Assert(Double.NegativeInfinity == Double.NegativeInfinity);
      Contract.Assert(Double.NaN == Double.NaN);

      return c;
    }


  }

  public class Point
  {
    public double X, Y;

    Point(double x, double y)
    {
      this.X = x;
      this.Y = y;
    }
  }

}
