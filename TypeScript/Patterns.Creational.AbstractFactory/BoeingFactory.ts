import Aircraft from "./Aircraft";
import AircraftFactory from "./AircraftFactory";
import Boeing787_10 from "./Boeing787_10";

class BoeingFactory implements AircraftFactory {
    constructor() {

    }
    public CreateAircraft(numberOfSeats: number): Aircraft {
        return new Boeing787_10(numberOfSeats);
    }


}

export default BoeingFactory; 