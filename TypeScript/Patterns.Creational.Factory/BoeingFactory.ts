import Boeing737_Max10 from "./Boeing737";
import Boeing747_8I from "./Boeing747";
import Boeing767_300ER from "./Boeing767";
import Boeing777X from "./Boeing777";
import Boeing787_10 from "./Boeing787";
import BoeingAircraftTypes from "./BoeingAircraftTypes";
import IAircraft from "./IAircraft";


interface IAircraftFactory {
    CreateAircraft(aircraftType: any): IAircraft;
}



class BoeingFactory implements IAircraftFactory {
    constructor() {

    }

    public CreateAircraft(aircraftType: BoeingAircraftTypes): IAircraft {
        switch (aircraftType) {
            case BoeingAircraftTypes.B737_Max10:
                return new Boeing737_Max10();
            case BoeingAircraftTypes.B747_8I:
                return new Boeing747_8I();
            case BoeingAircraftTypes.B767_300ER:
                return new Boeing767_300ER();
            case BoeingAircraftTypes.B777X:
                return new Boeing777X();
            case BoeingAircraftTypes.B787_10:
                return new Boeing787_10();
        }
    }
}

export default BoeingFactory; 