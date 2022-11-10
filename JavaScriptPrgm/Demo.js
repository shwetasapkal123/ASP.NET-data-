console.log("hello");
/* create variables
1 let
2. const
3.var */

/*var a=10;
let b=20;
var c=a+b;
console.log(c);*/

/*Datatypes*/
/*var val;
var datatype=typeof val;

var val=10;
var datatype=typeof val;

var val=true;
var datatype=typeof val;

var val="foo";
var datatype=typeof val;

var datatype=typeof Symbol("id");

var datatype=typeof Math;

var datatype=typeof null;

var sayHi=function()
{
    console.log.apply("sayHi");
}

var datatype=typeof sayHi;
console.log(datatype);

if(5>2)
{
    console.log("Inside if block");
    let addr="delhi";
    console.log(addr);
    var city="Pune";
    console.log(city);
}

city="Satara";
console.log(city);*/

var map1 = new Map([[1 , 2], [2 ,3 ] ,[4, 5]]);
 
console.log("Map1");
console.log(map1);
 let keystring="a string";
var map2 = new Map([["firstname" ,"sumit"],
        ["lastname", "ghosh"], ["website", "geeksforgeeks"]]);
 map2.set(keystring,"a value associated with a string");
 let keyexist=map2.has("a string");
console.log("Map2");
for(let [key,value] of map2)
console.log("key "+key+" value "+value);
console.log("new value");
for(let [key,value] of map2.entries())
console.log("key "+key+" value "+value);
//console.log(keyexist);
let getValue=map2.get("website");
let iskey=map2.has('lastname');
//console.log(getValue);
map2.set("friend","Snehal");
//console.log(map2);
