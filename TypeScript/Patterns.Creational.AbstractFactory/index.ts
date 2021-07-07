import AirbusFactory from "./AirbusFactory";
import BoeingFactory from "./BoeingFactory";

console.log('Abstract factory pattern');

const boeingFactory = new BoeingFactory();
let boeingAircraft = boeingFactory.CreateAircraft(120); 
console.log(`${boeingAircraft.DisplayManufacturerInformation()} with ${boeingAircraft.numberOfSeats} number of seats.`);

const airbusFactory = new AirbusFactory();
let airbusAircraft = airbusFactory.CreateAircraft(300); 
console.log(`${airbusAircraft.DisplayManufacturerInformation()} with ${airbusAircraft.numberOfSeats} number of seats.`);