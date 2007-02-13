/*
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''' This is the MIT License, with one addition:
''' I want attribution in source code form, which means any code of mine you use,
''' you must keep this entire license intact, including the next line:
'''
''' Nik Martin wrote the original version of this software.  
''' http://www.nikmartin.com
'''
'''
''' Copyright (c) <year> Nik Martin
'''
''' Permission is hereby granted, free of charge, to any person obtaining a copy of 
''' this software and associated documentation files (the "Software"), to deal in 
''' the Software without restriction, including without limitation the rights to 
''' use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of 
''' the Software, and to permit persons to whom the Software is furnished to do so, 
''' subject to the following conditions:
'''
''' The above copyright notice and this permission notice shall be included in all 
''' copies or substantial portions of the Software.
'''
''' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
''' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
''' FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR 
''' COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
''' IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
''' CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
*/
using System;
using NUnit.Framework;
using System.Text;

#if DEBUG
using System.Diagnostics;
#endif

namespace SiUtilWrapper

{
   

    [TestFixture] public class SiUtilsTest
    {
        [Test] public void getUSBDllVersion()
        {
            string pVersion="";
            Assert.IsEmpty(pVersion);
            SiUtil.GetUSBDLLVersion(ref pVersion);
          
#if DEBUG
            Trace.WriteLine(pVersion);
#endif
            Assert.IsNotEmpty(pVersion);
              

        }
    }
}
