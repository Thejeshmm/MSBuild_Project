using System;

class Helloworld
  {
     static void Main()
       {
#if DebugConfig
          Console.WriteLine("We are in the Debug config");
#endif
          Console.WriteLine("Hello, world");
       }
  }
          