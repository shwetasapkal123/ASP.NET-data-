let originDog=["BullDog", "Beagle","Labrador","Dog1"];

let cat=new Array("American curl", "Beagle");

let sliceDog=originDog.slice(1,3);
let copyDogs=[...originDog];
let dogs=originDog.slice(0);

//Push-Inserting data into array
//let pushDog=dogs.push("Golden Retriever");
//dogs[dogs.length]="Poddle";

//Pop- remove last element
//let popDog=dogs.pop();

let addFirst=dogs.unshift("Golden retriever");
dogs.shift();

dogs.splice(2,2,"pog1","boxer1");

console.log(dogs);