namespace Singleton.Data;

class SingletonCount {
    private static SingletonCount instance = null;
    private int counter = 0;

    private SingletonCount() { }

    public static SingletonCount Instance {
        get {
            if (instance == null) {
                instance = new SingletonCount();
            }
            return instance;
        }
    }

    public int Counter {
        get { return counter; }
        set { counter = value; }
    }

}
