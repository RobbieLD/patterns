import Aircraft from "./Aircraft";

abstract class AircraftFactory {
    constructor() {

    }

    public abstract CreateAircraft(numberOfSeats: number): Aircraft;
}

export default AircraftFactory; 