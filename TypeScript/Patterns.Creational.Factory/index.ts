import BoeingAircraftTypes from "./BoeingAircraftTypes";
import BoeingFactory from "./BoeingFactory";

console.log('=== Factory pattern ===');

const boeingFactory = new BoeingFactory();
let aircraft = [];

for(let aircraftType in BoeingAircraftTypes){
    if (!isNaN(Number(aircraftType))) 
        continue;
    
        aircraft.push(boeingFactory.CreateAircraft(aircraftType as BoeingAircraftTypes));
}

aircraft.forEach(aircraft => {
    console.log(aircraft.DisplayAircraftData());
});
