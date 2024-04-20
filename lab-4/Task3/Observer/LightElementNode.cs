using CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LightElementNode : LightNode
{
    private List<LightNode> children = new List<LightNode>();
    private Dictionary<string, Action> eventListeners = new Dictionary<string, Action>();

    public string TagName { get; }
    public DisplayType DisplayType { get; }
    public ClosingType ClosingType { get; }
    public List<string> Classes { get; }
    public int ChildCount => children.Count;

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

    public void AddEventListener(string eventType, Action listener)
    {
        if (!eventListeners.ContainsKey(eventType))
        {
            eventListeners[eventType] = listener;
        }
        else
        {
            eventListeners[eventType] += listener;
        }
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
            foreach (var eventType in eventListeners.Keys)
            {
                result += $" {eventType}";
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