﻿using LeetCode._0001_0050;
using NUnit.Framework;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _004_MedianOfTwoSortedArrays_Test
    {
        [Test]
        public void FindMedianSortedArraysTest_General_Odd()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4, 5 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void FindMedianSortedArraysTest_General_Even()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 5, 6, 7, 8 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(4.5));
        }

        [Test]
        public void FindMedianSortedArraysTest_Num1Empty()
        {
            int[] nums1 = { };
            int[] nums2 = { 1, 2, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void FindMedianSortedArraysTest_Num2Empty()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void FindMedianSortedArraysTest_Num1Empty_Nums2SingleItem()
        {
            int[] nums1 = { };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindMedianSortedArraysTest_Num2Empty_Nums1SingleItem()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Odd()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6, 7 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Even()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(3.5));
        }

        [Test]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Odd()
        {
            int[] nums1 = { 2, 3, 4, 5, 6, 7 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Even()
        {
            int[] nums1 = { 2, 3, 4, 5, 6 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(3.5));
        }

        [Test]
        public void FindMedianSortedArraysTest_MixedArray()
        {
            int[] nums1 = { 2 };
            int[] nums2 = { 1, 3, 4 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void FindMedianSortedArraysTest_DuplicateItems()
        {
            int[] nums1 = { 1, 1, 3, 3 };
            int[] nums2 = { 1, 1, 3, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void FindMedianSortedArraysTest_DuplicateItems_2()
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int[] nums2 = { 0, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.That(result, Is.EqualTo(10.5));
        }
    }
}
