public static class MyStaticClass
{

}

public class MyNonStaticClass
{
    public int Score { get; set; }

}

public class MyOtherClassThatInstantiates
{
    public MyOtherClassThatInstantiates()
    {
        MyNonStaticClass instance = new MyNonStaticClass();

        foreach (var tank in Tank.AllEnabledTanks)
        {

        }
    }
}