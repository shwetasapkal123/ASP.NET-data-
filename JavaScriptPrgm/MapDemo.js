var map1=new Map([ [1,2],[2,3],[4,5]]);
//console.log(map1);

var map2=new Map([ ["firstName","Shweta"],["lastName","Sapkal"],["website","Bridgelab"] ]);
//let keyString="a string";
//map2.set(keyString," value associated with a string");


map2.set("friend","Roe");
//console.log(map2);

let iskey=map2.has("a string");
//console.log(iskey);

let getvalue=map2.get("website");
console.log(getvalue);

for (let [key,value] of map2.entries())
console.log("loop2  key: "+key+"  value  "+value);

for (let value of map2.values())
console.log("loop4  value: "+value);

