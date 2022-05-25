public class ClientA implements IClient{
    
    IService service;

    public ClientA(IService service){
        this.service = service;
    }

    @Override    
    public String doSomething(){
        String info = service.getInfo();
        return info;
    }

    public void setService(IService service) {
        this.service = service;
    }
}
