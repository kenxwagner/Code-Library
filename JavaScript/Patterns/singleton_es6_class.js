//Singleton Pattern
// A design pattern that restricts instantiation of 
// a class to one object.

// class added

class UserStore {
		constructor(){
			if(! UserStore.instance){
				this._data = [];
				UserStore.instance = this;
			}
			
		}
	
	
	return UserStore.instance;
}



Object.freeze(UserStore);

export default UserStore;