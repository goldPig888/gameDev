using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class FibonacciList_Tests
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
        List<long> actual;
      

        GD2_CH4to6.FibonacciList(1, out actual);

        long[] resultValues = { 0 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(2, out actual);

        long[] resultValues = { 0, 1 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(3, out actual);

        long[] resultValues = { 0,1,1 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(4, out actual);

        long[] resultValues = { 0,1,1,2 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(9, out actual);

        long[] resultValues = { 0,1,1,2,3,5,8,13,21 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(20, out actual);

        long[] resultValues =  { 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181 };

        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(25, out actual);

        long[] resultValues = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765,10946,17711,28657,46368 };

        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(12, out actual);

        long[] resultValues = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};

        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(14, out actual);

        long[] resultValues = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233};

        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        List<long> actual;


        GD2_CH4to6.FibonacciList(23, out actual);

        long[] resultValues = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 };

        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

}