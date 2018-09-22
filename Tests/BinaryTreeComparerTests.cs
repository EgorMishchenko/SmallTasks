using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallTasks;
using SmallTasks._1_BinaryTreeComparer;

namespace Tests
{
    [TestClass]
    public class BinaryTreeComparerTests
    {
        public BinaryTreeNode FirstBinaryTree { get; set; }
        public BinaryTreeNode SecondBinaryTree { get; set; }
        public BinaryTreeNode EqualFirstBinaryTree { get; set; }

        [TestMethod]
        public void OneNodeTreesTest()
        {
            FillFirstOneNodeTree();
            FillSecondOneNodeTree();
            Assert.IsTrue(FirstBinaryTree.Equals(FirstBinaryTree));
            Assert.IsFalse(FirstBinaryTree.Equals(SecondBinaryTree));
        }

        [TestMethod]
        public void SameTreeObjectEqualityTest()
        {
            FillFirstBinaryTree();
            Assert.IsTrue(FirstBinaryTree.Equals(FirstBinaryTree));
        }

        [TestMethod]
        public void DifferentObjectWithDifferentDataEqualityTest()
        {
            FillFirstBinaryTree();
            FillSecondBinaryTree();
            Assert.IsFalse(FirstBinaryTree.Equals(SecondBinaryTree));
        }

        [TestMethod]
        public void DiffrentTreeObjectWithEquallyDataTest()
        {
            FillFirstBinaryTree();
            FillEqualFirstBinaryTree();
            Assert.IsTrue(FirstBinaryTree.Equals(EqualFirstBinaryTree));
        }

        [TestMethod]
        public void TreesWithDifferentStructureTest()
        {
            FillFirstBinaryTree();
            FillSecondBinaryTreeWithAnotherStructure();
            Assert.IsFalse(FirstBinaryTree.Equals(EqualFirstBinaryTree));
        }

        [TestMethod]
        public void CompareTreeWithNullTest()
        {
            FillFirstBinaryTree();
            Assert.IsFalse(FirstBinaryTree.Equals(null));
        }

        public void FillFirstOneNodeTree()
        {
            FirstBinaryTree = new BinaryTreeNode(7);
        }

        public void FillSecondOneNodeTree()
        {
            SecondBinaryTree = new BinaryTreeNode(99);
        }

        public void FillFirstBinaryTree()
        {
            //
            //           1
            //         /   \
            //        9      14
            //       / \     /  \
            //     18   6   5    22
            //    /          \
            //   2            9

            FirstBinaryTree = new BinaryTreeNode(1);

            FirstBinaryTree.Left = new BinaryTreeNode(9);
            FirstBinaryTree.Right = new BinaryTreeNode(14);

            FirstBinaryTree.Left.Left = new BinaryTreeNode(18);
            FirstBinaryTree.Left.Right = new BinaryTreeNode(6);

            FirstBinaryTree.Right.Left = new BinaryTreeNode(5);
            FirstBinaryTree.Right.Right = new BinaryTreeNode(22);

            FirstBinaryTree.Left.Left.Left = new BinaryTreeNode(2);

            FirstBinaryTree.Right.Left.Right = new BinaryTreeNode(9);
        }

        public void FillSecondBinaryTree()
        {
            //
            //           1
            //         /   \
            //        9      14
            //       / \     /  \
            //     18   6   5    22
            //    /          \
            //   2            16

            SecondBinaryTree = new BinaryTreeNode(1);

            SecondBinaryTree.Left = new BinaryTreeNode(9);
            SecondBinaryTree.Right = new BinaryTreeNode(14);

            SecondBinaryTree.Left.Left = new BinaryTreeNode(18);
            SecondBinaryTree.Left.Right = new BinaryTreeNode(6);

            SecondBinaryTree.Right.Left = new BinaryTreeNode(5);
            SecondBinaryTree.Right.Right = new BinaryTreeNode(22);

            SecondBinaryTree.Left.Left.Left = new BinaryTreeNode(2);

            SecondBinaryTree.Right.Left.Right = new BinaryTreeNode(16);
        }

        public void FillSecondBinaryTreeWithAnotherStructure()
        {
            //
            //           15
            //         /   \
            //        60     2
            //             /   \
            //            5     73
            //                    \
            //                      1
            //                     /  \
            //                    55   8

            SecondBinaryTree = new BinaryTreeNode(15);

            SecondBinaryTree.Left = new BinaryTreeNode(60);
            SecondBinaryTree.Right = new BinaryTreeNode(2);

            SecondBinaryTree.Right.Left = new BinaryTreeNode(5);
            SecondBinaryTree.Right.Right = new BinaryTreeNode(73);

            SecondBinaryTree.Right.Right.Right = new BinaryTreeNode(1);

            SecondBinaryTree.Right.Right.Right.Left = new BinaryTreeNode(55);
            SecondBinaryTree.Right.Right.Right.Right = new BinaryTreeNode(8);
        }

        public void FillEqualFirstBinaryTree()
        {
            //
            //           1
            //         /   \
            //        9      14
            //       / \     /  \
            //     18   6   5    22
            //    /          \
            //   2            9

            EqualFirstBinaryTree = new BinaryTreeNode(1);

            EqualFirstBinaryTree.Left = new BinaryTreeNode(9);
            EqualFirstBinaryTree.Right = new BinaryTreeNode(14);

            EqualFirstBinaryTree.Left.Left = new BinaryTreeNode(18);
            EqualFirstBinaryTree.Left.Right = new BinaryTreeNode(6);

            EqualFirstBinaryTree.Right.Left = new BinaryTreeNode(5);
            EqualFirstBinaryTree.Right.Right = new BinaryTreeNode(22);

            EqualFirstBinaryTree.Left.Left.Left = new BinaryTreeNode(2);

            EqualFirstBinaryTree.Right.Left.Right = new BinaryTreeNode(9);
        }
    }
}
