using System;
using System.Collections.Generic;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassTree tree1 = new ClassTree("a");
            ClassTree tree2 = new ClassTree("b");
            ClassTree tree3 = new ClassTree("c");
            List<ClassTree> trees = new List<ClassTree>();
            trees.Add(tree2);
            trees.Add(tree3);
            ClassTree tree4 = new ClassTree("d",trees);
            ClassTree tree5 = new ClassTree("e");
            trees = new List<ClassTree>();
            trees.Add(tree2);
            trees.Add(tree3);
            trees.Add(tree4);
            trees.Add(tree5);
            ClassTree tree6 = new ClassTree("f",trees);
            trees = new List<ClassTree>();
            trees.Add(tree2);
            trees.Add(tree3);
            trees.Add(tree4);
            trees.Add(tree5);
            trees.Add(tree6);
            ClassTree tree7 = new ClassTree("g", trees);

            Control.printTree(tree7,0);
        }
    }
}
