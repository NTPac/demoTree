using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Control
    {
        public static void printTree(ClassTree classTree, int lv)
        {
            string space = "";
            for(int i = 0; i < lv; i++)
            {
                space = space + "   ";
            };
            Console.WriteLine(space+"name: "+classTree.getName());
            if (classTree.GetListTree() != null)
            {
                lv = lv + 1;
                Console.WriteLine(space+"{");
                foreach (var item in classTree.GetListTree())
                {
                    printTree(item,lv);
                };
                Console.WriteLine(space + "}");
            };
        }
    }
}
