using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTUc3
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get;
            set;
        }
        public BinarySearchTree<T> LeftTree //Generic getter and setter method use  for LeftTree
        {
            get;
            set;
        }
        public BinarySearchTree<T> RightTree // getter and setter method use  for RightTree
        {
            get;
            set;
        }

        public BinarySearchTree(T nodeData) //Initialize the para constructor using instance veriablr
        {
            this.NodeData = nodeData;  //NodeDate Assign the value from nodeData instance variable
            this.LeftTree = null;  //the  Lefttree node is Assign the null value
            this.RightTree = null;  // Righttree node is Assign null value
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData; //create a new node

            if ((currentNodeValue.CompareTo(item)) > 0)  //compare current node value and checking the condition
            {
                if (this.LeftTree == null)  // lefttree is null then assigned to newNode
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                    this.LeftTree.Insert(item);  // lefttree is not null then insert data
            }
            else
            {
                if (this.RightTree == null) // righttree is null then assigned to newNode
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                    this.RightTree.Insert(item); // righttree is not null then insert data
            }
        }

        public void display()  //here use Display
        {
            if (this.LeftTree != null)  //  left tree is not null
            {
                this.leftCount++;       // Count left Node Nd increament node
                this.LeftTree.display(); //recursive call display method
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)  //  right tree is not null
            {
                this.rightCount++;  // right Node ncount and increament
                this.RightTree.display();  // call display method
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }

        public bool IFExits(T element, BinarySearchTree<T> Node)
        {
            if (Node == null) //node is null then false
            {
                return false;
            }
            if (Node.NodeData.Equals(element)) //Search nodeData checking the emlement by using equal method
            {
                Console.WriteLine("\n found the element in BST" + "" + Node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("\n Current Ele is {0} in BST", Node.NodeData);
            }
            if (element.CompareTo(Node.NodeData) < 0)  //CompareTo both element and nodeData value and checkinng condition 
            {
                IFExits(element, Node.LeftTree);     // if less than Zero insert at left tree           
            }
            if (element.CompareTo(Node.NodeData) > 0)  //CompareTo both element and nodeData value and checkinng condition
            {
                IFExits(element, Node.RightTree);  //if Greater than Zero insert at left tree
            }
            return result;

        }
    }
    
}
