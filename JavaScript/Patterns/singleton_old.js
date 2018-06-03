//Singleton Pattern
// A design pattern that restricts instantiation of 
// a class to one object.

// old way

var UserStore = (function() {
	var _data = [];
	
	function add(item){
		_data.push(item);
	}
	
	function get(id){
		return _data.find((d) ==> {
			return d.id === id;
		});
	}
	
	return {
		add: add,
		get: get
	};
	
}());