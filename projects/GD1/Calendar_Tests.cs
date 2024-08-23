using NUnit.Framework;
using System;

[TestFixture]
public class Calendar_Tests
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
        bool actual = GD1_CH5to6.IsLeapYear(100);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1901);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1904);
        bool expected = true;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1905);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1981);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1984);
        bool expected = true;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        bool actual = GD1_CH5to6.IsLeapYear(1999);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        bool actual = GD1_CH5to6.IsLeapYear(2100);
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        bool actual = GD1_CH5to6.IsLeapYear(2000);
        bool expected = true;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        bool actual = GD1_CH5to6.IsLeapYear(3200);
        bool expected = true;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test11()
    {
        int actual = GD1_CH5to6.DaysInMonth(2,1935);
        int expected = 28;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test12()
    {
        int actual = GD1_CH5to6.DaysInMonth(2, 1924);
        int expected = 29;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test13()
    {
        int actual = GD1_CH5to6.DaysInMonth(11, 2001);
        int expected = 30;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test14()
    {
        int actual = GD1_CH5to6.DaysInMonth(12, 2004);
        int expected = 31;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test15()
    {
        int actual = GD1_CH5to6.DaysInMonth(9, 777);
        int expected = 30;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test16()
    {
        int actual = GD1_CH5to6.DaysInMonth(7, 1924);
        int expected = 31;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test17()
    {
        int actual = GD1_CH5to6.DaysInMonth(5, 543);
        int expected = 31;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test18()
    {
        int actual = GD1_CH5to6.DaysInMonth(8, 1642);
        int expected = 31;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test19()
    {
        int actual = GD1_CH5to6.DaysInMonth(3, 1276);
        int expected = 31;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test20()
    {
        int actual = GD1_CH5to6.DaysInMonth(4, 1973);
        int expected = 30;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test21()
    {
        int actual = GD1_CH5to6.DaysBetween(1,1,2000,12,13,2000);
        int expected = 347;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test22()
    {
        int actual = GD1_CH5to6.DaysBetween(1, 1, 1973, 9, 7, 1973);
        int expected = 249;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test23()
    {
        int actual = GD1_CH5to6.DaysBetween(1, 1, 2000, 1, 26, 2000);
        int expected = 25;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test24()
    {
        int actual = GD1_CH5to6.DaysBetween(4, 13, 1940, 7, 1, 1967);
        int expected = 9940;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test25()
    {
        int actual = GD1_CH5to6.DaysBetween(2, 3, 2000, 1, 7, 2001);
        int expected = 339;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test26()
    {
        int actual = GD1_CH5to6.DaysBetween(1, 1, 1905, 1, 2, 1906);
        int expected = 366;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test27()
    {
        int actual = GD1_CH5to6.DaysBetween(4, 4, 1984, 7, 30, 1999);
        int expected = 5595;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test28()
    {
        int actual = GD1_CH5to6.DaysBetween(2, 7, 2005, 2, 7, 2006);
        int expected = 365;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test29()
    {
        int actual = GD1_CH5to6.DaysBetween(8, 8, 2010, 12, 29, 2088);
        int expected = 28633;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test30()
    {
        int actual = GD1_CH5to6.DaysBetween(9, 21, 1756, 3, 13, 2024);
        int expected = 97693;

        Assert.That(actual, Is.EqualTo(expected));
    }
}

