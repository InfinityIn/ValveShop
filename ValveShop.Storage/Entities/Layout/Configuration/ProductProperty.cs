using System.Collections.Immutable;

namespace webapi.Models
{
  public class ProductProperty
  {
    public ProductProperty(int _id, string _name, int _priority) 
    {
      Id = _id;
      Name = _name;
      Priority = _priority;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }
    public int FollowedMenuItem { get; set; }
  }

  public class CheckBoxProductProperty : ProductProperty
  {
    public CheckBoxProductProperty(int _id, string _name, int _priority, bool _defaultValue) : base(_id, _name, _priority)
    {
      DefaultValue = _defaultValue;
    }
    public bool DefaultValue { get; set; }
  }

  public class RadioGroupProductProperty : ProductProperty
  {
    public RadioGroupProductProperty(int _id, string _name, int _priority, int _defaultValue, IReadOnlyDictionary<string, int> _values) 
      : base(_id, _name, _priority)
    {
      DefaultValue = _defaultValue;
      Values = _values.ToImmutableDictionary();
    }
    public int DefaultValue { get; set; }
    public bool HorizontalLayout { get; set; }
    public ImmutableDictionary<string, int> Values { get; set; }

  }
}
 