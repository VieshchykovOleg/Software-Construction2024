using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepthFirstIterator : IIterator
{
    private Stack<LightNode> stack;

    public DepthFirstIterator(LightNode root)
    {
        stack = new Stack<LightNode>();
        stack.Push(root);
    }

    public bool HasNext()
    {
        return stack.Count > 0;
    }

    public LightNode Next()
    {
        while (stack.Count > 0)
        {
            LightNode node = stack.Pop();
            if (node is LightElementNode elementNode)
            {
               
                for (int i = elementNode.ChildCount - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.GetChild(i));
                }
            }
            return node;
        }
        return null; 
    }
}
