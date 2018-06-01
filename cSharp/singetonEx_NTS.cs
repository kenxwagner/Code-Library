// A Singleton is a class which only allows a 
//single instance of it to be created. During 
//the application run time, only one instance 
//of the singleton class will exist for all users.

//NOT THREAD SAFE
public sealed class SingletonClass
{
	private static SingletonClass _instance=null;
	
	private SingletonClass() { }
	
	public static SingletonClass SingleInstance
	{
		get
		{
			if(_instance==null)
			{
			
				_instance = new SingletonClass();
			}
			return _instance;
		}
	}
	
}