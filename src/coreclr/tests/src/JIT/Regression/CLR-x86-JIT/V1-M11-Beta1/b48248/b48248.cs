// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;

struct test
{
    public String str;
    public int int1;
    public int int2;
    public int int3;
    public int int4;
    public int int5;
    public int int6;
    public int int7;

    test(int i)
    {
        str = "hello";
        int1 = i;
        int2 = i;
        int3 = i;
        int4 = i;
        int5 = i;
        int6 = i;
        int7 = i;
    }
    public static int Main(String[] args)
    {
        test t = new test();

        if (t.str != null)
            Console.WriteLine("Got String");

        return 100;
    }
}
