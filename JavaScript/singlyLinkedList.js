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