namespace Sodium
{

  public class BehaviorSink<TA> : Behavior<TA> where TA : class
  {
    public BehaviorSink(TA initValue)
      : base(new EventSink<TA>(), initValue)
    {
    }

    public void Send(TA a)
    {
      ((EventSink<TA>)Event).Send(a);
    }
  }

}
