using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class MedianScores_Tests
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
        List<(string,int)> actualScores = new List<(string,int)>();
        (string, int)[] values = { ("Joe", 85), ("Jane", 99), ("Jack", 85) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Jack", 85), ("Joe", 85), ("Jane", 99) };
        expectedScores.AddRange(valuesR);

        string[] names = {"Jack", "Joe" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test2()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Joe", 55), ("Jane", 55), ("Jack", 55) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Jack", 55), ("Jane", 55), ("Joe", 55) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Jack", "Jane", "Joe" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test3()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Joe", 85), ("Jane", 99), ("Jack", 99), ("Tim",87) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Joe", 85), ("Tim", 87), ("Jack", 99), ("Jane", 99) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Tim" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test4()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Joe", 73), ("Jane", 73), ("Jack", 73), ("Tim", 73) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Jack", 73), ("Jane", 73), ("Joe", 73), ("Tim", 73) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Jack", "Jane", "Joe", "Tim" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test5()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("A", 72), ("B", 55), ("C", 42), ("D", 42), ("E", 35), ("F", 11) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("F", 11), ("E", 35), ("C", 42), ("D", 42), ("B", 55), ("A", 72) }  ;
        expectedScores.AddRange(valuesR);

        string[] names = { "C", "D" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test6()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("A", 72), ("B", 55), ("C", 42), ("D", 36), ("E", 35), ("F", 11) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("F", 11), ("E", 35), ("D", 36), ("C", 42), ("B", 55), ("A", 72) }  ;
        expectedScores.AddRange(valuesR);

        string[] names = { "D" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test7()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("A", 12), ("F", 100), ("B", 12), ("D", 25), ("E", 99), ("C", 98) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("A", 12), ("B", 12), ("D", 25), ("C", 98), ("E", 99), ("F", 100) };
        expectedScores.AddRange(valuesR);

        string[] names = { "D" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test8()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Apple", 67), ("Banana", 34), ("Banana", 80), ("Pear",99), ("Grape",87) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = {  ("Banana", 34),("Apple", 67), ("Banana", 80), ("Grape", 87), ("Pear", 99) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Banana" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test9()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Apple", 67), ("Banana", 80), ("Banana", 80), ("Pear", 99), ("Grape", 80) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Apple", 67), ("Banana", 80), ("Banana", 80), ("Grape", 80), ("Pear", 99) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Banana", "Banana", "Grape" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

    [Test]
    public void Test10()
    {
        List<(string, int)> actualScores = new List<(string, int)>();
        (string, int)[] values = { ("Grape", 99),("Banana", 100), ("Apple", 99),  ("Banana", 100), ("Pear", 99) };

        actualScores.AddRange(values);

        List<string> actualNames = DG2_CH4to6.MedianScores(ref actualScores);

        List<(string, int)> expectedScores = new List<(string, int)>();
        (string, int)[] valuesR = { ("Apple", 99),("Grape", 99), ("Pear", 99), ("Banana", 100),  ("Banana", 100) };
        expectedScores.AddRange(valuesR);

        string[] names = { "Apple", "Grape", "Pear" };
        List<string> exepectedNames = new List<string>();
        exepectedNames.AddRange(names);

        Assert.That(actualScores, Is.EqualTo(expectedScores));
        Assert.That(actualNames, Is.EqualTo(exepectedNames));
    }

}