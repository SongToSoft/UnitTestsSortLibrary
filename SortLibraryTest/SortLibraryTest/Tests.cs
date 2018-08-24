using System;
using NUnit.Framework;
using SortLibrary;

namespace SortLibraryTest
{
    [TestFixture]
    public class Tests
    {
        private int N = 100;
        private Random rand = new Random();
        
        //Тесты Buble
        [Test]
        public void TestBuble()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<double>.Buble(ArrayDouble);
            Sort<int>.Buble(ArrayInt);
            if ((Sort<double>.CheckArray(ArrayDouble)) && (Sort<int>.CheckArray(ArrayInt)))
                Assert.True(true);
            else
                Assert.True(false);
            
        }
        [Test]
        public void TestBubleNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Buble(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты блочной сортировки
        [Test]
        public void TestBucket()
        {
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayInt[i] = rand.Next(0, 10000);
            }
            Sort<int>.Bucket(ArrayInt);
            if (Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestBucketSubZeroValue()
        {
            int[] ArrayInt = new int[N];
            int[] tmp = ArrayInt;
            for (int i = 0; i < N; ++i)
            {
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<int>.Bucket(ArrayInt);
            if (tmp == ArrayInt)
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestBucketNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Bucket(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты быстрой сортировки
        [Test]
        public void TestQuick()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<double>.Quick(ArrayDouble, 0, N - 1);
            Sort<int>.Quick(ArrayInt, 0, N - 1);
            if (Sort<double>.CheckArray(ArrayDouble) && Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestQuickNull()
        {
            int[] ArrayInt = null;
            Sort<int>.Quick(ArrayInt, 0, N - 1);
            if (ArrayInt == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты сортировки выбором
        [Test]
        public void TestSelection()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<double>.Selection(ArrayDouble);
            Sort<int>.Selection(ArrayInt);
            if (Sort<double>.CheckArray(ArrayDouble) && Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestSelectionNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Selection(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты шейкерной сортировки
        [Test]
        public void TestShaker()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<double>.Shaker(ArrayDouble);
            Sort<int>.Shaker(ArrayInt);
            if (Sort<double>.CheckArray(ArrayDouble) && Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestShakerNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Shaker(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты пирамидальной сортировки
        [Test]
        public void TestPyramid()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            Sort<double>.Pyramid(ArrayDouble);
            Sort<int>.Pyramid(ArrayInt);
            if (Sort<double>.CheckArray(ArrayDouble) && Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestPyramidNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Pyramid(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        //Тесты сортировки слиянием
        [Test]
        public void TestMerge()
        {
            double[] ArrayDouble = new double[N];
            int[] ArrayInt = new int[N];
            for (int i = 0; i < N; ++i)
            {
                ArrayDouble[i] = rand.Next(-10000, 10000) * 0.33;
                ArrayInt[i] = rand.Next(-10000, 10000);
            }
            ArrayDouble = Sort<double>.Merge(ArrayDouble);
            ArrayInt = Sort<int>.Merge(ArrayInt);
            Sort<int>.PrintArray(ArrayInt);
            if (Sort<double>.CheckArray(ArrayDouble) && Sort<int>.CheckArray(ArrayInt))
                Assert.True(true);
            else
                Assert.True(false);
        }
        [Test]
        public void TestMergeNull()
        {
            int[] ArrayInt = null;
            if (Sort<int>.Merge(ArrayInt) == null)
                Assert.True(true);
            else
                Assert.True(false);
        }
        
    }
}