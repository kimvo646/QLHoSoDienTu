using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace QLHoSoDienTu
{
    internal class TreeDate
    {
        Node Root;
        int Count;

        public Node _Root
        {
            get { return Root; }
            set { Root = value; }
        }

        public int _Count { 
            get { return Count; } 
            set { Count = value; }
        }

        public TreeDate()
        {
            Root = null;
            Count= 0;
        }
        public TreeDate(Node root, int count)
        {
            Root = root;
            Count = count;
        }

        public TreeDate(string Path) 
        {
            try
            {
                string[] data = File.ReadAllLines(Path);
                for (int i = 0; i < data.Length; i = i + 2)
                {
                    if (data[i] != "" && data[i + 1] != "")
                    {
                        string name = data[i];
                        DateTime date = DateTime.ParseExact(data[i + 1].Trim(), "dd/MM/yyyy", null);
                        FileInfo f = new FileInfo(name,date);
                        AddNode(f);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Update(string Path)
        {
            TraverseList = new List<FileInfo>();
            InOrderTraverse(Root);
            string[] data = new string[TraverseList.Count*2];
            int i = 0;
            foreach (FileInfo l in TraverseList)
            {
                data[i] = l._Name;
                data[i+1] = l._Date.ToString("dd/MM/yyyy"); i=i+2;
            }
            File.WriteAllLines(Path, data);
        }

        List<FileInfo> TraverseList = new List<FileInfo>();

        public List<FileInfo> _TraverseList
        {
            get { return TraverseList; }
            set { TraverseList = value; }
        }

        public void InOrderTraverse(Node node)
        {
            List<FileInfo> list = new List<FileInfo>();
            if (node == null)
                return;
            InOrderTraverse(node._LeftNode);
            TraverseList.Add(node._Data);
            InOrderTraverse(node._RightNode);
        }

        public bool Add(Node parent, Node node)
        {
            if (parent._Data._Date == node._Data._Date)
            {
                return false;
            }

            if (parent._Data._Date > node._Data._Date)
            {
                if (!parent.HasLeftChild)
                {
                    parent._LeftNode = node;
                    node._Parent= parent;
                    Count++;
                    return true;
                }
                else
                {
                    return Add(parent._LeftNode, node);
                }
            }
            else
            {
                if (!parent.HasRightChild)
                {
                    parent._RightNode = node;
                    node._Parent= parent;
                    Count++;
                    return true;
                }
                else
                {
                    return Add(parent._RightNode, node);
                }
            }
        }

        public void AddNode(FileInfo f)
        {
            Node newnode = new Node(f);
            if (Root== null)
            {
                Root = newnode;
                return;
            }
            Add(Root, newnode);
        }

        public bool Remove(Node node, FileInfo value)
        {
            if (node == null)
                return false;

            if (node._Data._Date == value._Date)
            {
                if (node.IsLeaf) // no children
                {
                    if (node._Parent._LeftNode == node)
                        node._Parent._LeftNode = null;
                    else
                        node._Parent._RightNode = null;

                    node._Parent = null;
                }
                else if (node.HasLeftChild && node.HasRightChild)   // 2 children
                {
                    // Tìm successor node
                    Node replacementNode = node._RightNode;

                    while (replacementNode.HasLeftChild)
                    {
                        replacementNode = replacementNode._LeftNode;
                    }
                    node._Data = replacementNode._Data;

                    Remove(replacementNode, replacementNode._Data);
                }
                else    // one child
                {
                    Node subNode;

                    if (node.HasLeftChild)
                        subNode = node._LeftNode;
                    else
                        subNode = node._RightNode;

                    if (Root == (subNode))
                        Root = subNode;

                    subNode._Parent = node._Parent;

                    if (node._Parent._LeftNode == node)
                        node._Parent._LeftNode = subNode;
                    else
                        node._Parent._RightNode = subNode;
                }
                Count--;
                return true;
            }
            else
            {
                if (node._Data._Date > value._Date)
                    return Remove(node._LeftNode, value);
                else
                    return Remove(node._RightNode, value);
            }
        }

        public void DeleteNode(FileInfo f)
        {

            bool re = Remove(Root, f);
            if (re)
            {
                MessageBox.Show("Xóa hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa hồ sơ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Update(Program.Path);
        }

        public List <FileInfo> FineDate(Node node, DateTime a, DateTime b)
        {
            List<FileInfo> result = new List<FileInfo>();
            
            while (node != null)
            {
                if (node._Data._Date >= a && node._Data._Date <= b)
                {
                    result.Add(node._Data);
                    if (node!= null)
                    {
                        Node tmp = node;
                        node = tmp._RightNode;
                        result.AddRange(FineDate(node, a, b));

                        node = tmp._LeftNode;
                        result.AddRange(FineDate(node, a, b));
                    }
                }
                else
                {
                    if (node._Data._Date < a)
                    { 
                        node = node._RightNode;
                    }
                    else
                    if (node._Data._Date > b)
                    {
                        node = node._LeftNode;
                    }
                }
            }
            return result;
        }
    }
}
