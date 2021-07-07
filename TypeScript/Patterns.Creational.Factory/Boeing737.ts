import IAircraft from "./IAircraft";

class Boeing737_Max10 implements IAircraft {
    constructor(){}

    DisplayAircraftData(): string {
        return "Boeing 737 Max 10";
    }

}

export default Boeing737_Max10;