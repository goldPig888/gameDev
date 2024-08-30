/*using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class RingTotals_Tests
{
    [SetUp]
    public void SetUp()
    {
        // Setup code here (if required)
    }

    [TearDown]
    public void TearDown()
    {
        // Teardown code here (if required)
    }

    [Test]
    public void Test1()
    {
        int[,] input = { {5} };


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 5 };
   
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[,] input = { { 2, 5, 7, 8, 9 } };


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 31 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[,] input = { { 1,3,1 },
                         { 1,8,1 } };


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 15 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[,] input = { { 3 },
                         { 5 },
                         { 2 },
                         { 5 },
                         { 5 } };


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 20 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int[,] input = { { 5, 5, 6, 78, 9, 4, 7, 9 },
                         { 7, 1, 11, 28, 5, 6, 7, 7 },
                         { 99, 43, 2, 7123, 87, 9, 0, 1 }};


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 7501, 58 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        int[,] input = { { 1, 1, 1, 1, 1},
                         { 1, 1, 1, 1, 1 },
                         { 1, 1, 1, 1, 1},
                         { 1, 1, 1, 1, 1 },
                         { 1, 1, 1, 1, 1 }};


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 16, 8,1 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        int[,] input = { { 1, 22, 75 },
                         { 3, 18, 99 },
                         { 4, 31, 32},
                         { 5, 43, 64},
                         { 49, 43, 67}};


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 464, 92 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        int[,] input = { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9 },};


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 130, 90, 50 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        int[,] input = { { 44, 3, 33, 14, 77, 96},
                         { 7, 7, 5, 7, 5, 6 },
                         { 1, 78, 5, 444, 33, 52},
                         { 43, 84, 47, 25, 111, 74},
                         { 9859, 84, 78, 745, 14, 23},

                         { 65, 48, 14, 29, 14, 77},
                         { 45, 564, 43, 26, 38, 48},
                         { 47, 57, 76, 62, 75, 150},
                         { 11, 12, 68, 425, 852, 92} };


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 12224, 1362, 1456 };

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        int[,] input = { { 1, 5, 3, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 43, 5, 6, 7, 8, 9 },
                         { 1, 2, 5, 4, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 4, 5, 6, 5, 8, 9 },
                         { 99, 2, 3, 4, 5, 6, 7, 5, 9 },
                         { 1, 2, 3, 5, 5, 6, 7, 8, 9 },
                         { 1, 2, 3, 5, 5, 6, 7, 888, 9 },
                         { 1, 2, 3, 55, 5, 6, 7, 8, 9 },};


        int[] actual = GD2_CH7to9.RingTotals(input);

        int[] expected = { 302, 1027, 71, 30 };

        Assert.That(actual, Is.EqualTo(expected));
    }



}*/