using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class Building_Tests
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
        bool[,] input = {{false,false,false,true},
                           {false,false,false,false},
                        {false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(2,2,input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int,int>(0, 0));
        expected.Add(new Tuple<int, int>(1, 0));
        expected.Add(new Tuple<int, int>(2, 1));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        bool[,] input = {{false,false,false,true},
                           {false,false,false,false},
                        {false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(1, 2, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(0, 0));
        expected.Add(new Tuple<int, int>(1, 0));
        expected.Add(new Tuple<int, int>(2, 0));
        expected.Add(new Tuple<int, int>(0, 1));
        expected.Add(new Tuple<int, int>(2, 1));
        expected.Add(new Tuple<int, int>(3, 1));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        bool[,] input = {{false,false,false,true},
                           {false,false,false,false},
                        {false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(2, 3, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        bool[,] input = {{false,false,false,true},
                           {false,false,false,false},
                        {false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(3, 2, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(0, 0));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        bool[,] input = { { false, true, false, true , true, false, false} };
                     


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(1, 1, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(0, 0));
        expected.Add(new Tuple<int, int>(2, 0));
        expected.Add(new Tuple<int, int>(5, 0));
        expected.Add(new Tuple<int, int>(6, 0));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        bool[,] input = {{false,false},
                           {false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(3, 2, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        bool[,] input = {  {false,false,true,false,false},
                           {false,false,false,false,false},
                           {false,true,false,true,false},
                           {true,false,false,false,false},
                           {false,false,false,false,true}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(2, 2, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(0, 0));
        expected.Add(new Tuple<int, int>(3, 0));
        expected.Add(new Tuple<int, int>(1, 3));
        expected.Add(new Tuple<int, int>(2, 3));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        bool[,] input = {  {false,false,true,false,false},
                           {false,false,false,false,false},
                           {false,true,false,true,false},
                           {true,false,false,false,false},
                           {false,false,false,false,true}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(3, 1, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(0, 1));
        expected.Add(new Tuple<int, int>(1, 1));
        expected.Add(new Tuple<int, int>(2, 1));
        expected.Add(new Tuple<int, int>(1, 3));
        expected.Add(new Tuple<int, int>(2, 3));
        expected.Add(new Tuple<int, int>(0, 4));
        expected.Add(new Tuple<int, int>(1, 4));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        bool[,] input = {  {false,false,true,false,false,false,false},
                           {false,false,false,false,false,false,false},
                           {false,true,false,true,false,true,false},
                           {true,false,false,false,false,false,false},
                           {false,false,false,false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(3, 2, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(3, 0));
        expected.Add(new Tuple<int, int>(4, 0));
        expected.Add(new Tuple<int, int>(1, 3));

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        bool[,] input = {  {false,false,true,false,false,false,false},
                           {false,false,false,false,false,false,false},
                           {false,true,false,true,false,true,false},
                           {true,false,false,false,false,false,false},
                           {false,false,false,false,true,false,false}};


        List<Tuple<int, int>> actual = DG2_CH7to9.BuildingPlacement(4, 1, input);

        List<Tuple<int, int>> expected = new List<Tuple<int, int>>();
        expected.Add(new Tuple<int, int>(3, 0));
        expected.Add(new Tuple<int, int>(0, 1));
        expected.Add(new Tuple<int, int>(1, 1));
        expected.Add(new Tuple<int, int>(2, 1));
        expected.Add(new Tuple<int, int>(3, 1));
        expected.Add(new Tuple<int, int>(1, 3));
        expected.Add(new Tuple<int, int>(2, 3));
        expected.Add(new Tuple<int, int>(3, 3));
        expected.Add(new Tuple<int, int>(0, 4));


        Assert.That(actual, Is.EqualTo(expected));
    }
}