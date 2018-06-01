// A Singleton is a class which only allows a 
//single instance of it to be created. During 
//the application run time, only one instance 
//of the singleton class will exist for all users.

//THREAD SAFE
public sealed class SingletonClass
{
	private static SingletonClass _instance=null;
	private static readonly object _lock =  new object();

	SingletonClass() { }
	
	public static SingletonClass SingleInstance
	{
		get
		{
			lock (_lock)
			{
				if(_instance==null)
				{
			
					_instance = new SingletonClass();
				}
				return _instance;
				
			}
		}
	}
	
}