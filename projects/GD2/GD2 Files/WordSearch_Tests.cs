using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class WordSearch_Tests
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
        char[,] input = {{'A','T','H','I','S','Q','P','R','0'},
                         {'S','T','A','M','P','A','T','S','1'},
                         {'S','T','D','C','E','N','A','M','2'},
                         {'L','X','R','B','X','E','X','M','3'},
                         {'P','O','X','I','X','D','Y','Z','4'},
                         {'Z','F','X','A','N','P','F','I','5'},
                         {'F','I','N','A','L','G','O','X','6'},
                         {'W','X','U','G','C','V','H','T','7'} };


        Tuple<string,int,int> actual = DG2_CH7to9.FindWord("GO", input);

        Tuple<string,int, int> expected = new Tuple<string, int, int>("GO",5,6);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        char[,] input = {{'A','T','H','I','S','Q','P','R','0'},
                         {'S','T','A','M','P','A','T','S','1'},
                         {'S','T','D','C','E','N','A','M','2'},
                         {'L','X','R','B','X','E','X','M','3'},
                         {'P','O','X','I','X','D','Y','Z','4'},
                         {'Z','F','X','A','N','P','F','I','5'},
                         {'F','I','N','A','L','G','O','X','6'},
                         {'W','X','U','G','C','V','H','T','7'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("STAMP", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("STAMP", 0, 1);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        char[,] input = {{'A','T','H','I','S','Q','P','R','0'},
                         {'S','T','A','M','P','A','T','S','1'},
                         {'S','T','D','C','E','N','A','M','2'},
                         {'L','X','R','B','X','E','X','M','3'},
                         {'P','O','X','I','X','D','Y','Z','4'},
                         {'Z','F','X','A','N','P','F','I','5'},
                         {'F','I','N','A','L','G','O','X','6'},
                         {'W','X','U','G','C','V','H','T','7'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("WASP", input);

        Tuple<string, int, int> expected = null;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        char[,] input = {{'C','T','A'},
                         {'S','A','R'},
                         {'A','C','T'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("CAT", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("CAT",0,0);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        char[,] input = {{'C','T','A'},
                         {'S','A','R'},
                         {'A','C','T'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("ART", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("ART", 2, 0);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        char[,] input = {{'C','T','A'},
                         {'S','A','R'},
                         {'A','C','T'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("HATS", input);

        Tuple<string, int, int> expected = null;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test7()
    {
        char[,] input = {{'C','A','A', 'T'},
                         {'S','T','R', 'M'},
                         {'P','R','T', 'P'},
                         {'S','A','R', 'M'},
                         {'N','P','A', 'N'},
                         {'S','S','R', 'M'},};


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("PAN", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("PAN",1,4);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test8()
    {
        char[,] input = {{'C','A','A', 'T'},
                         {'S','T','R', 'M'},
                         {'P','R','T', 'P'},
                         {'S','A','R', 'M'},
                         {'N','P','A', 'N'},
                         {'S','S','R', 'M'},};


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("TRAPS", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("TRAPS", 1, 1);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test9()
    {
        char[,] input = {{'C','A','A', 'T'},
                         {'S','T','R', 'M'},
                         {'P','R','T', 'P'},
                         {'S','A','R', 'M'},
                         {'N','P','A', 'N'},
                         {'S','S','R', 'M'},};


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("ANTS", input);

        Tuple<string, int, int> expected = null;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test10()
    {
        char[,] input = {{'C','A','A', 'A', 'T'},
                         {'S','T','T', 'M', 'R'},
                         {'P','R','R', 'R', 'A'},
                         {'A','A','R', 'M', 'S'},
                         {'N','R','R', 'N', 'N'},
                         {'S','S','T', 'M', 'B'} };


        Tuple<string, int, int> actual = DG2_CH7to9.FindWord("ART", input);

        Tuple<string, int, int> expected = new Tuple<string, int, int>("ART",0,3);
        Assert.That(actual, Is.EqualTo(expected));
    }
}