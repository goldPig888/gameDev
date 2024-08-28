using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class RemovePrimes_Tests
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
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> actual = new List<int>();
        foreach(int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = {1,4,6,8,9,10 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);
        
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[] values = { 4,6, 5, 7, 18, 23, 33, 31 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 4, 6, 18, 33};
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[] values = { 5, 11, 17, 19, 59 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[] values = { 12, 30, 99, 126, 205 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 12, 30, 99, 126, 205 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int[] values = { 977, 501, 654, 907, 901, 757};
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 501, 654, 901 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        int[] values = { 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 148, 150,  152, 153, 154, 155, 156, 158, 159, 160 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        int[] values = { 3, 5, 6, 3, 8, 8, 7};
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 6, 8, 8 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        int[] values = { 999, 959, 321, 201, 75, 87 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = {999, 959, 321, 201, 75, 87 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        int[] values = { 33, 47, 55 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 33, 55 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        int[] values = { 11, 23, 33, 44, 55, 67, 77, 89, 99, 150, 112, 9, 7, 57, 51, 53 };
        List<int> actual = new List<int>();
        foreach (int i in values)
            actual.Add(i);

        GD2_CH4to6.RemovePrimes(actual);

        int[] resultValues = { 33, 44, 55, 77, 99, 150, 112, 9, 57, 51 };
        List<int> expected = new List<int>();
        foreach (int i in resultValues)
            expected.Add(i);

        Assert.That(actual, Is.EqualTo(expected));
    }

}