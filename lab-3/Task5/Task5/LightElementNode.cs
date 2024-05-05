using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LightElementNode : LightNode
{
    private List<LightNode> children = new List<LightNode>();
    private List<string> classes = new List<string>();

    // Додайте метод AddClass для додавання класу
    public void AddClass(string className)
    {
        classes.Add(className);
    }

    public string TagName { get; }
    public DisplayType DisplayType { get; }
    public ClosingType ClosingType { get; }
    public List<string> Classes { get; }
    public int ChildCount => children.Count;
    public LightNode GetChild(int index)
    {
        if (index >= 0 && index < children.Count)
        {
            return children[index];
        }
        else
        {
            return null;
        }
    }


    public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
    {
        TagName = tagName;
        DisplayType = displayType;
        ClosingType = closingType;
        Classes = new List<string>();
    }

    public void AddChild(LightNode child)
    {
        children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string result = $"<{TagName}";
            if (Classes.Count > 0)
            {
                result += $" class=\"{string.Join(" ", Classes)}\"";
            }
            result += ">";
            foreach (var child in children)
            {
                result += child.OuterHTML;
            }
            if (ClosingType == ClosingType.WithClosingTag)
            {
                result += $"</{TagName}>";
            }
            else if (ClosingType == ClosingType.SelfClosingTag)
            {
                result += " />";
            }
            return result;
        }
    }
}