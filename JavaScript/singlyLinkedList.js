function LinkedList(value, next) {
    this._value = value;
    this._next = next;
}
LinkedList.prototype.value = function() {
	if (arguments.length == 1)
		this._value = arguments[0];
	else
		return this._value;
}
LinkedList.prototype.next = function() {
	if (arguments.length ==1)
		this._next = arguments[0];
	else
		return this._next;
}

//creating linked list
function createLinkedListFromArray(ary) {
	var head = new LinkedList (ary[0], null);
	var prev = head;
	for (var i = 1; i < ary.length;)
}