namespace SmallTasks._1_BinaryTreeComparer
{
    public class BinaryTree
    {
        private BinaryTreeNode _root;

        public BinaryTree()
        {
            _root = null;
        }

        public BinaryTreeNode Root { get => _root; set => _root = value; }

        public override int GetHashCode()
        {
            int hash = 17;
            return hash = hash * 23 + Root.Value.GetHashCode(); 
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (this == obj)
                return true;

            BinaryTree treeToCompare = (BinaryTree)obj;

            return CompareNodes(Root, treeToCompare.Root);
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
