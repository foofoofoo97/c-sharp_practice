using System;

namespace c_sharp_practice
{
    class Sample
    {

        //delegate object is a type that refer to a method;
        public delegate int Calculator(int a, int b);

        public int Add(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }

        public Sample()
        {
            //MultiCasting //can execute all function at once
            Calculator calculator = Add;
            calculator += Minus; //-= is also allowed
        }

        //covariance, contravariance
        //delegate = method (with inherited parameters is acceptable)
    }

    public interface Event
    {
        event EventHandler<int[]> eventTriggered;
        int No { set; }
    }

    public class EventTrigger : Event
    {
        int max;

        public EventTrigger(int _max)
        {
            max = _max;
        }

        //delegate{} is to prevent nullCheckException
        public event EventHandler<int[]> eventTriggered = delegate { };

        public int No
        {
            set
            {
                var no = value;
                if (no > max)
                {
                    eventTriggered(this, new int[] { value });
                }
            }
        }

    }

    class Activity : PracticeBase
    {
        public override void runResult()
        {
            EventTrigger trigger = new EventTrigger(20); // max =20

            //define functions that will called when event triggered
            trigger.eventTriggered += (o, e) => Console.WriteLine(e);
            trigger.eventTriggered += (o, e) => Console.WriteLine("event triggered");

            trigger.No = 30; //event will triggered (>max)
            trigger.No = 19; //event will not be triggered (<max)
        }
    }

}

