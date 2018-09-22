namespace SmallTasks._1_BinaryTreeComparer
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public int Value { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23;
            hash = hash + Left.GetHashCode();
            hash = hash + Right.GetHashCode();
            hash = hash + Value.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (this == obj)
                return true;

            BinaryTreeNode treeToCompare = (BinaryTreeNode)obj;

            return CompareNodes(this, treeToCompare);
        }

        private bool CompareNodes(BinaryTreeNode firstNode, BinaryTreeNode secondNode)
        {
            if (firstNode != null && secondNode != null)
            {
                if (firstNode.Value != secondNode.Value)
                    return false;

                if (!CompareNodes(firstNode.Left, secondNode.Left))
                    return false;

                if (!CompareNodes(firstNode.Right, secondNode.Right))
                    return false;
            }

            return true;
        }
    }
}
