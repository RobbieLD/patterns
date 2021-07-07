import IAircraft from "./IAircraft";

class Boeing747_8I implements IAircraft {
    constructor(){}

    DisplayAircraftData(): string {
        return "Boeing 747 8I";
    }
}

export default Boeing747_8I;