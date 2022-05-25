public class Main {
    public static void main(String[] args) {
      

    
    
        IService service = new ServiceB();
        IClient client1 = new ClientA(service);
        
        System.out.println(client1.doSomething());

        ((ClientA) client1).setService(new ServiceC());
        System.out.println(client1.doSomething());
        
}
}
