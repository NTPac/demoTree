using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class ClassTree
    {
        private String name;
        private List<ClassTree> listTree;

        public ClassTree(string name, List<ClassTree> list)
        {
            this.name = name;
            this.listTree = list;
        }

        public ClassTree(string name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public List<ClassTree> GetListTree()
        {
            return this.listTree;
        }
    }
}
