﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LightElementNode : LightNode, IComposite
{
    private List<LightNode> children = new List<LightNode>();

    public string TagName { get; }
    public DisplayType DisplayType { get; }
    public ClosingType ClosingType { get; }
    public List<string> Classes { get; }
    public IReadOnlyList<LightNode> Children => children.AsReadOnly();

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
