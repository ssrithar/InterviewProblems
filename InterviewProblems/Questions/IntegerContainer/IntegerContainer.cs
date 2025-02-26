
namespace IntegerContainer
{
  using System.Collections.Generic;
  using System;
  using System.Linq;
  
  public class IntegerContainer : IntegerContainerBase
  {
    private List<int> integerContainer = new List<int>();
  
    // TODO: implement interface methods here
    public override int Add(int value)
    {
      if (value < 0)
      {
        return -1;
      }
      
      this.integerContainer.Add(value);
      return this.integerContainer.Count;
    }

    public override bool Delete(int value)
    {
      if (this.integerContainer.Exists(item => item == value))
      {
        this.integerContainer.Remove(value);
        return true;
      }
      else
      {
        return false;
      }
    }
    
    public override int? GetMedian()
    {
      var intContainerCount = this.integerContainer.Count;
      Console.WriteLine(intContainerCount);
      
      if (intContainerCount == 0)
      {
        return null;
      }
      
      this.integerContainer.Sort();
      
      if (intContainerCount % 2 > 0)
      {
        return this.integerContainer[(intContainerCount / 2) + 1];
      }
      else
      {
        return this.integerContainer[intContainerCount / 2];
      }
    }
  }
}
