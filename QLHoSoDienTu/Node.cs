using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHoSoDienTu
{
    internal class Node
    {
        FileInfo Data;
        Node LeftNode;
        Node RightNode;
        Node Parent;

        public FileInfo _Data
        {
            get { return Data; }
            set { Data = value; }
        }
        
        public Node _LeftNode
        {
            get { return LeftNode; }
            set { LeftNode = value; }
        }
        public Node _RightNode
        {
            get { return RightNode; }
            set { RightNode = value; }
        }

        public Node _Parent
        {
            get { return Parent; }
            set { Parent = value; }
        }

        public Node()
        {
            Data = new FileInfo();
            LeftNode = null;
            RightNode = null;
            Parent = null;
        }
        public Node(FileInfo data, Node leftNode, Node rightNode, Node parent)
        {
            Data= data;
            LeftNode = leftNode;
            RightNode = rightNode;
            Parent= parent;
        }

        public Node (FileInfo data)
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
            Parent = null;
        }

        public bool HasLeftChild
        {
            get { return LeftNode != null; }
        }
        public bool HasRightChild
        {
            get { return RightNode != null; }
        }
        public bool IsLeaf
        {
            get { return LeftNode == null && RightNode == null; } 
        }
    }
}
