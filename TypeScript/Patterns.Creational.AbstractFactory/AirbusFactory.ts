import Airbus_A380 from "./Airbus_A380";
import Aircraft from "./Aircraft";
import AircraftFactory from "./AircraftFactory";

class AirbusFactory implements AircraftFactory {
    constructor() {

    }
    public CreateAircraft(numberOfSeats: number): Aircraft {
        return new Airbus_A380(numberOfSeats);
    }


}

export default AirbusFactory; 