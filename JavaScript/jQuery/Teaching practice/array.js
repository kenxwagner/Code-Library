// Returns a NodeList
var elems = document.getElementsByTagName( "div" );
// Convert the NodeList to an Array
var arr = jQuery.makeArray( elems );
// Use an Array method on list of dom elements
arr.reverse();
$( arr ).appendTo( document.body );
