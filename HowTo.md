First, you need to compile SiUtil\_cs.dll, the you need to reference it in your .net programmer code.  Then call the functions exactly as you would call the functions in the original C++ MFC dll.

**AFTER COMPILING:**
Just put SiUtil\_cs.dll in the same folder as SiUtil.dll (and the USB Dll, if needed) and run your .net app.

I'll post a sample programmer test harness as soon as I get one running.  My application is very specialized and does some weird stuff (writing to code memory, etc), so it's not a good example.