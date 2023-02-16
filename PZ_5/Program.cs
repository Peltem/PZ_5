static void Main(string[] args)
{

    Publisher publisher = new Publisher();
    ConcreteSubscriber s = new ConcreteSubscriber();
    publisher.Subscribe(s);

}

public class Publisher
{

    private Subscruber[] _subscribers;
    private string _mainState;
    public void Subscribe(Subscruber s)
    {

    }
    public void UnSubscribe(Subscruber s)
    {
        
    }

    public void notifySubscribers()
    {

    }
    public void mainBuisnessLogic()
    {

    }
}
public interface Subscruber
{

}
public class ConcreteSubscriber : Subscruber
{

}
